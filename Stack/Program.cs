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
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

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
                    //Console.WriteLine("Index before pushing : " + currentIndex);
                    currentIndex++;
                    stackList.Add(obj);
                    //Console.WriteLine("Index after pushing : " + currentIndex);
                }
                else
                {
                    Console.WriteLine("Object is null");
                }
            }
            public object Pop()
            {
                obj = stackList[currentIndex];
                if (stackList.Count == 0)
                {
                    Console.WriteLine("List is Empty");
                }
                else
                {
                    //Console.WriteLine("Value of object: " + obj);
                    //Console.WriteLine("Index before poping : " + currentIndex);
                    stackList.Remove(obj);
                    currentIndex--;
                    //Console.WriteLine("Index after poping : " + currentIndex);
                }
                return obj;
                
            }
            public void Clear()
            {
                stackList.Clear();
            }
        }
    }
}
