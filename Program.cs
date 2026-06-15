Console.WriteLine("Informe a idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade <= 11)
{
    Console.WriteLine("criança");
}
else if (idade > 11 && idade <= 17)
{
    Console.WriteLine("adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("adulto");
}
else if (idade >= 60)
{
    Console.WriteLine("idoso");
}
else
{
    Console.WriteLine("");
}