using System;

class Exercicio1
{
    static void Main()
    {
        Console.WriteLine("==== DESCOBRINDO A ÁREA DO QUADRADO ====\n");
        double tamanho_do_quadrado, area_do_quadrado;
        Console.Write("Digite o tamanho do quadrado: \n");
        tamanho_do_quadrado = Convert.ToDouble(Console.ReadLine());
        area_do_quadrado = tamanho_do_quadrado * tamanho_do_quadrado;
        Console.WriteLine($"resultado: \n" + $"área do quadrado: {area_do_quadrado}");

        Console.ReadKey();
    }

}