public enum PaymentType
{
  credit,
  debit,
  InCash = debit,
  InParts = credit,
}

public static class Program
{
  public static void Main()
  {
    Console.WriteLine("String Crédito " + PaymentType.credit + " Valor Crédito: " + (int)PaymentType.credit );
    Console.WriteLine("String Debito " + PaymentType.debit + " Valor Debito: " + (int)PaymentType.debit );
    Console.WriteLine("String InCash " + PaymentType.InCash + " Valor InCash: " + (int)PaymentType.InCash );
    Console.WriteLine("String InParts " + PaymentType.InParts + " Valor InParts: " + (int)PaymentType.InParts );
  }
}