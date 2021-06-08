using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 =  new List<int>(new int[] {1 , 2, 3, 4, 5,});
            List<int> numbers2 =  new List<int>(new int[] {6 , 7, 8, 9, 10,});

            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            dict["first"] = numbers1;
            dict["second"] = numbers2;

            foreach(KeyValuePair<string, List<int>> elem in dict)
            {
                Console.WriteLine(elem.Key + ": " + Output(elem.Value));
            }
        }

        private static string Output(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int elem in list)
            {
                sb.AppendFormat("{0}, ", elem);
            }

            return sb.ToString().TrimEnd(',');
        }
    }
}
