using System.Collections.Generic;
using Photosphere.Mapping.Extensions;
using Photosphere.Mapping.Tests.TestClasses;
using Xunit;

namespace Photosphere.Mapping.Tests
{
    public class MapFromGenericTests
    {
        [Fact]
        internal static void MapFrom_DtoToWiderDto_ValidResult()
        {
            var foo = new Foo()
            {
                A = "test",
                B = new List<string> { "a", "b", "c" },
                C = 42,
                D = true
            };
            var bar = new Bar();
            bar.MapFrom(foo);
            Assert.Equal(foo.A, bar.A);
            Assert.Equal(foo.B, bar.B);
            Assert.Equal(foo.C, bar.C);
            Assert.Equal(foo.D, bar.D);
        }

        [Fact]
        internal static void MapFrom_WiderDtoToDto_ValidResult()
        {
            var bar = new Bar()
            {
                A = "test",
                B = new List<string> { "a", "b", "c" },
                C = 42,
                D = true
            };
            var foo = new Foo();
            foo.MapFrom(bar);
            Assert.Equal(bar.A, foo.A);
            Assert.Equal(bar.B, foo.B);
            Assert.Equal(bar.C, foo.C);
            Assert.Equal(bar.D, foo.D);
            Assert.Null(bar.E);
        }
    }
}