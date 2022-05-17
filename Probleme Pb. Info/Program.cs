using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Probleme_Pb.Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            p36();
        }
        static void p658()
        {
            string[] nr = Console.ReadLine().Split(' ');
            int n = int.Parse(nr[0]), m = int.Parse(nr[1]);
            int[,] matrix = new int[n, m];
            string[] buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int suma = 0;
                for (int j = 0; j < m; j++)
                {
                    suma += matrix[i, j];
                }
                Console.Write(suma + " ");
            }

        }
        static void p487()
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                s = s + v[i];
            }
            int medie = s / n;
            //Console.WriteLine(medie);
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] > medie)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
        static void p488()
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
                Console.Write(v[i] + " ");

            }
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(v[i] + " ");
                }
            }
        }
        static void p492()
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            int nr = 0;
            for (int i = 0; i < n / 2; i++)
            {
                if (cmmdc(v[i], v[n - 1 - i]) == 1)
                {
                    nr++;
                }

            }
            Console.WriteLine(nr);

        }
        static int cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a -= b;
                if (b > a) b -= a;
            }
            return a;
        }

        static void p510()
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
                    Console.Write(v[i] + " ");
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

        static void p511()
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
            for (int i = k; i < k - 1; i++)
            {
                for (int j = k + 1; j < n; j++)
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
                Console.Write(v[i] + " ");
        }
        static void p533()
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            int imin = 0, imax = 0;
            int min = v[0], max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    imax = i + 1;
                }
                if (v[i] < min)
                {
                    min = v[i];
                    imin = i + 1;
                }
            }
            Console.WriteLine(imin + " " + imax);
        }
        static void p1749()
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            int[,] m = new int[n, n];

            int Sn = 0;
            int Sv = 0;
            int Se = 0;
            int Ss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    m[i, j] = int.Parse(buffer[j]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1)
                        Sn += m[i, j];
                    if (i < j && i + j > n - 1)
                        Se += m[i, j];
                    if (i > j && i + j > n - 1)
                        Ss += m[i, j];
                    if (i > j && i + j < n - 1)
                        Sv += m[i, j];
                }
            }
            switch (k)
            {
                case 1: Console.Write(Sn); break;
                case 2: Console.Write(Se); break;
                case 3: Console.Write(Ss); break;
                case 4: Console.Write(Sv); break;
            }
            Console.ReadKey();
        }

        static int[,] tn;
        static bool[,] b;
        static int t, nr, nrmax = 0;
        static void p36()
        {
            //nu-i de pe pbinfo(de pe siteul lui laslo)
            //parcurgere in adancime
            tn = readM(@"../../p36_matrice.txt");
            b = new bool[tn.GetLength(0), tn.GetLength(1)];
            viewM(tn);
            for (int i = 0; i < tn.GetLength(0); i++)
            {
                for (int j = 0; j < tn.GetLength(1); j++)
                {
                    nr = 0;
                    t = tn[i, j];
                    PA(i, j);
                    if (nr > nrmax)
                    {
                        nrmax = nr;
                    }
                }
            }
            Console.WriteLine(nrmax +" ");
        }
        static void PA(int i, int j)
        {
            if(i>-0&&j>=0&&i<tn.GetLength(0)&&j<tn.GetLength(1)&&!b[i,j]&& tn[i, j] == t)
            {
                nr++;
                b[i, j] = true;
                PA(i-1, j);
                PA(i, j - 1);
                PA(i+1, j);
                PA(i, j + 1);
            }
        }
        static int[,] readM(string filename)
        {
            int[,] toR;
            string buffer;
            List<string> T = new List<string>();
            TextReader load = new StreamReader(filename);
            while((buffer=load.ReadLine()) != null)
            {
                T.Add(buffer);
            }
            load.Close();
            int n = T.Count;
            int m = T[0].Split(' ').Length;
            toR = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] ld = T[i].Split(' ');
                for(int j = 0; j < m; j++)
                {
                    toR[i, j] = int.Parse(ld[j]);
                }
            }
            return toR;
        }
        static void viewM(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
