using System;
using BuilderExtension;

namespace reflection
{
   public class Program
    {
        static void Main(string[] args)
        {
            Builder.BuilderOf(typeof(DomainClass));
        }
    }
}
