//part 1

string LinkedListToString(LinkedList<string> ll, int place)
{
    if (ll == null || ll.Count == 0)
    {
        return "";
    }

    if (place >= ll.Count)
    {
        return ""; 
    }


    LinkedListNode<string> node = ll.First;
    for (int i = 0; i < place; i++)
    {
        node = node.Next;
    }

    Console.WriteLine(node.Value);

    return LinkedListToString(ll, place+1);
}

LinkedList<string> list = new LinkedList<string>();
list.AddLast("Apple");
list.AddLast("Banana");
list.AddLast("Cherry");
list.AddLast("Date");

LinkedListToString(list, 0);

//part 2

class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node Head { get; set; }

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public bool Search(int target)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Data == target)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }
}

//part 3

class Node3
{
    public int Data { get; set; }
    public Node3 Next { get; set; }

    public Node3(int data)
    {
        Data = data;
        Next = null;
    }
}

class CircularlyLinkedList
{
    Node3 Head { get; set; }

    public void Insert(int data)
    {
        Node3 newNode = new Node3(data);
        if (Head == null)
        {
            Head = newNode;
            Head.Next = newNode;
        }
        else
        {
            newNode.Next = Head;
            Node3 current = Head;
            while (current.Next != Head)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public int Size()
    {
        if (Head == null)
        {
            return 0;
        }

        return RecursiveSize(Head, 1);
    }

    private int RecursiveSize(Node current, int count)
    {
        if (current.Next == Head)
        {
            return count;
        }
        return RecursiveSize(current.Next, count + 1);
    }
}

//part 4

public void RecursiveShellSort(int[] arr)
{
    RecursiveSort(arr, arr.Length);
}

static void RecursiveSort(int[] arr, int n)
{
    if (n <= 1)
        return;

    int h = n / 2;

    for (int i = 0; i < n - h; i++)
    {
        if (arr[i] > arr[i + h])
        {
            Swap(arr, i, i + h);
        }
    }

    RecursiveSort(arr, h);
}

static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}