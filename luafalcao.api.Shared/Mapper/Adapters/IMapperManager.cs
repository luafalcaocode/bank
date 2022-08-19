namespace luafalcao.api.Shared.Adapters
{
    public interface IMapperManager
    {      
        TDestination Map<TSource, TDestination>(TSource source);
        TDestination MapType<TSource, TDestination>(TSource source);
    }
}
