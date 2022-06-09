using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs13_ProblemaSpectacolelor_Greedy
{
    public class spect
    {
        public int ti, tf;

        public spect(int ti, int tf)
        {
            this.ti = ti;
            this.tf = tf;
        }
        public string view()
        {
            return ti + " " + tf;
        }
        public spect(string s)
        {
            ti = int.Parse(s.Split(' ')[0]);
            tf = int.Parse(s.Split(' ')[1]);
        }
    }
}
