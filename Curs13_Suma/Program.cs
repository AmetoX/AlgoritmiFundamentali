namespace Curs13_Suma
{
    /*Se da o suma(S) si un vector(V) care reprezinta valoarea unor bancnote. 
Se cere sa se afiseze suma S ca si o combinatie liniara de elemente din V.
Conditie: Suma coeficientilor sa fie minima.
S = 2917 
V = {100, 500, 100, 20, 5, 1}
2917 x 1*/
    class Program
    {
        static int s = 2917;
        static int[] v = new int[] { 1000, 500, 100, 20, 5, 1 };
        static void Main(string[] args)
        {
            int[] r = new int[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                r[i] = s / v[i];
                s = s % v[i];
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(r[i] + "*" + v[i] + "+");
            }
        }
    }
}