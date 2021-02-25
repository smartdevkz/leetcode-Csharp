using System;
using System.Collections.Generic;

namespace ConsoleApp1.Easy225
{
    public class Solution
    {
        public void Run()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            for (int i = 0; i < queue.Count; i++)
            {
                int a = queue.Dequeue();
                queue.Enqueue(a);
            }

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyStack
    {
        Queue<int> q1;
        Queue<int> q2;
        /** Initialize your data structure here. */
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            if (q1.Count == 0)
                Rearrange(q1, q2, x);
            else
                Rearrange(q2, q1, x);

        }

        private void Rearrange(Queue<int> q1, Queue<int> q2, int x)
        {
            q1.Enqueue(x);
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (q1.Count > 0) return q1.Dequeue();
            if (q2.Count > 0) return q2.Dequeue();
            throw new Exception("Stack is empty");
        }

        /** Get the top element. */
        public int Top()
        {
            if (q1.Count > 0) return q1.Peek();
            if (q2.Count > 0) return q2.Peek();
            throw new Exception("Stack is empty");
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0 && q2.Count == 0;
        }
    }
}