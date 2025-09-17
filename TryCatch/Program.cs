// Exemplo 1 - TryCatch 
// O bloco  Try tenta fazer algo 
// O bloco Catch captura a exceção e permite tratar o erro
try
{
    Console.WriteLine("Digite o numerador: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;

    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Erro: Divisão por zero não é permitida.");
}
catch(FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos.");
}
Console.WriteLine