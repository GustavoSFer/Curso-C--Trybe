class Program
{
  static void Main(string[] args)
  {
    Pet[] pets = {
      new Pet { Name="rex", Age=8 },
      new Pet { Name="Tóto", Age=3 },
      new Pet { Name="Slinky", Age=2 },
      new Pet { Name="Belinha", Age=1 },
    };

    var sumAge = pets.Sum(pet => pet.Age);
    var maxAge = pets.Max(pet => pet.Age);
    Console.WriteLine("O Pet mais velho tem " + maxAge + " anos");

    var averageAge = pets.Average(pet => pet.Age);
    Console.WriteLine("A idade média dos cachorro é: " + averageAge);
  }
}