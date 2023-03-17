class Program {
  public void Main(string[] args) {
    var movie = new Movie("Matrix", "Ficção Cientifica");
    var movie2 = new Movie("Senhor dos Aneis", "Fantasia");

    Console.WriteLine(movie.Title);
    Console.WriteLine(movie2.Title);
  }
}