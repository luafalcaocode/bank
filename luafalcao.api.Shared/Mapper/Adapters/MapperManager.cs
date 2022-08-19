using AutoMapper;

namespace luafalcao.api.Shared.Adapters
{
    public class MapperManager : IMapperManager
    {
        private IMapper mapper;

        public MapperManager(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return this.mapper.Map<TDestination>(source);
        }

        public TDestination MapType<TSource, TDestination>(TSource source)
        {
            return (TDestination)mapper.Map(source, source.GetType(), typeof(TDestination));
        }
     
    }
}
