using System;

class estudooff
{
   static void Main()
    {
        Console.Write("Digite um número interito: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um número inteiro: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = (numero + numero2) / 2;

        Console.WriteLine("resultado: = " + resultado);
        Console.ReadKey();


    }


}