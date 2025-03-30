class Node<T>
{
    public T Data; // Node data
    public Node<T> Next; // Pointer to next node
    public Node<T> Before; // The Node in front of the current node

    public Node(T Data)
    {
        this.Data = Data;
        Next = null;
        Before = null;

    }

    public T GetData()
    {
        return Data;
    }

    public Node<T> GetNext()
    {
        return Next;
    }

    public Node<T> GetBefore()
    {
        return Before;
    }
}