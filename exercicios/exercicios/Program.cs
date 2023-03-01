using System;

class Exercicios
{
     
    static void Main()
    {
        //levantamento de dados/ declaração de variáveis
        double tamanho_do_quadrado, area_do_quadrado;
        //Entrada/ comandos para a interação com o usuário/ onde os dados/variáveis recebem um valor
        Console.WriteLine("=== DESCOBRINDO ÁREA DO QUADRADO ===\n");
        Console.Write("Digite o tamanho do quadrado: ");
        tamanho_do_quadrado = Convert.ToDouble( Console.ReadLine());
        //Processamento são os comandos que realizam a operação,verificação e lógica da tarefa/código de programação
        area_do_quadrado = tamanho_do_quadrado * tamanho_do_quadrado;
        //Saída
        Console.WriteLine($"resultado: \n" +
        $" área do quadrado: {area_do_quadrado}");
        //fim
        Console.ReadKey();
    }
}