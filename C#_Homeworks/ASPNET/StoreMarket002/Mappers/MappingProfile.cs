using AutoMapper;
using StoreMarket002.Contracts.Requests;
using StoreMarket002.Contracts.Responses;
using StoreMarket002.Models;

namespace StoreMarket002.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
            CreateMap<ProductModel, ProductResponse>(MemberList.Destination).ReverseMap();
            CreateMap<ProductModel, ProductCreateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<ProductModel, ProductDeleteRequest>(MemberList.Destination).ReverseMap();
            CreateMap<ProductModel, ProductUpdateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<CategoryModel, CategoryResponse>(MemberList.Destination).ReverseMap();
            CreateMap<CategoryModel, CategoryCreateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<CategoryModel, CategoryDeleteRequest>(MemberList.Destination).ReverseMap();
            CreateMap<CategoryModel, CategoryUpdateRequest>(MemberList.Destination).ReverseMap();
        }
    }
}
