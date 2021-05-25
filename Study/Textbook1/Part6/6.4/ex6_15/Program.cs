using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("key1", "add");
            ht.Add("key2", "remove");
            ht.Add("key3", "update");
            ht.Add("key4", "serach");

            Console.WriteLine(ht["key4"]);

            ht.Remove("key3");
            ht["key2"] = "delete";
            Console.WriteLine();

            foreach(object key in ht.Keys)
            {
                Console.WriteLine("{0} ==> {1}", key, ht[key]);
            }
        }
    }
}
