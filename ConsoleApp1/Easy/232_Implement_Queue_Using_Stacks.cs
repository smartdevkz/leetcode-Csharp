using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.Easy232
{
    public class Solution
    {

    }

    public class MyQueue
    {
        Stack<int> stack = null;
        Stack<int> temp = null;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack = new Stack<int>();
            temp = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (stack.Count == 0) stack.Push(x);
            else
            {
                while(stack.Count>0){
                    temp.Push(stack.Pop());
                }
                temp.Push(x);
                while(temp.Count>0){
                    stack.Push(temp.Pop());
                }
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return stack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return stack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}