# Photosphere.Mapping
Simple hight perfomance object mapper based on emitting CIL code.

## Status
[![Windows build Status](https://ci.appveyor.com/api/projects/status/github/sunloving/photosphere-mapping?retina=true&svg=true)](https://ci.appveyor.com/project/sunloving/photosphere-mapping)

## Interface
This tiny library gives next extensions methods
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
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000)](https://github.com/sunloving/photosphere-mapping/blob/master/LICENSE)
