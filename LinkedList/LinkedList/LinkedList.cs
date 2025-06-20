namespace LinkedList;

internal class LinkedList
{
    public Node Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void InsertFirst(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            newNode.next = Head;
            Head = newNode;
        }
    }

    public void InsertLast(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node iter = Head;
            while (iter.next != null)
            {
                iter = iter.next;
            }
            iter.next = newNode;
        }

    }

    public int DeleteFirst()
    {
        if (Head == null)
        {
            Console.WriteLine("linkedList is Empty !");
            return -1;
        }

        int d = Head.Data;
        Head =Head.next;
        return d;
    }

    public int DeleteLast()
    {
        int d = -1;
        if (Head == null)
        {
            Console.WriteLine("linkedList is Empty !");
            return d;
        }
        if(Head.next == null)
        {
            d = Head.Data;
            Head = null;
            return d;
        }
        Node iter = Head;
        while (iter.next.next != null)
        {
            iter = iter.next;
        }
        d = iter.next.Data;
        iter.next = null;
        return d;
    }



    public void Display()
    {
        Node iter = Head;
        while (iter != null)
        {
            Console.Write($"{iter.Data}  ");
            iter = iter.next;
        }
        Console.WriteLine();
    }
}
