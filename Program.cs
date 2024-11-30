using System.Formats.Tar;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using bootcamp.Models;

internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("Digite o valor da taxa fixa:");
        decimal taxaFixa = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Agora digite o valor por hora:");
        decimal taxaPorHora = decimal.Parse(Console.ReadLine());

        Garagem garagem = new Garagem(taxaFixa, taxaPorHora);


        char inputOpcoes = 'a';
        while (inputOpcoes != '4')
        {
            Console.Clear();

            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine(" 1 - Cadastrar veículo");
            Console.WriteLine(" 2 - Remover veículo");
            Console.WriteLine(" 3 - Lístar veículos");
            Console.WriteLine(" 4 - Encerrar");
            Console.WriteLine();
            Console.Write("Digite Aqui: ");

            inputOpcoes = char.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (inputOpcoes)
            {
                case '1':
                Console.Write("Digite a placa do veículo para estacionar:");
            }

        }

    }
}