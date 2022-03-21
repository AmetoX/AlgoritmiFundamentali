using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_492
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
            int nr = 0;
            for(int i = 0;i< n/2; i++)
            {
                if (cmmdc(v[i], v[n - 1 - i]) == 1)
                {
                    nr++;
                }
                
            }
            Console.WriteLine(nr);

        }
        static int cmmdc(int a,int b)
        {
            while (a != b)
            {
                if (a > b) a -= b;
                if (b > a) b -= a;
            }
            return a;
        }
    }
}
