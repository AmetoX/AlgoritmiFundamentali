using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_19_05
{
    public class Queue
    {
        triData[] val;
        int n;

        public Queue()
        {
            val = new triData[0];
        }

        public void Push(triData v) //add an element to queue
        {
            triData[] T = new triData[val.Length + 1];
            for (int i = 0; i < val.Length; i++)
                T[i + 1] = val[i];
            T[0] = v;
            val = T;
        }

        public triData Pop()
        {
            triData toR = val[val.Length - 1];
            triData[] T = new triData[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
                T[i] = val[i];
            val = T;
            return toR;
        }

        public void view()
        {
            for (int i = 0; i < val.Length; i++)
                val[i].view();
        }
    }
}
