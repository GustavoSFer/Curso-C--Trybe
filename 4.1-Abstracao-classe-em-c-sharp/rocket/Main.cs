namespace rocket;

public class Program {
  public void Main(String[] args ) {
    var rocket1 = new Rocket();
    var rocket2 = new Rocket();

    rocket1.Name = "Apollo 11";
    rocket2.Name = "Falcom 9";

    Console.WriteLine(rocket1.Name);
  }
}