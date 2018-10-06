using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = Assembly.LoadFrom("ReflectionLibrary.dll");

            Type[] types = myAssembly.GetTypes();
            Console.WriteLine("Number of Types : " + types.Length);

            foreach (Type t in types)
            {
                Console.WriteLine("***********************Name of Type : " + t.Name);
                Console.WriteLine("Assembly Qualified Name : " + t.AssemblyQualifiedName);
                Console.WriteLine("Base Type : " + t.BaseType);
                Console.WriteLine("Contain Generic Parameters : " + t.ContainsGenericParameters);
                Console.WriteLine("Full Name : " + t.FullName);
                Console.WriteLine("GUID : " + t.GUID);
                Console.WriteLine("Is Abstract : " + t.IsAbstract);
                Console.WriteLine("Is Ansi Class : " + t.IsAnsiClass);
                Console.WriteLine("Is Auto Class : " + t.IsAutoClass);
                Console.WriteLine("Is Class : " + t.IsClass);
                Console.WriteLine("Is Enum : " + t.IsEnum);
                Console.WriteLine("Is Generic Type : " + t.IsGenericType);
                Console.WriteLine("Is Interface : " + t.IsInterface);
                Console.WriteLine("Is Not Public : " + t.IsNotPublic);
                Console.WriteLine("Is Public : " + t.IsPublic);
                Console.WriteLine("Is Sealed : " + t.IsSealed);
                Console.WriteLine("Is Serializable : " + t.IsSerializable);
                Console.WriteLine("Is Value Type : " + t.IsValueType);
                Console.WriteLine("Namespace : " + t.Namespace);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
