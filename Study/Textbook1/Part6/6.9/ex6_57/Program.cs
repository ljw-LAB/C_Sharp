using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ex6_57
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("Current Domain Name: " + currentDomain.FriendlyName);
            foreach(Assembly asm in currentDomain.GetAssemblies())
            {
                Console.WriteLine(" " + asm.FullName);
                // foreach(Module module in asm.GetModules())
                // {
                //     Console.WriteLine(" " + module.FullyQualifiedName);
                //     foreach(Type type in module.GetTypes())
                //     {
                //         Console.WriteLine(" " + type.FullName);
                //     }
                // } 
                foreach(Type type in asm.GetTypes())
                {
                    Console.WriteLine("   " + type.FullName);
                    foreach(MemberInfo memberInfo in type.GetMembers())
                    {
                        Console.WriteLine("   " + memberInfo.Name);
                    }
                }
            } 
        }
    }
}
