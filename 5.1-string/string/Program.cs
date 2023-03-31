public class Program
{
  public static void Main(String[] args)
  {
    var concatenandoString = new Concat("Olá ", "Mundo!!");
    Console.WriteLine(concatenandoString.Concatenando());


    // Separando string
    string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com;gustavp@gmail.com";

    string[] arrayEmaisl = emails.Split(";");

    Console.WriteLine(arrayEmaisl[0]);
    Console.WriteLine(arrayEmaisl.Length);

    string text = "Procurando o index na string";
    int index = text.IndexOf('u');
    Console.WriteLine(index);
    int index2 = text.IndexOf('s');
    Console.WriteLine(index2);
    int index3 = text.IndexOf('o', 5);
    Console.WriteLine(index3);
  }

  // Contatenação de string
  public class Concat
  {
    string TextOne;
    string TextTwo;
    public Concat(string textOne, string textTwo)
    {
      TextOne = textOne;
      TextTwo = textTwo;
    }
    public string Concatenando()
    {
      string result = string.Concat(TextOne, TextTwo);
      return result;
    }
  }
}