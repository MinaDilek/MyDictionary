using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("mina", 24);
            AdYas.Add("hilal", 23);
            AdYas.Add("nisa", 15);

            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("eleman sayisi: " + eleman);
        }
    }
}
