using System.Collections.Concurrent;

namespace Photosphere.Mapping.Extensions
{
    internal static class ConcurrentDictionaryExtensions
    {
        public static void AddOrRewrite<TKey, TValue>(
            this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            dictionary.AddOrUpdate(key, value, (k, v) => v);
        }
    }
}