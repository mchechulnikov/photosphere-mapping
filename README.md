# Photosphere.Mapping
Simple hight perfomance object mapper based on emitting CIL code.

## Status
[![Windows build Status](https://ci.appveyor.com/api/projects/status/github/sunloving/photosphere-mapping?retina=true&svg=true)](https://ci.appveyor.com/project/sunloving/photosphere-mapping)
[![NuGet](https://img.shields.io/nuget/v/Photosphere.Mapping.svg?maxAge=2592000)](https://www.nuget.org/packages/Photosphere.Mapping/)

## Interface
This tiny library gives next extension methods
``` C#
void MapFrom<TSource, TTarget>(this TTarget target, TSource source);    // Map from existent object to another one
void MapFromObject(this object target, object source);                  // Map from existent object to another one
TTarget Map<TSource, TTarget>(this TSource source);                     // Map from existent object to new object
```

## Examples
Map object `bar` to existent object `foo`
``` C#
foo.MapFrom(bar);
```
Map object `foo` to new object `buz`
``` C#
var buz = foo.Map<Foo, Buz>();
```
You can perform mapping from anonymous type
``` C#
var foo = new { A = "a", B = 1 };
bar.MapFromObject(foo);
```

## Perfomance?
:soon:

## License
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)](https://github.com/sunloving/photosphere-mapping/blob/master/LICENSE)
