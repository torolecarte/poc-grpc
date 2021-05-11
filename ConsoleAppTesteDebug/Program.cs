using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppTesteDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, string>();

            Console.WriteLine("Generating...");
            Parallel.For(0L, 9L, i =>
            {
                Console.WriteLine(NewMethod());
            });

            Console.WriteLine(dict.Count);

            //Console.WriteLine("Checking...");
            //Parallel.ForEach(dict, item =>
            //{
            //    var result = dict.Where(x => x == item);

            //    if (result.Count() > 1)
            //        Console.WriteLine("Match");
            //});
            Console.WriteLine("Finished.");
        }

        private static string NewMethod()
        {
            var codigo = Guid.NewGuid().ToString();
            codigo = codigo.Replace("-", "");
            codigo = codigo.Substring(0, 24);
            return codigo.ToUpper();
        }
    }
}
