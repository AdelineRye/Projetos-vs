using System;

class Exercicio2Triângulo
{
    static void Main()
    {
        Console.WriteLine("=====PROGRAMA PARA RECEBER E REALIZAR MEDIDAS DE UM TRIÂNGULO=====\n");
        double altura_do_triângulo, base_do_triângulo, área_do_triângulo;

        Console.Write("Digite a altura do Triângulo: \n");
        altura_do_triângulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a base do Triângulo: \n");
        base_do_triângulo = Convert.ToDouble(Console.ReadLine());

        área_do_triângulo = base_do_triângulo * altura_do_triângulo / 2;
        Console.WriteLine($"resultado: \n" + $"área do Triângulo: {área_do_triângulo}");
        //fim
        Console.ReadKey();

    }

}