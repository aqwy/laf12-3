using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf12_3
{
    class Heap
    {
        private Node[] heapArray;
        private int arraySize;
        private int currentSize;
        public Heap(int size)
        {
            arraySize = size;
            currentSize = 0;
            heapArray = new Node[arraySize];
        }
        public bool isEmpty()
        {
            return (currentSize == 0);
        }
        public bool insert(int key)
        {
            if (currentSize == arraySize)
                return false;
            Node newNode = new Node(key);
            heapArray[currentSize] = newNode;
            trickleUp(currentSize++);
            return true;
        }
        public void trickleUp(int index)
        {
            int parent = (index - 1) / 2;
            Node bottom = heapArray[index];
            while (index > 0 && heapArray[parent].getData() > bottom.getData())
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public void trickleDown(int index)
        {
            int largerChild = 0;
            Node top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && heapArray[leftChild].getData() < heapArray[rightChild].getData())
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.getData() >= heapArray[largerChild].getData())
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public Node remove()
        {
            Node root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            trickleDown(0);
            return root;
        }
        public bool change(int index, int newValue)
        {
            if (index < 0 || index >= currentSize)
                return false;
            int oldValue = heapArray[index].getData();
            heapArray[index].setData(newValue);
            if (oldValue < newValue)
                trickleDown(index);
            else
                trickleUp(index);
            return true;
        }
        public void displayHeap()
        {
            Console.Write("heapArray: ");
            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray[i] != null)
                    Console.Write(heapArray[i].getData() + " ");
                else
                    Console.Write("--");
            }
            Console.WriteLine();

            int blanks = 32;
            int j = 0;
            int colums = 0;
            int itemsPerRow = 1;
            string dots = ".....................................";
            Console.WriteLine(dots + dots);
            while (currentSize > 0)
            {
                if (colums == 0)
                    for (int k = 0; k < blanks; k++)
                    {
                        Console.Write(' ');
                    }
                Console.Write(heapArray[j].getData());
                if (++j == currentSize)
                    break;
                if (++colums == itemsPerRow)
                {
                    blanks /= 2;
                    itemsPerRow *= 2;
                    colums = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < blanks * 2 - 2; k++)
                    {
                        Console.Write(' ');
                    }
            }
            Console.WriteLine("\n" + dots + dots);
        }
        public bool toss(int key)
        {
            if (currentSize == arraySize)
                return false;
            Node newNode = new Node(key);
            heapArray[currentSize++] = newNode;
            return true;
        }
        public void restoreHeap()
        {
            for (int i = currentSize - 1; i > 0; i--)
            {
                trickleUp(i);
            }
        }
    }
}
