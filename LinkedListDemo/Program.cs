using System;

namespace LinkedListDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Node headNode = new Node(5);
      Node leafNode1 = new Node(3);
      Node leafNode2 = new Node(2);
      leafNode1.Next = leafNode2;
      headNode.Next = leafNode1;

      var linkedList = new MyLinkedList(headNode);

      linkedList.SumRecursive(headNode);
      linkedList.WriteResult();

      int sumIterative = linkedList.SumIterative();
      Console.WriteLine(sumIterative);
    }
  }
}
