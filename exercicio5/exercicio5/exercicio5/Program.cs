using System;

class exercicio5
{
    static void Main()
    {
        Console.WriteLine("===SALARIO ATUAL E SEU PORCENTUAL===");

        Console.Write("Digite o seu salário atual: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nDigite quanto você receberá de aumento: ");
        double porcentagemAumento = Convert.ToDouble(Console.ReadLine());

        double resultado = ((porcentagemAumento * salario) / 100) + salario;
        Console.WriteLine("\nNovo salário = R$ " + resultado);
        Console.ReadKey();

    }


}