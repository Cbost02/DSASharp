using System;


class DoubleList<T>
{
    private Node<T> Head;
    private int Length;

    public DoubleList()
    {
        Head = null;
        Length = 0;
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        if(Head == null)
        {
            Head = node;
        }
        else
        {
            Node<T> current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            node.Before = current;
            current.Next = node;
        }
    }

    public void Print()
    {
        if(Head == null)
        {
            Console.WriteLine("This list is empty!");
        }
        else
        {
            Node<T> current = Head;

            while(current != null)
            {
                Console.Write(current.GetData().ToString() + " <-> " );
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    public Node<T> Get(T Data)
    {
        Node<T> node = new Node<T>(Data);
        if(Head == null)
        {
            return null;
        }
        else
        {
            Node<T> current = Head;

            while(!string.Equals(current.GetData().ToString(), node.GetData().ToString))
            {
                // If the next node is null, return an empty type
                if(current.Next == null)
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