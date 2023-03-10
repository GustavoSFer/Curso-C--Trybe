namespace Program;
class TestClass
{
  static void Main(string[] args)
  {
    var classe = new TestClass();
    Console.WriteLine(classe.DivideNumbers(10, 0));
  }
  public int DivideNumbers(int numberOne, int numberTwo)
  {
    try {
      return numberOne / numberTwo;
    } catch (DivideByZeroException ex) {
      throw new DivideByZeroException("O numero não pode ser dividido por 0");
    }
  }
}