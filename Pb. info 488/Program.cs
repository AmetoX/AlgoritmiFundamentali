using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_488
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            for (int i = 1; i < n; i += 2)
            {
                Console.Write(v[i]+" ");

            }
            Console.WriteLine();
            for(int i = n-1; i >= 0; i--)
            {
                if (i % 2 == 0 )
                {
                    Console.Write(v[i]+" ");
                }
            }

        }
    }
}
