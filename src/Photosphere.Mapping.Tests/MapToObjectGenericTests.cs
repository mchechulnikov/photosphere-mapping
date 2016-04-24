using System.Collections.Generic;
using Photosphere.Mapping.Extensions;
using Photosphere.Mapping.Tests.TestClasses;
using Xunit;

namespace Photosphere.Mapping.Tests
{
    public class MapToObjectGenericTests
    {
        [Fact]
        internal static void MapFromObject_DtoToWiderDto_ValidResult()
        {
            var foo = new
            {
                A = "test",
                B = new List<string> { "a", "b", "c" },
                C = 42,
                D = true
            };
            var bar = foo.MapObject<Bar>();
            Assert.Equal(foo.A, bar.A);
            Assert.Equal(foo.B, bar.B);
            Assert.Equal(foo.C, bar.C);
            Assert.Equal(foo.D, bar.D);
            Assert.Null(bar.E);
        }

        [Fact]
        internal static void MapFromObject_WiderDtoToDto_ValidResult()
        {
            var foo = new
            {
                A = "test",
                B = new List<string> { "a", "b", "c" },
                C = 42,
                D = true,
                E = "E"
            };
            var bar = foo.MapObject<Bar>();
            Assert.Equal(foo.A, bar.A);
            Assert.Equal(foo.B, bar.B);
            Assert.Equal(foo.C, bar.C);
            Assert.Equal(foo.D, bar.D);
            Assert.Equal(foo.E, bar.E);
        }
    }
}