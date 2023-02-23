// ENTRADA DE DADOS
Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
Console.WriteLine("Informe o nome do comodo: ");
string comodo = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste comodo: ");
decimal largura = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe em metro o comprimento deste comodo: ");
decimal comprimento = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potencia em watts da lâmpada que será utilizada: ");
int potencia = int.Parse(Console.ReadLine());

// PROCESSAMENTO
decimal metroQuadrado = largura * comprimento;
decimal cocienteX = potencia / 18M;
decimal totalDeLampadas = metroQuadrado / cocienteX;

// SAIDA DE DADOS
Console.WriteLine("Para iluminar o comodo" + comodo + " com " + metroQuadrado.ToString("N2") + " metros quadrados " + "Será necessario a instalação de " + totalDeLampadas.ToString("N2") + " lampada(s)");