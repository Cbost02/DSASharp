using System;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;


class DoubleList<T>
{
    private Node<T> Head;
    private int Length;

    public DoubleList()
    {
        Head = null;
        Length = 0;
    }

    // Adds a node to the end of the list
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

    // Prints the list
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

    // Returns the node that contains the data
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

    // Checks to see if the list contains a node with the specified data
    public Boolean hasNode(T data)
    {
        Node<T> node = new Node<T>(data);
        if(Head == null)
        {
            return false;
        }
        else if(string.Equals(Head.GetData().ToString(), node.GetData().ToString())) // checks the head of the list
        {
            return true;
        }
        else
        {
            Node<T> current = Head;

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
        if(Head == null)
        {
            Console.Write("This list is empty!");
            Console.Write("Returning null object...");
            return null;
        }
        else
        {
            Node<T> current = Head;

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
        return Length;
    }

    // Returns the head of the list
    public Node<T> GetHead()
    {
        return Head;
    }
}