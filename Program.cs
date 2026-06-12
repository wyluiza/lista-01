double valorCompra, desconto, valorFinal; //cria variável

        Console.Write("Informe o valor total da compra: R$ ");
        valorCompra = double.Parse(Console.ReadLine());

        if (valorCompra >= 200)
        {
            desconto = (valorCompra * 10) / 100;
        }
        else
        {
            desconto = 0;
        }

        valorFinal = valorCompra - desconto;

        Console.WriteLine("\nValor original: R$ " + valorCompra);
        Console.WriteLine("Desconto aplicado: R$ " + desconto);
        Console.WriteLine("Valor final: R$ " + valorFinal);