using System;

class List<T>
{
    private Node<T> head;
    private int length;

    public List()
    {
        head = null;
        length = 0;
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        
        if(head == null)
        {
            head = node;
            return;
        }
        else
        {
            Node<T> current = head;

            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }
    }

    public void Print()
    {
        if(head == null)
        {
            Console.Write("This list is empty!");
        }
        else
        {
            Node<T> current = head;

            while(current != null)
            {
                Console.Write(current.GetData().ToString() + " -> ");
                current = current.Next;
            }
        }
        Console.Write("null");
    }

    public Node<T> Get(T Data)
    {
        Node<T> node = new Node<T>(Data);
        if(head == null)
        {
            return null;
        }
        else if(string.Equals(head.GetData().ToString(), node.GetData().ToString()))
        {
            return head;
        }
        else
        {
            Node<T> current = head;

            // Run this loop only when the current & given node don't equal each other!
            while(!string.Equals(current.GetData().ToString(), node.GetData().ToString()))
            {
                // If the next node is null, return an empty type
                if(current == null)
                {
                    Console.Write("There's no node that contains that piece of data!\n");
                    Console.WriteLine("Returninng null object...");
                    return null;
                }
                else
                {
                    // Proceed to the next node
                    current = current.Next;
                }
            }
            return current;
        }
    }
}