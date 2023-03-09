namespace Program;
class TestClass
{
  static void Main(string[] args)
  {
    var classe = new TestClass();
    Console.WriteLine(classe.DivideNumbers(12, 4));
  }
  public int DivideNumbers(int numberOne, int numberTwo)
  {
    return numberOne / numberTwo;
  }
}