using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_14_04
{
    public static class Engine
    {
        public static Complex summ(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            return t;
        }

            
}
}
