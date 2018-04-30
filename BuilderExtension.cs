using System;
using System.Reflection;

namespace BuilderExtension
{
    public static class Builder
    {
        public static BuilderGenerator BuilderOf(Type type)
        {
            return new BuilderGenerator(
                type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance),
                type.GetFields(),
                type.GetConstructors()
            );
        }
    }
}