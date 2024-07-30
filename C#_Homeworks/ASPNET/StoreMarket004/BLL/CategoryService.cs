using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Microsoft.Extensions.Caching.Memory;
using StoreMarket004.BLL.Abstractions;
using StoreMarket004.DAL.Contexts;
using StoreMarket004.DAL.Models;

namespace StoreMarket004.BLL
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
            var entity = _mapper.Map<Category>(request);
            _context.Categories.Add(entity);
            _context.SaveChanges();
            _cache.Remove("categories");
            return entity.Id;
        }

        public bool DeleteCategory(int id)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                _context.Categories.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public CategoryResponse? GetCategoryById(int id)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (result == null) { return null; }
            return _mapper.Map<CategoryResponse>(result);
        }

        public IEnumerable<CategoryResponse> GetCategories()
        {
            if (_cache.TryGetValue("categories", out IEnumerable<CategoryResponse>? result))
            {
                return result!;
            }
            IEnumerable<CategoryResponse> categories = _context.Categories.Select(_mapper.Map<CategoryResponse>).ToList();
            _cache.Set("categories", categories, TimeSpan.FromMinutes(30));
            return categories;
        }

        public bool UpdateCategoryName(int id, string name)
        {
            var entity = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (entity != null)
            {
                entity.Name = name;
                _context.Categories.Update(entity);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        /*public CategoryResponse? GetCategoryByName(string name)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Name == name);
            if (result == null) { return null; }
            return _mapper.Map<CategoryResponse>(result);
        }*/
    }
}
