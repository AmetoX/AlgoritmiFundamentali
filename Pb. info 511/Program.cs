using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_511
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cod tel 2
            string[] nr = Console.ReadLine().Split(' ');
            int n = int.Parse(nr[0]), k = int.Parse(nr[1]);
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            int aux;
            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            for(int i = k; i < k - 1; i++)
            {
                for(int j = k + 1; j < n; j++)
                {
                    if (v[i] < v[j])
                    {
                        aux = v[j];
                        v[j] = v[i];
                        v[i] = aux;
                    }
                }
               
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ") ;
        }
    }
}
