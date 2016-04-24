# Photosphere.Mapping
Simple hight perfomance object mapper based on emitting CIL code.

## Status
[![Windows build Status](https://ci.appveyor.com/api/projects/status/github/sunloving/photosphere-mapping?retina=true&svg=true)](https://ci.appveyor.com/project/sunloving/photosphere-mapping)
[![NuGet](https://img.shields.io/nuget/v/Photosphere.Mapping.svg?maxAge=2592000)](https://www.nuget.org/packages/Photosphere.Mapping/)

## Interface
This tiny library gives next extension methods
``` C#
void MapTo<TSource, TTarget>(this TTarget target, TSource source);    // Map from existent object to another one
void MapToObject(this object target, object source);                  // Map from existent object to another one
TTarget Map<TSource, TTarget>(this TSource source);                   // Map from existent object to new object
TTarget MapObject<TTarget>(this object source);                       // Map from existent object to new object
```

## Examples
Map object `source` to existent object `target`
``` C#
source.MapTo(target);
```
Map object `source` of type `Foo` to new object `target` of type `Bar`
``` C#
var target = source.Map<Foo, Bar>();
```
You can perform mapping from anonymous type
``` C#
var source = new { A = "a", B = 1 };
source.MapToObject(target);
```
or
``` C#
var source = new { A = "a", B = 1 };
var target = source.MapObject<Bar>();
```
but not vice versa, because anonymous types are immutable by design.

## Perfomance?
:soon:

## License
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)](https://github.com/sunloving/photosphere-mapping/blob/master/LICENSE)
