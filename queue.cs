using System;
using System.Collections.Generic;

class Queue
{
    private Queue<int> data;

    public Queue()
    {
        data = new Queue<int>();
    }

   
    public void Add(int element)
    {
        data.Enqueue(element);
    }


    public int Remove()
    {
        if (data.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1; 
        }

        return data.Dequeue();
    }
}

class Program
{
    static void Main()
    {
   
        Queue q = new Queue();
        q.Add(1);
       
        Console.WriteLine($"q.remove() // returns {q.Remove()}");
    }
}
