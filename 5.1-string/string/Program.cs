public class Program
{
  public static void Main(String[] args)
  {
    var concatenandoString = new Concat("Olá ", "Mundo!!");
    Console.WriteLine(concatenandoString.Concatenando());

  }

  // Contatenação de string
  public class Concat {
    string TextOne;
    string TextTwo;
    public Concat(string textOne, string textTwo) {
      TextOne = textOne;
      TextTwo = textTwo;
    }
    public string Concatenando() {
      string result = string.Concat(TextOne, TextTwo);
      return result;
    }
  }
}