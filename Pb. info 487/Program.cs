using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_487
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                s=s+v[i];
            }
            int medie = s / n;
            //Console.WriteLine(medie);
            int nr = 0;
            for(int i = 0; i < n; i++)
            {
                if (v[i] > medie)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
    }
}
