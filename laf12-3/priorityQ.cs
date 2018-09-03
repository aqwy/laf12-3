using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf12_3
{
    class priorityQ
    {
        Heap theHeap;
        public priorityQ(int size)
        {
            theHeap = new Heap(size);
        }
        public void insert(int item)
        {
            theHeap.insert(item);
        }
        public int remover()
        {
            return theHeap.remove().getData();
        }
        public bool isEmpty()
        {
            return theHeap.isEmpty();
        }
        public void display()
        {
            theHeap.displayHeap();
        }
    }
}
