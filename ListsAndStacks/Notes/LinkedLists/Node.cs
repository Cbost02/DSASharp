class Node<T>
{
    public T Data;
    public Node<T> Next;

    public Node(T Data)
    {
        this.Data = Data;
        Next = null;

    }

    public T GetData()
    {
        return Data;
    }
}