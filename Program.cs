Console.WriteLine("Informe a idade do visitante: ");
int idade = int.Parse(Console.ReadLine());
if (idade >= 16)
{
    Console.WriteLine("Entrada permitida");
}
else
{
    Console.WriteLine("Entrada permitida somente acompanhado de um responsável.");
}
