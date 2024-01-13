using AutoMapper;
using Business.Models;
using FirstRestAPI.Models;
using FirstRestAPI.ViewModels;

namespace FirstRestAPI.Config;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Supplier, SupplierViewModel>().ReverseMap();
        CreateMap<Product, ProductViewModel>().ReverseMap();
        CreateMap<Address, AddressViewModel>().ReverseMap();
    }
}
