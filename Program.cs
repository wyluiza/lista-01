using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o saldo inicial:");
        float saldo = float.Parse(Console.ReadLine());

        int operacao;

        do
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Entrada de dinheiro");
            Console.WriteLine("2 - Saída de dinheiro");
            Console.WriteLine("3 - Encerrar");

            operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.WriteLine("Informe o valor da movimentação:");
                float valor = float.Parse(Console.ReadLine());

                saldo = saldo + valor;

                Console.WriteLine("Entrada registrada. Saldo atual: R$ " + saldo);
            }
            else if (operacao == 2)
            {
                Console.WriteLine("Informe o valor da movimentação:");
                float valor = float.Parse(Console.ReadLine());

                if (valor <= saldo)
                {
                    saldo = saldo - valor;
                    Console.WriteLine("Saída registrada. Saldo atual: R$ " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }

        } while (operacao != 3);

        Console.WriteLine("Saldo final: R$ " + saldo);
    }
}