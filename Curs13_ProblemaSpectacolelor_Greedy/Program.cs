using System.IO;
namespace Curs13_ProblemaSpectacolelor_Greedy
{
    /*Administratorul unei săli de spectacole doreşte să organizeze, într-un
interval de timp oarecare, un număr cât mai mare de spectacole. Ştiind că
există N artişti interesaţi să susţină un spectacol şi că fiecare artist i poate să
suţină spectacolul doar în intervalul de timp [ai, bi], determinaţi numărul
maxim de spectacole care pot fi organizate astfel încât intervalele de
desfăşurare a oricăror două spectacole să nu se suprapună.
Datele de intrare se citesc din fişierul spectacole.in: pe prima linie
numărul natural N, iar pe următoarele N linii se află perechi de numere [ai,
bi] având semnificaţia din enunţ. În fişierul spectacole.out veţi afişa
numărul maxim de spectacole care pot fi programate respectând condiţiile
problemei.*/
    class Program
    {
        static List<spect> load()
        {
            TextReader l = new StreamReader(@"..\..\TextFile1.txt");
            List<spect> toR = new List<spect>();
            string buffer;
            while ((buffer = l.ReadLine()) != null)
            {
                spect A = new spect(buffer);
                toR.Add(A);
            }
            return toR;
        }

        static void view()
        {
            List<spect> a = load();
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i].view());
            a.Sort(delegate (spect c, spect b) { return c.tf.CompareTo(b.tf); }); //don't use this 
            Console.WriteLine();
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i].view());
            Console.WriteLine();
            Console.WriteLine(a[0].view());
            int t = a[0].tf;
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i].ti >= t)
                {
                    Console.WriteLine(a[i].view());
                    t = a[i].tf;
                }
            }
        }

        static void Main(string[] args)
        {
            view();
        }
    }
}