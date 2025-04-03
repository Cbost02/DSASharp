using System;
// Bencock cafe

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

    public Boolean hasNode(T data)
    {
        Node<T> node = new Node<T>(data);
        if(head == null)
        {
            return false;
        }
        else if(string.Equals(head.GetData().ToString(), node.GetData().ToString())) // checks the head of the list
        {
            return true;
        }
        else
        {
            Node<T> current = head;

            // Checks everything else
            while(current != null)
            {
                if(string.Equals(current.GetData().ToString(), node.GetData().ToString)) // checks the current node
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }
            return false;
        }
    }

     // Returns the node at the specified index
    public Node<T> GetAtIndex(int index)
    {
        if(head == null)
        {
            Console.Write("This list is empty!");
            Console.Write("Returning null object...");
            return null;
        }
        else
        {
            Node<T> current = head;

            AAA:
            if(index == 0)
            {
                return current;
            }
            else
            {
                index--;
                current = current.Next;
                goto AAA;
            }
        }
    }

    // Returns the length of the list
    public int GetLength()
    {
        return length;
    }

    // Returns the head of the list
    public Node<T> GetHead()
    {
        return head;
    }
}