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
        private string _placa;
        public string Placa 
        { 
            get
            {
                return _placa;
            }
            set 
            {
                if (value.Length == 7)
                {
                    _placa = value;
                }
                else 
                {
                    throw new PlacaException("A placa precisa conter exatamente 7 caracteres.");
                }
                
            } 
        }
    }
}