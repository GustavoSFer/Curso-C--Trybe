public class GenericList<T>
{
  private class Node
  {
    public T Value;
    public Node? Next;

    public Node(T t)
    {
      Value = t;
      Next = null;
    }
  }

  private Node Head;

  public GenericList()
  {
    Head = null;
  }

  public void Add(T input)
  {
    if (Head == null)
    {
      Head = new Node(input);
      Console.WriteLine("Nó Head criado!");
    }
    else
    {
      //Encontra onde inserir o próximo nó na lista.
      Node lastNode = Head;
      while (lastNode.Next != null) lastNode = lastNode.Next;

      lastNode.Next = new Node(input);
    }
  }
}


public class Program
{
  public static void Main(String[] args)
  {
    GenericList<int> list1 = new GenericList<int>();
    list1.Add(1);
    list1.Add(12);
    list1.Add(4);
  }
}