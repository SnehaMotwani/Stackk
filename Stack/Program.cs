using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            //stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            Console.WriteLine();

            stack.Clear();
        }
        public class Stack
        {
            int currentIndex = -1;
            object obj;
            List<object> stackList = new List<Object>();

            public void Push(object aObj)
            {
                obj = aObj;
                if(obj != null)
                {
                    currentIndex++;
                    stackList.Add(obj);
                }
                else
                {
                    Console.WriteLine("Object is null");
                }
            }
            public object Pop()
            {
                if (stackList.Count == 0)
                {
                    Console.WriteLine("List is Empty");
                }
                else
                {
                    stackList.RemoveAt(stackList.Count - 1);
                    currentIndex--;
                }
                return stackList[stackList.Count - 1];
                
            }
            public void Clear()
            {
                stackList.Clear();
            }
        }
    }
}
