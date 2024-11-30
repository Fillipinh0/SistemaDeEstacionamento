using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using bootcamp.Models.Exceptions;

namespace bootcamp.Models
{
    public class Veiculos
    {
        //private
        private string _placa;

        //atributo
        public string Placa 
        { 
            get => _placa;
            set 
            {
                if (value.Length == 8)
                {
                    _placa = value;
                }
                else 
                {
                    throw new PlacaException("Erro: A placa precisa conter exatamente 8 caracteres, contando com o hífen ('-').");
                }
                
            } 
        }

        public Veiculos(string placa)
        {
            Placa = placa;
        }

        public override string ToString()
        {
            return $" Placa: {Placa}";
        }

    }
}