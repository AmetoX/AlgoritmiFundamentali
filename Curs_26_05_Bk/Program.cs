namespace Curs_26_05_Bk
{
    /// <summary>
    /// Algoritmul lui Lee
    /// </summary>
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            //Algoritmul lui Lee--------
            //matrix = ReadMatrixFile();
            //ViewMatrix(matrix);
            //Queue A = new Queue();
            //A.Push(new TriData(1, 2, 1));
            //A.Push(new TriData(3, 4, 5));
            //A.Push(new TriData(1, 6, 2));
            //A.Push(new TriData(0, 2, 4));
            //A.Push(new TriData(7, 2, 3));
            //Console.WriteLine(A.view());
            //Lee();

            //BK test---------
            int n = 4;
            int[] s = new int[n];
            bool[] b = new bool[n];
            //BK1(0, n, s);
            //BK2(0, n, s);
            BK3(0, n, s, b);
            Console.WriteLine("Done");

        }
        public static void Lee()
        {
            Queue A = new Queue();
            A.Push(new TriData(0, 0, 1));
            matrix[0, 0] = 1;
            while (!A.IsEmpty())
            {//BFS
                TriData t = A.Pop();
                if (t.l - 1 >= 0) //vecin nord
                {
                    if (matrix[t.l - 1, t.c] == 0)
                    {
                        A.Push(new TriData(t.l - 1, t.c, t.v + 1));
                        matrix[t.l - 1, t.c] = t.v + 1;
                    }
                }
                if (t.c + 1 < matrix.GetLength(1)) //vecin est
                {
                    if (matrix[t.l, t.c + 1] == 0)
                    {
                        A.Push(new TriData(t.l, t.c + 1, t.v + 1));
                        matrix[t.l, t.c + 1] = t.v + 1;
                    }
                }
                if (t.l + 1 < matrix.GetLength(0))//vecin sud
                {
                    if (matrix[t.l + 1, t.c] == 0)
                    {
                        A.Push(new TriData(t.l + 1, t.c, t.v + 1));
                        matrix[t.l + 1, t.c] = t.v + 1;
                    }
                }
                if (t.c - 1 >= 0) //vecin vest
                {
                    if (matrix[t.l, t.c - 1] == 0)
                    {
                        A.Push(new TriData(t.l, t.c - 1, t.v + 1));
                        matrix[t.l, t.c - 1] = t.v + 1;
                    }
                }
                Console.WriteLine(A.view());
                ViewMatrix(matrix);
            }
        }
        private static int[,] ReadMatrixFile()
        {
            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            string[] t = load.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = load.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(buffer[j]);
                }
            }
            return a;
        }
        private static void ViewMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //----------------------------------------------------------
        //BackTracking
        //----------------------------------------------------------

        /// <summary>
        /// Se dau 5 zaruri. Se cere sa se afiseze toate combinatile care au suma 15.
        /// </summary>
        public static void BK1(int k, int n, int[] s)
        {//produs cartezian
            if (k >= n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += s[i];
                }
                if (sum == 15)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    s[k] = i;
                    BK1(k + 1, n, s);
                }
            }
        }

        public static void BK2(int k, int n, int[] s)
        {//permutarile unei multimi (n^n)
            if (k >= n)
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (s[i] == s[j])
                        {
                            ok = false;
                            break;
                        }
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    s[k] = i + 1;
                    BK2(k + 1, n, s);
                }
            }
        }

        public static void BK3(int k, int n, int[] s, bool[] b)
        {//permutari (n!)
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK3(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
        //urmeaza aranjamente si combinari
    }
}