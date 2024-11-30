using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public List<Veiculos> veiculos { get; set;}


        //Construtores

        public Garagem(decimal taxaFixa, decimal taxaPorHora)
        {
            TaxaFixa = taxaFixa;
            TaxaPorHora = taxaPorHora;
        }
    }
}