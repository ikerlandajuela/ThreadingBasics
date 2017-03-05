using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ThreadingBasics
{
    class Program
    {
        static void PrintNumbers()
        {            
            Console.WriteLine("Starting...");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(PrintNumbers);
            t.Start();
            PrintNumbers();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
