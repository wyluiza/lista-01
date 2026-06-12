Console.WriteLine("Informe a quantidade de tarefas concluídas: ");
int tarefas = int.Parse(Console.ReadLine());
if (tarefas >= 50)
{
    Console.WriteLine("Meta atingida!");
}
else
{
    Console.WriteLine("Meta não atingida.");
    tarefas = 50 - tarefas;
    Console.WriteLine("Você precisa concluir mais {0} tarefas para atingir a meta.", tarefas);
}