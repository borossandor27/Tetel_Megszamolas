using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetel_Megszamolas
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Bekéri az elemek számát
            Console.WriteLine("Kérem az elemek számát!");
            int N;
            while (!(int.TryParse(Console.ReadLine(),out N) && N>0))
            {
                Console.WriteLine("Nem megfelelő érték! Adjon újat!");
            }
            //-- bekéri az elemeket
            int[] T = new int[N];
            for (int i = 0; i < T.Length; i++)
            {
                Console.Write($"kérem a {i+1} elemet: ");
                int tmp;
                while (!(int.TryParse(Console.ReadLine(), out tmp)))
                {
                    Console.WriteLine($"Nem megfelelő érték! Adjon új {i+1}-k elemet!");
                }
                T[i] = tmp;
            }

            Console.WriteLine($"Az elemek: {String.Join(", ", T)}");
            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }
    }
}
