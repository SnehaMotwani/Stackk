﻿using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Output:
                Current Stack: [ 1  2  3 ]
                Object Removed: 3
                Current Stack: [ 1  2 ]
                Object Removed: 2
                Current Stack: [ 1 ]
                Object Removed: 1
                Current Stack: []
             */
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
           //stack.Push("");

            stack.DisplayStack();

            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();
            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();
            Console.WriteLine("Object Removed: " + stack.Pop());
            stack.DisplayStack();

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
            public void DisplayStack()
            {
                //obj = stackList[currentIndex];
                Console.Write("Current Stack: [");

                for (int i = 0; i < stackList.Count; i++)
                {
                    Console.Write($" {stackList[i]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
