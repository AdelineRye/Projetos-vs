using System;

class exercicio4
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        int resultado = (idade * 365);

        Console.WriteLine("resultado = " + resultado);
        Console.ReadKey();
    }

}