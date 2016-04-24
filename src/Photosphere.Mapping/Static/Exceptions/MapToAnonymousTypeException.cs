using System;

namespace Photosphere.Mapping.Static.Exceptions
{
    public class MapToAnonymousTypeException : Exception
    {
        public override string Message => "Anonymous types doesn't allowed to be mapped to bacause it's immutable by design.";
    }
}