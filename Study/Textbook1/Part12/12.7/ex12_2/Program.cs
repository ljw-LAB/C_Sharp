using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

// NuGet 패키지에서 ValueTuple을 설치
// NuGet 패키지에서 Threading.Tasks.Extensions

namespace ex12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task<(string, int tid)> result = FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");
            //int tid = Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine($"MainThreadID: {tid}, AsytThreadID: {result.Result.tid}");

            //Task<(string, int tid)> result =
            //    FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");

            //int tid = Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");

            {
                ValueTask<(string, int tid)> result = FileReadAsync2(@"C:\windows\system32\drivers\etc\HOSTS");

                int tid = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
            }

            {
                ValueTask<(string, int tid)> result = FileReadAsync2(@"C:\windows\system32\drivers\etc\HOSTS");

                int tid = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
            }

        }

        //private static async Task<(string, int)> FileReadAsync(string filePath)
        //{
        //    string fileText = await ReadAllTextAsync(filePath);
        //    return (fileText, Thread.CurrentThread.ManagedThreadId);
        //}

        static string _fileContents = string.Empty;
        private static async Task<(string, int)> FileReadAsync(string filePath)
        {
            if(string.IsNullOrEmpty(_fileContents) == false)
            {
                return (_fileContents, Thread.CurrentThread.ManagedThreadId);
            }

            _fileContents = await ReadAllTextAsync(filePath);
            return (_fileContents, Thread.CurrentThread.ManagedThreadId);
        }

        private static async ValueTask<(string, int)> FileReadAsync2(string filePath)
        {
            if (string.IsNullOrEmpty(_fileContents) == false)
            {
                return (_fileContents, Thread.CurrentThread.ManagedThreadId);
            }

            _fileContents = await ReadAllTextAsync(filePath);
            return (_fileContents, Thread.CurrentThread.ManagedThreadId);
        }

        static Task<string> ReadAllTextAsync(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                return File.ReadAllText(filePath);
            });
        }
    }
}
