namespace Program;
class Program
{
  static void Main(string[] args)
  {
    var classe = new Program();
    Console.WriteLine(classe.DivideNumbers(10, 0));
  }
  public int DivideNumbers(int numberOne, int numberTwo)
  {
    try {
      if (numberTwo == 0) throw new DivideByZeroException("O numero não pode ser dividido por 0");
      return numberOne / numberTwo;
    } catch (DivideByZeroException ex) {
      Console.WriteLine(ex.Message);
      throw;
    }
  }
}