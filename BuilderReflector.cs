using System;
using System.Linq;
using System.Reflection;

namespace reflection
{
    public class BuilderReflector
    {
        public static object AddBuilderReflector(){
            var typesWithMyAttribute =
            // Note the AsParallel here, this will parallelize everything after.
            from a in AppDomain.CurrentDomain.GetAssemblies().AsParallel()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(typeof(BuilderReflectionAttribute), true)
            where attributes != null && attributes.Length > 0
            select new QueryClass(){ tt = t };

            foreach (QueryClass targetClass in typesWithMyAttribute){
             var fields = targetClass.tt.GetFields( BindingFlags.NonPublic | BindingFlags.Instance);
             foreach (FieldInfo field in fields){
                 Console.WriteLine(field.Name);
             }
             fields = targetClass.tt.GetFields( );
             foreach (FieldInfo field in fields){
                 Console.WriteLine(field.Name);
             }


            }
            return null;

        }

        class QueryClass{
            public Type tt;
        }
    }
}