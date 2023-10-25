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