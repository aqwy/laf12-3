using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf12_3
{
    class Node
    {
        private int iData;
        public Node(int ii)
        {
            iData = ii;
        }
        public int getData()
        {
            return iData;
        }
        public void setData(int ii)
        {
            iData = ii;
        }
    }
}
