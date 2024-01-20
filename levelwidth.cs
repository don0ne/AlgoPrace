using System;
using System.Collections.Generic;

public class Node
{
    public int Data { get; set; }
    public List<Node> Children { get; set; }

    public Node(int data)
    {
        Data = data;
        Children = new List<Node>();
    }

    public void Add(int data)
    {
        Children.Add(new Node(data));
    }
}

public class TreeAnalysis
{
    public static List<int> LevelWidth(Node root)
    {
        if (root == null) return new List<int>();

        var widths = new List<int>();
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        queue.Enqueue(null); 
        
        int currentWidth = 0;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                widths.Add(currentWidth);
                currentWidth = 0;
                if (queue.Count > 0) queue.Enqueue(null);
            }
            else
            {
                currentWidth++;
                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
        return widths;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var root = new Node(0);
        root.Add(1);
        root.Add(2);
        root.Add(3);
        root.Children[0].Add(4);
        root.Children[2].Add(5);

        var widths = TreeAnalysis.LevelWidth(root);
        foreach (var width in widths)
        {
            Console.WriteLine(width + "\n");
        }
    }
}
