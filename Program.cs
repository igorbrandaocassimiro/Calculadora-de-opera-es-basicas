Console.WriteLine("***** Calculadora *****\n");

Console.WriteLine("Digite o primeiro número");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1-Adição");
Console.WriteLine("2-Subtração");
Console.WriteLine("3-Multiplicação");
Console.WriteLine("4-Divisão\n");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Resultado: "+(numero1 + numero2));
        break;
    case 2:
        Console.WriteLine("Resultado: "+(numero1 - numero2));
        break;
    case 3:
        Console.WriteLine("Resultado: "+(numero1 * numero2));
        break;
    case 4:
        Console.WriteLine("Resultado: "+(numero1 / numero2));
        break;


    default:
        Console.WriteLine("Opção inválida");
        break;
}