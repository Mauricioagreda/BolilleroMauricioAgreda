using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimulacionBolillero
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Bolilla> Bolillas = new List<Bolilla>();
            Bolillero Bolillero = new Bolillero(){ Id = 1, bolillas = Bolillas};

            List<Bolilla> x = new List<Bolilla>()
            {
                new Bolilla(2),
                new Bolilla(4),
                new Bolilla(6),
                new Bolilla(8),
                new Bolilla(10)
            };

            Bolillero.Jugada(x, 5);
            Print(x);
            Console.ReadKey();
        }

        static  void Print(List<Bolilla> a)
        {
            Console.WriteLine("-----------------------");
            a.ForEach(x => Console.WriteLine($"Numero: {x.Numero}"));
        }
    }
}