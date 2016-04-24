using System.Collections.Generic;
using Photosphere.Mapping.Extensions;
using Photosphere.Mapping.Tests.TestClasses;
using Xunit;

namespace Photosphere.Mapping.Tests
{
    public class MapFromObjectTests
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
            var bar = new Bar()
            {
                A = string.Empty,
                B = new List<string>(),
                C = 0,
                D = false,
                E = "E"
            };
            bar.MapFromObject(foo);
            Assert.Equal(foo.A, bar.A);
            Assert.Equal(foo.B, bar.B);
            Assert.Equal(foo.C, bar.C);
            Assert.Equal(foo.D, bar.D);
            Assert.Equal("E", bar.E);
        }

        [Fact]
        internal static void MapFromObject_WiderDtoToDto_ValidResult()
        {
            var bar = new
            {
                A = "test",
                B = new List<string> { "a", "b", "c" },
                C = 42,
                D = true,
                E = "E"
            };
            var foo = new Foo()
            {
                A = string.Empty,
                B = new List<string>(),
                C = 0,
                D = false
            };
            foo.MapFromObject(bar);
            Assert.Equal(foo.A, bar.A);
            Assert.Equal(foo.B, bar.B);
            Assert.Equal(foo.C, bar.C);
            Assert.Equal(foo.D, bar.D);
        }
    }
}