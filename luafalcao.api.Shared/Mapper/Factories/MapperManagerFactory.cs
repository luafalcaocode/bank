using AutoMapper;
using luafalcao.api.Shared.Adapters;
using luafalcao.api.Shared.Mapper.Enums;

namespace luafalcao.api.Shared.Mapper.Factories
{
    public class MapperManagerFactory
    {
        private static string[] assemblies = new string[]
        {
            "luafalcao.api.Domain"
        };

        public static IMapperManager Create(MapperTypeEnum type)
        {
            IMapperManager mapperManager = null;

            switch (type)
            {
                case MapperTypeEnum.AutoMapper:
                    var mapper = new MapperConfiguration(config =>
                    {
                        foreach (var assemblyName in assemblies)
                        {
                            config.AddMaps(assemblyName);
                        }
                    });

                    mapperManager = new MapperManager(mapper.CreateMapper());

                    break;                
            }

            return mapperManager;
        }

    }
}
