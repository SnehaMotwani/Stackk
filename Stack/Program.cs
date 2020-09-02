using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
        }
        public class Stack
        {
            public void Push(object obj)
            {

            }
            public object Pop()
            {
                return 1;
            }
            public void Clear()
            {

            }
        }
    }
}
