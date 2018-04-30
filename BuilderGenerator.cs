using System;
using System.Reflection;

namespace BuilderExtension
{
    public class BuilderGenerator
    {
        public BuilderGenerator(FieldInfo[] privateFields, FieldInfo[] publicFields, ConstructorInfo[] construtors)
        {
            
        }
        public T build<T>(){

            return default(T);
        }
    }
}
