using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp.Models.Exceptions
{
    public class PlacaException : Exception
    {
            public PlacaException(string message) : base(message)
            {
                
            }
    }
}