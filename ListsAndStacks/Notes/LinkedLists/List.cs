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
}