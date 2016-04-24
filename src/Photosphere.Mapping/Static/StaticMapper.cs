using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Photosphere.Mapping.Extensions;

namespace Photosphere.Mapping.Static
{
    internal static class StaticMapper<TSource, TTarget>
        where TTarget : new()
    {
        private static readonly Action<TSource, TTarget> ProduceMapping;

        static StaticMapper()
        {
            ProduceMapping = MapFunctionGenerator.Generate<TSource, TTarget>();
        }

        public static TTarget Map(TSource source)
        {
            var target = new TTarget();
            ProduceMapping(source, target);
            return target;
        }

        public static void Map(TSource source, TTarget target)
        {
            ProduceMapping(source, target);
        }
    }

    internal static class StaticMapper
    {
        private static readonly RegisteredMapActions MapActions = new RegisteredMapActions();

        public static void Map(object source, object target)
        {
            if (target.GetType().IsAnonymous())
            {
                var message = $"`{nameof(target)}` is anonymous type. Anonymous types doesn't allowed to be mapped to bacause it's immutable by design";
                throw new ArgumentException(message);
            }
            var mapAction = GetMapAction(source.GetType(), target.GetType());
            mapAction(source, target);
        }

        private static Action<object, object> GetMapAction(Type sourceType, Type targetType)
        {
            var typesPair = new KeyValuePair<Type, Type>(sourceType, targetType);
            Action<object, object> action;
            if (MapActions.TryGetValue(typesPair, out action))
            {
                return action;
            }
            action = MapFunctionGenerator.Generate(sourceType, targetType);
            MapActions.AddOrRewrite(typesPair, action);
            return action;
        }

        private sealed class RegisteredMapActions : ConcurrentDictionary<KeyValuePair<Type, Type>, Action<object, object>> { }
    }
}