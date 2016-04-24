using Photosphere.Mapping.Static;

namespace Photosphere.Mapping.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary> Map from source to existent object target</summary>
        public static void MapFrom<TSource, TTarget>(this TTarget target, TSource source)
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
        public static void MapFromObject(this object target, object source)
        {
            StaticMapper.Map(source, target);
        }

        /// <summary> Map from object source to new object of TTarget</summary>
        public static TTarget MapFromObject<TTarget>(this object source)
            where TTarget : new()
        {
            return StaticMapper.Map<TTarget>(source);
        }
    }
}