// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite seu nome.");

string? nameInput = Console.ReadLine();

Console.WriteLine("Olá " + nameInput);

string name = "Rodrigo";
int number1 = 1;
float numberFloat = 1.45f;
double numberDouble = 3.5;
decimal numberDecimal = 5.3m;
char isActive = 'y';
bool isActiveBool = false;

// Estrutura de controle de fluxo

Console.WriteLine("Digite aqui o valor do produto:");

var valorProduto = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor que você possui:");

var valorQuePossui = int.Parse(Console.ReadLine());

var diferencaValor = valorQuePossui - valorProduto ;

if (diferencaValor < 0)
{
    Console.WriteLine("Você não pode comprar esse produto:");
} else if(diferencaValor == 0)
{
    Console.WriteLine("Você pode pagar por esse produto, porém não sobrará troco.");
}else
{
    Console.WriteLine("Você pode comprar esse produto e sobrará " + diferencaValor);
}

// switch case

switch (diferencaValor)
{
    case 0:
        Console.WriteLine("Você pode pagar por esse produto, porém não sobrará troco.");
        break;
    case < 0:
        Console.WriteLine("Você não pode comprar esse produto:");
        break;
    default:
        Console.WriteLine("Você pode comprar esse produto e sobrará " + diferencaValor);
        break;
}