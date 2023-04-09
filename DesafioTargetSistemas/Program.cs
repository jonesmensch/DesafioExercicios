//Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma
//mensagem avisando se o número informado pertence ou não a sequência.

int valorX = 0, valorY = 1;

Console.Write("Informe um número: ");
int numeroInformado = int.Parse(Console.ReadLine());

while (valorY < numeroInformado)
{
    int resultado = valorY;
    valorY += valorX;
    valorX = resultado;
}

if (valorY == numeroInformado || numeroInformado == 0)
{
    Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numeroInformado} não pertence à sequência de Fibonacci.");
}



// Escreva um programa que inverta os caracteres de um string.
Console.WriteLine();

Console.Write("Digite uma palavra à ser invertida: ");
string palavraParaInverter = Console.ReadLine();

char[] chars = palavraParaInverter.ToCharArray();

Array.Reverse(chars);

string stringInvertida = new string(chars);

Console.WriteLine(stringInvertida);
