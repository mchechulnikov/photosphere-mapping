using System;
using System.Collections.Generic;
using System.Reflection;

namespace Photosphere.Mapping.Extensions
{
    internal static class TypeExtensions
    {
        public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
    }
}