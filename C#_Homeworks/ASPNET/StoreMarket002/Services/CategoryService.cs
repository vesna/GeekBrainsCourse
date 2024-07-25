using AutoMapper;
using Azure.Core;
using Microsoft.Extensions.Caching.Memory;
using StoreMarket002.Abstractions;
using StoreMarket002.Contexts;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;

namespace StoreMarket002.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public readonly IMemoryCache _cache;

        public CategoryService(StoreContext context, IMapper mapper, IMemoryCache cache)
        {
            _context = context;
            _mapper = mapper;
            _cache = cache;
        }

        public int AddCategory(CategoryCreateRequest request)
        {
            var entity = _mapper.Map<CategoryModel>(request);
            _context.Categories.Add(entity);
            _context.SaveChanges();
            _cache.Remove("categories");
            return entity.Id;
        }

        public void DeleteCategory(CategoryDeleteRequest request)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == request.Id);

            if (result != null)
            {
                _context.Categories.Remove(result);
                _context.SaveChanges();
            }
        }

        public CategoryResponse? GetCategoryById(int categoryId)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == categoryId);
            if (result == null) { return null; }
            return _mapper.Map<CategoryResponse>(result);
        }

        public IEnumerable<CategoryResponse> GetCategorys()
        {
            if (_cache.TryGetValue("categories", out IEnumerable<CategoryResponse>? result))
            {
                return result!;
            }
            IEnumerable<CategoryResponse> categories = _context.Categories.Select(_mapper.Map<CategoryResponse>).ToList();
            _cache.Set("categories", categories, TimeSpan.FromMinutes(30));
            return categories;
        }

        public CategoryResponse UpdateCategory(CategoryUpdateRequest request)
        {
            var entity = _mapper.Map<CategoryModel>(request);
            var result = _context.Categories.Update(entity);
            _context.SaveChanges();

            return _mapper.Map<CategoryResponse>(result);
        }

        public CategoryResponse? GetCategoryByName(string name)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Name == name);
            if (result == null) { return null; }
            return _mapper.Map<CategoryResponse>(result);
        }
    }
}
