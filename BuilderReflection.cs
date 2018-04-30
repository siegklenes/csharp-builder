using System;
using System.Reflection;

namespace reflection
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false,  
                   Inherited = false)]
    public class BuilderReflectionAttribute : Attribute {
    }
}