using CustomLinkedList;

//LinkedList linkedList = new LinkedList();

//linkedList.AddFirst(55);
//linkedList.RemoveFirst();

//Node node = new Node(1);
//node.Next=new Node(2);
//node.Next.Next=new Node(3);
//node.Next.Next.Next=new Node(4);

//Node node1 = new Node(1);
//Node node2 = new Node(2);
//Node node3 = new Node(3);
//Node node4 = new Node(4);

//node1.Next = node2;
//node2.Next = node3;
//node3.Next = node4;

//Node node = node3;

LinkedList linkedList = new LinkedList();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddFirst(0);
linkedList.AddFirst(-1);

linkedList.ForEach(n =>
{
    Console.WriteLine(n);
});

int[] array=linkedList.ToArray();
Console.WriteLine(string.Join(",", array));
//linkedList.RemoveFirst();
//linkedList.RemoveLast();

//Node node = linkedList.Head;

//while (node != null)
//{
//    Console.WriteLine(node.Value);
//    node = node.Next;
//}