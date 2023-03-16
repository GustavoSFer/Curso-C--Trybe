namespace rocket;
public class Rocket
{
  public string Name { get; set; }
  // INICIANDO O VALOR PELO CONSTRUTOR
  int Fuel { get; set; }
  // OU PODEMOS ATRIBUIR AQUI. ASSIM...
  // int Fuel { get; set; } = 0;

  decimal Price { get; set; }

  // CONSTRUTOR
  public Rocket(string name, decimal price) {
    this.Name = name;
    this.Fuel = 0;
    this.Price = price;
  }
}
