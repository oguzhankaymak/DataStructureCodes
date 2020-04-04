using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            string number = "";
            for (int i = 0; i < 100000; i++)
            {
                number += i.ToString();
            }

            watch.Stop();
            
            Console.WriteLine("Çalışma Süresi: {0}", watch.Elapsed.Milliseconds);
            Console.ReadKey();

            // -------------------------------------------------------------------//
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //StringBuilder stringBuilder = new StringBuilder();
            

            //for (int i = 0; i < 100000; i++)
            //{
            //    stringBuilder.Append(i.ToString());
            //}

            //watch.Stop();

            //Console.WriteLine("Çalışma Süresi: {0}", watch.Elapsed.Milliseconds);
            //Console.ReadKey();

        }
    }
}
