using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf12_3
{
    class Program
    {
        public static string getString()
        {
            string str = Console.ReadLine();
            return str;
        }
        public static char getChar()
        {
            string str = getString();
            return str[0];
        }
        public static int getInt()
        {
            string str = getString();
            return Int32.Parse(str);
        }
        static void Main(string[] args)
        {
            int val, val2;
            bool success;
            Heap theHeap = new Heap(31);

            theHeap.insert(70);//hjhjh
            theHeap.insert(40);
            theHeap.insert(50);
            theHeap.insert(20);
            theHeap.insert(60);
            theHeap.insert(100);
            theHeap.insert(80);
            theHeap.insert(30);
            theHeap.insert(10);
            theHeap.insert(90);
            theHeap.insert(110);

            while (true)
            {
                Console.WriteLine("enter first letter of: show,insert,delete,toss,heap-restore,reset-all or change ");
                char choise = getChar();
                switch (choise)
                {
                    case 'i':
                        Console.WriteLine("enter new value to insert: ");
                        val = getInt();
                        success = theHeap.insert(val);
                        if (!success)
                            Console.WriteLine("cant insert,heap is full!");
                        break;
                    case 's':
                        theHeap.displayHeap();
                        break;
                    case 'd':
                        if (!theHeap.isEmpty())
                            theHeap.remove();
                        else
                            Console.WriteLine("cant remove! Heap is empty");
                        break;
                    case 'c':
                        Console.WriteLine("enter current index: ");
                        val = getInt();
                        Console.WriteLine("Enter new index: ");
                        val2 = getInt();
                        success = theHeap.change(val, val2);
                        if (!success)
                            Console.WriteLine("cant change,invalid insex!");
                        break;
                    case 't':
                        Console.WriteLine("enter value to toss: ");
                        val = getInt();
                        success = theHeap.toss(val);
                        if (!success)
                            Console.WriteLine("cant toss,heap is full!");
                        break;
                    case 'h':
                        theHeap.restoreHeap();
                        break;
                    case 'r':
                        while (theHeap.getCurrentSize() != 0)
                            theHeap.remove();
                        break;
                    default:
                        Console.WriteLine("invalid entry!");
                        break;
                }
            }
        }
    }
}
