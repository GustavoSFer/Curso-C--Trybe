namespace triangulo;
public class Class1
{
  public static string IdentifyTriangule(double xSide, double ySide, double zSide) {
    var name = "";

    if(xSide == ySide && xSide == zSide) {
      name = "Triangulo Equilátero";
    } else if((xSide == ySide) || (xSide == zSide) || (ySide ==zSide)){
      name = "Triângulo Isóscele";
    } else {
        name = "Triângulo Escaleno";
    }
    return name;
  }

}
