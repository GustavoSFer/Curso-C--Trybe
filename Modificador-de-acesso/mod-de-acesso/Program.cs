public class Point
{
  public int x;
  public int y;

  public void PrintPoint(){
    Console.WriteLine($"(X - Y) - ({x} - {y})");
  }
}


public class Program
{
  public static void Main(String[] args)
  {
    var ponto = new Point();
    ponto.x = 2;
    ponto.y = 10;

    ponto.PrintPoint();
  }
}