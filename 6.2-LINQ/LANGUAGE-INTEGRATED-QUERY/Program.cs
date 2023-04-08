public class Program
{
  public static void Main(string[] args)
  {
    // declarativeLinq();
    lambdaLinq();
  }

  static void declarativeLinq()
  {

    string[] games = { "Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft" };
    var filterGames = from game in games
                      where game.Contains('a')
                      select game;

    foreach (string game in filterGames)
    {
      Console.WriteLine(game);
    }
  }

  static void lambdaLinq()
  {
    string[] games = { "Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft" };

    var filterGames = games.Where(n => n.Contains('a'));

    foreach (string game in filterGames) {
      Console.WriteLine(game);
    }
  }
}