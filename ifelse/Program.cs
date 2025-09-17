int idade;
Console.Write("Digite sua idade");
int.TryParse(Console.ReadLine(), out idade);

char sexo;
Console.WriteLine("Digite seu sexo (M/F): ");
char.TryParse(Console.ReadLine().ToUpper(), out sexo);
//TryParse tenta converter o valo, se não conseguir,
//atribuir o valor padrão do tipo (0 para int, '|0' para char, etc)

//Estrutura condivional if-else
Console.WriteLine("\n Verificação com if-else: ");

//Exemplo 1: Verificação de maioridade
//OU || -pelo menos uma condição deve ser verdadeira
//&& - todas as condições devem ser verdadeiras
if (idade >= 18 || sexo == 'F')
{
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Olá, você pode entrar na festa! ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desculpe, você nao pode entar na festa.");
}
bool temIngresso = true;
//Exemplo 2: 
if (temIngresso && idade >= 18 || sexo == 'F' && idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, você pode etrar na festa! ");
}else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Desculpe, você nao pode entrar na festa. ");
}