using AutoMapper;

namespace qhnam.Data.Model.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelMappingProfile());
                config.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}