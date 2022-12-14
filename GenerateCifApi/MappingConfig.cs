using AutoMapper;
using GenerateCifApi.Models;
using GenerateCifApi.Models.Dto;

namespace GenerateCifApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CifUserDto, CifUser>();
                config.CreateMap<CifUser, CifUserDto>();
            });
            return mappingConfig;
        }
    }
}
