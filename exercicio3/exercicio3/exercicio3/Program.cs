using System;

class exercicio3
{
    static void Main()
    {
        Console.WriteLine("==== DESCOBRINDO O VALOR DA ÁREA DE UM CIRCULO====\n");
        double tamanho_do_raio, area_do_circulo;
        Console.WriteLine("Digite o tamnho do raio do circulo: ");
        tamanho_do_raio =Convert.ToDouble(Console.ReadLine());
        double area_total_do_circulo = Math.PI * Math.Pow(tamanho_do_raio, 2);
        Console.WriteLine($"resultado: \n" + $"área do circulo: {area_total_do_circulo}");

        Console.ReadKey();
        
    }

}