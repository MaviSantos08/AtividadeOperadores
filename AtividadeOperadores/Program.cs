//1.Soma de 3 notas e mostre a média deles.

int soma = 2 + 2 + 2;
double divisao = 3 / 2.0;

Console.WriteLine($"2 + 2 + 2 = {soma}");

int num1, num2, num3, resultado;
Console.WriteLine("Insira a primeira nota");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insira a terceira nota");
num3 = Convert.ToInt16(Console.ReadLine());

resultado = num1 + num2 +num3;
Console.WriteLine($"A soma das notas é {resultado}");

double media = resultado / 3.0;
Console.WriteLine($"A média das notas é {media}");

//Temperatura: Leia uma temperatura em Celsius e converta para Fahrenheit usando a fórmula:
//F = (C * 9 / 5) + 32
Console.WriteLine("Digite a temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"A temperatura de {celsius}°C em Fahrenheit é {fahrenheit}°F");

//Área de Quadrado: Leia o lado de um quadrado e calcule a área (lado * lado). Mostre o resultado.
// Área do Quadrado
Console.WriteLine("Digite o lado do quadrado: ");
double lado = Convert.ToDouble(Console.ReadLine());

double area = lado * lado;

Console.WriteLine($"A área do quadrado de lado {lado} é {area}");

//Área de Triângulo: Leia a base e a altura de um triângulo e calcule a área: (base * altura) / 2
Console.WriteLine("Digite a base do triângulo: ");
double basetri = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do triângulo: ");
double altura = Convert.ToDouble(Console.ReadLine());

double areat = (basetri * altura) / 2;

Console.WriteLine($"A área do triângulo é {areat}");

//const double PI = 3.14159;

const double PI = 3.14159;

Console.WriteLine("Digite o raio do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

double areac = PI * raio * raio;

Console.WriteLine($"A área do círculo de raio {raio} é {areac}");

//Perímetro do Retângulo Peça a largura e a altura de um retângulo e calcule o perímetro: Perímetro = 2 * (largura + altura)

Console.WriteLine("Digite a largura do retângulo: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do retângulo: ");
double alturar = Convert.ToDouble(Console.ReadLine());

double perimetro = 2 * largura + alturar;

Console.WriteLine($"O perímetro  do retângulo é {perimetro}");
