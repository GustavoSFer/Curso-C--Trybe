public class Program
{
  public static void Main(string[] args)
  {
    List<string> nomes = new List<string>() { "Carro", "Casa", "Roupas", "Avião" };

    // Imprimindo a nossa lista
    foreach (var item in nomes)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("**************************");
    // Adicionando novo item a nossa lista e imprimindo
    nomes.Add("Celular");

    foreach (var item in nomes)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("**************************");
    // Removendo o item "Casa" da nossa lista
    nomes.Remove("Casa");

    foreach (var item in nomes)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("**************************");
    // Removendo o item pelo index da nossa lista
    nomes.RemoveAt(2);

    foreach (var item in nomes)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("**************************");
    // procurando elemento na nossa lista e retorna o index
    int index = nomes.IndexOf("Roupas");
    Console.WriteLine(index);


    Console.WriteLine("**************************");
    // Realizando a ordenação dos elementos
    // Primeiro vamos adicionar alguns elementos novamente
    nomes.Add("Pessoas");
    nomes.Add("Frutas");
    nomes.Add("Xadrez");
    nomes.Add("Lojas");

    nomes.Sort();
    foreach (var item in nomes)
    {
      Console.WriteLine(item);
    }
  }
}