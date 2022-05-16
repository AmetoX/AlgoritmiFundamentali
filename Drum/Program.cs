namespace Drum_12_05
{
    public static class Program
    {
        static int n, m;
        static bool ok = false;
        static int[,] a;
        static bool[,] b;
        static Random rnd = new Random();
        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            b = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(2);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PA(int i, int j, int n)
        {
            if (i >= 0 && j >= 0 && i < n && j < m &&!b[i,j])
            {

            }
        }
    }
}
