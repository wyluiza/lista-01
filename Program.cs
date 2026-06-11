Console.WriteLine("Informe a nota final do aluno: ");
int nota = int.Parse(Console.ReadLine());
if nota >=7
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Em recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

