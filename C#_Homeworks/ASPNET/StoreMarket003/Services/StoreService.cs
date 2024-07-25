using AutoMapper;
using Azure.Core;
using Microsoft.Extensions.Caching.Memory;
using StoreMarket003.Abstractions;
using StoreMarket003.Contexts;
using StoreMarket003.Contracts.Requests;
using StoreMarket003.Contracts.Responses;
using StoreMarket003.Models;

namespace StoreMarket003.Services
{
    public class StoreService : IStoreService
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public readonly IMemoryCache _cache;

        public StoreService(StoreContext context, IMapper mapper, IMemoryCache cache)
        {
            _context = context;
            _mapper = mapper;
            _cache = cache;
        }

        public int AddStore(StoreCreateRequest request)
        {
            var entity = _mapper.Map<Store>(request);
            _context.Stores.Add(entity);
            _context.SaveChanges();
            _cache.Remove("stores");
            return entity.Id;
        }

        public bool DeleteStore(int id)
        {
            var result = _context.Stores.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                _context.Stores.Remove(result);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public StoreResponse? GetStoreById(int id)
        {
            var result = _context.Stores.FirstOrDefault(x => x.Id == id);
            if (result == null) { return null; }
            return _mapper.Map<StoreResponse>(result);
        }

        public IEnumerable<StoreResponse> GetStores()
        {
            if (_cache.TryGetValue("stores", out IEnumerable<StoreResponse>? result))
            {
                return result!;
            }
            IEnumerable<StoreResponse> categories = _context.Stores.Select(_mapper.Map<StoreResponse>).ToList();
            _cache.Set("stores", categories, TimeSpan.FromMinutes(30));
            return categories;
        }

        public bool UpdateStoreName(int id, string name)
        {
            var entity = _context.Stores.FirstOrDefault(x => x.Id == id);

            if (entity != null)
            {
                entity.Name = name;
                _context.Stores.Update(entity);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool AddProductToStore(ProductStoreCreateRequest request)
        {
            var entity = _mapper.Map<ProductStore>(request);
            var product = _context.Products.FirstOrDefault(x => x.Id == request.ProductId);
            var store = _context.Stores.FirstOrDefault(x => x.Id == request.StoreId);

            if (product == null || store == null) return false;
            _context.ProductStores.Add(entity);
            store.Count++;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteProductFromStore(int storeId, int productId)
        {
            var result = _context.ProductStores.FirstOrDefault(x => x.ProductId == productId && x.StoreId == storeId);
            var store = _context.Stores.FirstOrDefault(x => x.Id == storeId);

            if (result != null && store != null)
            {
                _context.ProductStores.Remove(result);
                store.Count--;
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }
    }
}
