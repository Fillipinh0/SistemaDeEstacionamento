using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using bootcamp.Models.Exceptions;
using System.Numerics;

namespace bootcamp.Models
{
    public class Garagem
    {
        //privates
        private decimal _taxaFixa;
        private decimal _taxaPorHora;
        
        


        //Atributos
        public decimal TaxaFixa 
        {
            get => _taxaFixa;
            set => _taxaFixa = value;
            
        }
        public decimal TaxaPorHora
        {
            get => _taxaPorHora;
            set => _taxaPorHora = value;
        }

        public List<Veiculos> veiculos { get; set; } = new List<Veiculos>(); //Como seria o encapsulamento neste caso??

        


        //Construtores
        public Garagem(decimal taxaFixa, decimal taxaPorHora)
        {
            TaxaFixa = taxaFixa;
            TaxaPorHora = taxaPorHora;
        }

        //Metodos

        public void CadastrarVeiculo()
        {
            try
            {
                Console.Write("Digite a placa do vículo para estacionar: ");
                string getPlaca = Console.ReadLine().ToUpper();

                veiculos.Add(new Veiculos(getPlaca));
            }
            catch(PlacaException PlacaInvalida)
            {
                Console.WriteLine($"Aplaca não foi cadastrada! {PlacaInvalida.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine("precione a tecla ENTER para continuar");
            Console.ReadLine();
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (Veiculos veiculo in veiculos)
            {
                Console.WriteLine(veiculo.ToString());
            }
            Console.WriteLine("precione a tecla ENTER para continuar");
            Console.ReadLine();
        }

        public void RemoverVeiculo()
        {
            try
            {
                Console.Write("Digite a placa do veiculo que deseja remover: ");
                string placaParaRemover = Console.ReadLine().ToUpper();

                var veiculoParaRemover = veiculos.FirstOrDefault(v => v.Placa == placaParaRemover);

                if (veiculoParaRemover != null)
                {
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");

                    int tempoEstacionado = int.Parse(Console.ReadLine());

                    decimal valorTotal = CalculaValorFinal(tempoEstacionado);

                    veiculos.Remove(veiculoParaRemover);

                    Console.WriteLine($"Veículo com placa {placaParaRemover} foi removido e o preço total foi de R$ {valorTotal}");
                }
                else
                {
                    throw new PlacaException("A placa informada não está registrada no sistema. Por favor, verifique e tente novamente.");
                }
                
            }
            catch(PlacaException PlacaNaoExiste)
            {
                Console.WriteLine($"Erro: {PlacaNaoExiste.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("precione a tecla ENTER para continuar");
            Console.ReadLine();
        }

        public decimal CalculaValorFinal(int tempoEstacionado)
        {
            
            return TaxaFixa + (TaxaPorHora * tempoEstacionado);
        }
    }
}