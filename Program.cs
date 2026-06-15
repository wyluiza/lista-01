Console.WriteLine("Informe a quantidade de clientes atendidos: ");
int clientes = int.Parse(Console.ReadLine());

int tempoTotal = 0;

for (int i = 1; i <= clientes; i++)
{
    Console.WriteLine("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine());

    tempoTotal = tempoTotal + tempo;
}

float tempoMedio = (float)tempoTotal / clientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");