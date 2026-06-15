Console.WriteLine("Informe a quantidade inicial em estoque:");
int estoque = int.Parse(Console.ReadLine());

int operacao;

do
{
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Entrada de produtos");
    Console.WriteLine("2 - Saída de produtos");
    Console.WriteLine("3 - Consultar estoque");
    Console.WriteLine("4 - Encerrar");

    operacao = int.Parse(Console.ReadLine());

    if (operacao == 1)
    {
        Console.WriteLine("Informe a quantidade movimentada:");
        int quantidade = int.Parse(Console.ReadLine());

        estoque = estoque + quantidade;

        Console.WriteLine("Entrada registrada. Estoque atual: " + estoque);
    }
    else if (operacao == 2)
    {
        Console.WriteLine("Informe a quantidade movimentada:");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= estoque)
        {
            estoque = estoque - quantidade;

            Console.WriteLine("Saída registrada. Estoque atual: " + estoque);
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }
    else if (operacao == 3)
    {
        Console.WriteLine("Estoque atual: " + estoque);
    }

} while (operacao != 4);

Console.WriteLine("Estoque final: " + estoque);