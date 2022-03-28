using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Pb.Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            p658();
        }
        static void p658()
        {
            string[] nr = Console.ReadLine().Split(' ');
            int n = int.Parse(nr[0]), m = int.Parse(nr[1]);
            int[,] matrix = new int[n,m];
            string[] buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                }
            }
            for(int i = 0; i < n; i++)
            {
                int suma = 0;
                for(int j =0; j < m; j++)
                {
                    suma+=matrix[i, j];
                }
                Console.Write(suma+" ");
            }

        }
    }
}
