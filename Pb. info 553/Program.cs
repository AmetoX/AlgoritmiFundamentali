using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_553
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
            int imin = 0,imax = 0;
            int min = v[0], max = v[0];
            for(int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    imax = i+1;
                }
                if(v[i] < min)
                {
                    min=v[i];
                    imin = i+1;
                }
            }
            Console.WriteLine(imin+ " " + imax);
        }
    }
}
