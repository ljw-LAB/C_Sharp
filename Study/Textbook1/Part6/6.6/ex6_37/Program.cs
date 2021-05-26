using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_37
{
    class FileState
    {
        public byte[] Buffer;
        public FileStream File;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileState state = new FileState();
            state.Buffer = new byte[fs.Length];
            state.File = fs;

            fs.BeginRead(state.Buffer, 0, state.Buffer.Length, readCompleted, state);
            Console.ReadLine();
            fs.Close();
            
        }

        static void readCompleted(IAsyncResult ar)
        {
            FileState state = ar.AsyncState as FileState;
            state.File.EndRead(ar);

            string txt = Encoding.UTF8.GetString(state.Buffer);
            Console.WriteLine(txt);
        }

    }
}
