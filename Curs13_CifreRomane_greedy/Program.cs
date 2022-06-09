namespace Curs13_CifreRomane_greedy
{
    class Program
    {
        static int roman(char R)
        {
            switch (R)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string s = "MMCMXLVII";
            int t = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (roman(s[i]) >= roman(s[i + 1]))
                    t += roman(s[i]);
                else
                    t -= roman(s[i]);
            }
            t += roman(s[s.Length - 1]);
            Console.Write(t);
        }
    }
}