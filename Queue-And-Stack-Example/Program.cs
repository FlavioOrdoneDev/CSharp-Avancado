using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_And_Stack_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("First in line");
            myQueue.Enqueue("Second in line");
            myQueue.Enqueue("Third in line");
            myQueue.Enqueue("Last in line");

            string takeALook = myQueue.Peek();
            string getFirst = myQueue.Dequeue();
            string getNext = myQueue.Dequeue();
            string getThird = myQueue.Peek();
            int howMany = myQueue.Count;
            myQueue.Clear();
      
            Console.WriteLine("Peek() returned: " + takeALook);
            Console.WriteLine("The first Dequeue() returned: " + getFirst);
            Console.WriteLine("The second Dequeue() returned: " + getNext);
            Console.WriteLine("The third Peek() returned: " + getThird);
            Console.WriteLine("Count before Clear() was " + howMany);
            Console.WriteLine("Count after Clear() is now " + myQueue.Count);

            Console.WriteLine();

            /* Stack*/

            Stack<string> myStack = new Stack<string>();

            myStack.Push("First in line");
            myStack.Push("Second in line");
            myStack.Push("Third in line");
            myStack.Push("Last in line");

            string takeALooks = myStack.Peek();
            string getFirsts = myStack.Pop();
            string getNexts = myStack.Pop();
            string getThirds = myStack.Peek();
            int howManys = myStack.Count;
            myQueue.Clear();

            Console.WriteLine("Peek() returned: " + takeALooks);
            Console.WriteLine("The first Pop() returned: " + getFirsts);
            Console.WriteLine("The second Pop() returned: " + getNexts);
            Console.WriteLine("The third Peek() returned: " + getThirds);
            Console.WriteLine("Count before Clear() was " + howManys);
            Console.WriteLine("Count after Clear() is now " + myStack.Count);

            myStack.Push("First in line");
            myStack.Push("Second in line");

            Console.WriteLine();
            Console.WriteLine();

            Queue<string> myQueue2 = new Queue<string>(myStack);
            List<string> myList = new List<string>(myQueue2);
            Stack<string> anotherStack = new Stack<string>(myList);

            Console.WriteLine("myQueue2 has " + myQueue2.Count + " items");
            Console.WriteLine("myList has " + myList.Count + " items");
            Console.WriteLine("anotherStack has " + anotherStack.Count + " items");

            Console.ReadKey();
        }
    }
}
