using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_19_05
{
    public class Stack
    {
        int[] val;
        int n;
        public Stack()
        {
            val = new int[0];
        }

        public void Push(int v) //add an element to stack
        {
            int[] T = new int[val.Length + 1];
            for (int i = 0; i < val.Length; i++)
                T[i + 1] = val[i];
            T[0] = v;
            val = T;
        }

        public int Pop()
        {
            int toR = val[0];
            int[] T = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
            {
                T[i] = val[i + 1];
            }
            val = T;
            return toR;
        }
        public void view()
        {
            for (int i = 0; i < val.Length; i++)
                Console.Write(val[i] + " ");
        }
    }
}
