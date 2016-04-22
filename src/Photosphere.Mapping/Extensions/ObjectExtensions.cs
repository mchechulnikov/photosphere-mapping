using Photosphere.Mapping.Static;

namespace Photosphere.Mapping.Extensions
{
    public static class ObjectExtensions
    {
        public static void Map<TSource, TTarget>(this TTarget target, TSource source)
            where TTarget : class, new()
        {
            StaticMapper<TSource, TTarget>.Map(source, target);
        }

        public static TTarget Map<TSource, TTarget>(this TSource source)
            where TTarget : class, new()
        {
            return StaticMapper<TSource, TTarget>.Map(source);
        }

        public static void Map(this object target, object source)
        {
            StaticMapper.Map(source, target);
        }
    }
}