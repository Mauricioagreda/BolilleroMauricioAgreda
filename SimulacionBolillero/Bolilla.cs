using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SimulacionBolillero
{
    public class Bolilla
    {
       public int Numero {get; set;}
       public Bolilla()
       { }
       public Bolilla(int numero)
       {
           Numero = numero;
       }
    }
}