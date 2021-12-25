using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            LinkedList list = new LinkedList();
            list.add(56);
            list.add(30);
            list.add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
        }
    }
}
