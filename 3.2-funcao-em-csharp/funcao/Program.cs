using System;

namespace AgeNamespace
{
  public class AgeNamespace{
    public void Main()
    {
      var age = CalculaAgeByYear(1988);
    }

    public int CalculaAgeByYear(int yearOfBirth)
    {
      return DateTime.Now.Year - yearOfBirth;
    }
  }
}