public class Program {
  public static void Main(string[] args) {
    List<string> nomes = new List<string>(){ "Carro", "Casa", "Roupas", "Avião" };

    // Imprimindo a nossa lista
    foreach (var item in nomes) {
      Console.WriteLine(item);
    }
  }
}