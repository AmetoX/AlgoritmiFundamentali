using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb.info_510
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cod tel 1
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            { 
                v[i] = int.Parse(data[i]);

            }
            //soratare for in for 
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (prim(v[i]))
                {
                    Console.Write(v[i]+" ");
                }
            }
        }
        public static bool prim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }

            for (int a = 3; a <= n / 2; a = a + 2)
            {
                if (n % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
