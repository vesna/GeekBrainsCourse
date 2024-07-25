using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using StoreMarket002.Abstractions;
using StoreMarket002.Contexts;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;
using System.Text;

namespace StoreMarket002.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public readonly IMemoryCache _cache;

        public ProductService(StoreContext context, IMapper mapper, IMemoryCache cache) {
            _context = context;
            _mapper = mapper;
            _cache = cache;
        }
        public int AddProduct(ProductCreateRequest request)
        {
            var entity = _mapper.Map<ProductModel>(request);
            _context.Products.Add(entity);
            _context.SaveChanges();
            _cache.Remove("products");
            return entity.Id;
        }

        public ProductResponse? GetProductById(int productId)
        {
            var result = _context.Products.FirstOrDefault(x => x.Id == productId);
            if(result == null) { return null; }
            return _mapper.Map<ProductResponse>(result);
        }

        public IEnumerable<ProductResponse> GetProducts()
        {
            if(_cache.TryGetValue("products", out IEnumerable<ProductResponse>? result))
            {
                return result!;
            }
            IEnumerable<ProductResponse> products = _context.Products.Select(_mapper.Map<ProductResponse>).ToList();
            _cache.Set("products", products, TimeSpan.FromMinutes(30));
            return products;
        }

        public void DeleteProduct(ProductDeleteRequest request)
        {
            var result = _context.Products.FirstOrDefault(x => x.Id == request.Id);

            if (result != null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
        }

        public ProductResponse UpdateProduct(ProductUpdateRequest request)
        {
            var entity = _mapper.Map<ProductModel>(request);
            var result = _context.Products.Update(entity);
            _context.SaveChanges();

            return _mapper.Map<ProductResponse>(result);
        }

        public ProductResponse? GetProductByName(string name)
        {
            var result = _context.Products.FirstOrDefault(x => x.Name == name);
            if (result == null) { return null; }
            return _mapper.Map<ProductResponse>(result);
        }
    }
}
