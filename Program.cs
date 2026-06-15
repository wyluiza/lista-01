Console.WriteLine("Informe a idade do passageiro: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor normal da passagem: ");
double valorPassagem = double.Parse(Console.ReadLine());
if (idade <= 5)
{
    Console.WriteLine("Valor a pagar: R$0,00.");
}
else if (idade >= 60) 
{
    double valorDesconto = valorPassagem * 0.5;
    double valorFinal = valorPassagem - valorDesconto;
    Console.WriteLine($"Valor a pagar: R${valorFinal:F2}.");
}
else
{
    Console.WriteLine($"Valor a pagar: R${valorPassagem:F2}.");
}