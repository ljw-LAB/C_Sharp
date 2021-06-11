using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex11_17
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessFileAsync();
            Console.ReadLine();
        }
        
        private static async void ProcessFileAsync()
        {
            FileStream fs = null;
            
            try
            {
                fs =new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                byte[] contents = new byte[1024];
                await fs.ReadAsync(contents, 0, contents.Length);
                Console.WriteLine("ReadAsync Called!");
            }
            catch(Exception e)
            {
                await LogAsync(e);
            }
            finally
            {
                await CloseAsync(fs);
            }
        }

        static Task LogAsync(Exception e)
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("Log Async Called!");
                });
        }

        static Task CloseAsync(FileStream fs)
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("Clsoe Async Called!");

                    if(fs != null)
                    {
                        fs.Close();
                    }
                });
        }

    }
}

