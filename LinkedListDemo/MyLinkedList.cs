using System;

namespace LinkedListDemo
{
  public class MyLinkedList
  {
    private Node Head { get; }

    private int Total { get; set; }

    public MyLinkedList(Node headNode)
    {
      Head = headNode;
    }

    public void WriteResult()
    {
      Console.WriteLine(Total);
    }

    /// <summary>
    /// Verilen Node'dan başlayarak sona kadar nodelardaki değerlerin toplamlarını rekürsif şekilde hesaplar.
    /// </summary>
    public void SumRecursive(Node node)
    {
      if (node == null)
      {
        return;
      }

      Total += node.Data;
      SumRecursive(node.Next);
    }

    /// <summary>
    /// Head node'dan başlayarak değerler toplamını iteratif şekilde hesaplar.
    /// </summary>
    public int SumIterative()
    {
      int total = 0;

      Node currentNode = Head;
      while (currentNode != null)
      {
        total += currentNode.Data;
        currentNode = currentNode.Next;
      }

      return total;
    }
  }
}