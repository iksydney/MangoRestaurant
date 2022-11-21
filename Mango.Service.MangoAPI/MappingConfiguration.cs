using AutoMapper;
using Mango.Service.MangoAPI.DTO;
using Mango.Service.MangoAPI.Entities;

namespace Mango.Service.MangoAPI
{
    public class MappingConfiguration : Profile
    {
        /*public MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDTO>();
                config.CreateMap<ProductDTO, Product>();
            });
            return mappingConfig;
        }*/
        public MappingConfiguration()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
