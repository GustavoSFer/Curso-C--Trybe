public class A
{
  protected string item = "Aprendendo o modificador protected";
}


public class B : A
{
  static void Main()
  {
    var a = new A();
    var b = new B();

    // Não permite a gente fazer isso
    //  a.item = "Acessando o item";

    // Porém, como B deriva de A, podemos acessar essa propriedade em B:
    b.item = "Desta forma temos acesso";
  }
}