using System;

namespace DataStructureStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedlistStack linkedlistStack = new LinkedlistStack();
            linkedlistStack.push(70);
            linkedlistStack.push(30);
            linkedlistStack.push(56);
            linkedlistStack.Display();
            linkedlistStack.peek();
            linkedlistStack.pop();
            linkedlistStack.IsEmpty();
        }
    }
}
