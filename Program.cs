Console.WriteLine("Informe o número inicial da contagem regressiva:");
int numeroInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Contagem regressiva:");
for (int i = numeroInicial; i >= 0; i--)
{
    Console.WriteLine(i);
}