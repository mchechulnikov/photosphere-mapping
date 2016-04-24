using Photosphere.Mapping.Static;

namespace Photosphere.Mapping.Extensions
{
    public static class MappingObjectExtensions
    {
        /// <summary> Map from source to existent object target</summary>
        public static void MapTo<TSource, TTarget>(this TSource source, TTarget target)
            where TTarget : class, new()
        {
            StaticMapper<TSource, TTarget>.Map(source, target);
        }

        /// <summary> Map from source to new object of TTarget</summary>
        public static TTarget Map<TSource, TTarget>(this TSource source)
            where TTarget : class, new()
        {
            return StaticMapper<TSource, TTarget>.Map(source);
        }

        /// <summary> Map from object source to existent object target</summary>
        public static void MapToObject(this object source, object target)
        {
            StaticMapper.Map(source, target);
        }

        /// <summary> Map from object source to new object of TTarget</summary>
        public static TTarget MapObject<TTarget>(this object source)
            where TTarget : new()
        {
            return StaticMapper.Map<TTarget>(source);
        }
    }
}