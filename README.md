# Photosphere.Mapping
Simple hight perfomance object mapper based on emitting CIL code.

## Status
<a href="https://ci.appveyor.com/project/sunloving/photosphere-mapping" target="_blank">
  ![Windows build Status](https://ci.appveyor.com/api/projects/status/github/sunloving/photosphere-mapping?retina=true&svg=true)
</a>
<a href="https://www.nuget.org/packages/Photosphere.Mapping/" target="_blank">
  ![NuGet](https://img.shields.io/nuget/v/Photosphere.Mapping.svg?maxAge=2592000)
</a>

## Interface
This tiny library gives next extension methods
``` C#
void Map<TSource, TTarget>(this TTarget target, TSource source);    // Map from existent object to another one
void Map(this object target, object source);                        // Map from existent object to another one
TTarget Map<TSource, TTarget>(this TSource source);                 // Map from existent object to new object
```

## Examples
``` C#
foo.Map(bar);                     // Map object bar to existent object foo
var buz = foo.Map<Foo, Buz>();    // Map object foo to new object buz
```

## License
<a href="https://github.com/sunloving/photosphere-mapping/blob/master/LICENSE" target="_blank">
  ![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)
</a>
