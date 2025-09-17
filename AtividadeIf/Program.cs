//Atividade 1
// Entrada em balada
Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite seu sexo (M/F): ");
string sexo = Console.ReadLine().ToUpper(); // transforma em maiúsculo para facilitar

Console.WriteLine("Você possui ingresso? (true/false): ");
bool ingresso = Convert.ToBoolean(Console.ReadLine());

if (ingresso && idade >= 18)
{
    Console.WriteLine("Pode entrar na balada!");
}
else if (sexo == "F" && idade >= 18)
{
    Console.WriteLine("Pode entrar na balada (mulher maior de 18, mesmo sem ingresso)!");
}
else
{
    Console.WriteLine("Não pode entrar na balada.");
}

//// Desconto no cinema
Console.WriteLine("Digite sua idade: ");
int iidade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você é estudante? (true/false): ");
bool estudante = Convert.ToBoolean(Console.ReadLine());

if (iidade < 12)
{
    Console.WriteLine("Você paga meia entrada (menor de 12 anos).");
}
else if (estudante || iidade > 60)
{
    Console.WriteLine("Você paga meia entrada (estudante ou maior de 60 anos).");
}
else
{
    Console.WriteLine("Você paga entrada inteira.");
}



//Acesso ao jogo online

{
    static void Main()
    {
        // Solicita a idade
        Console.Write("Digite sua idade: ");
        string idadeInput = Console.ReadLine();
        int idade;
        if (!int.TryParse(idadeInput, out idade))
        {
            Console.WriteLine("Idade inválida!");
            return;
        }

        // Solicita se possui assinatura
        Console.Write("Você possui assinatura? (true/false): ");
        string assinaturaInput = Console.ReadLine();
        bool possuiAssinatura;
        if (!bool.TryParse(assinaturaInput, out possuiAssinatura))
        {
            Console.WriteLine("Resposta inválida! Digite true ou false.");
            return;
        }

        // Verifica as condições de acesso
        if ((possuiAssinatura && idade > 16) || (!possuiAssinatura && idade > 18))
        {
            Console.WriteLine("Você pode jogar!");
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

// Pede as 3 notas
Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

// Calcula a média
double media = (nota1 + nota2 + nota3) / 3;

// Verifica a situação do aluno
if (media >= 7)
{
    Console.WriteLine("Aluno aprovado");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine("Aluno em recuperação");
}
else
{
    Console.WriteLine("Aluno reprovado");
}

Console.WriteLine("Média final: " + media.ToString("F2"));
Console.ReadKey(); 
       