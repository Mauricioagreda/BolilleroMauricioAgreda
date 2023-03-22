using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SimulacionBolillero
{
    public class Bolillero
    {
        public int Id {get; set;}
        public List<Bolilla> bolillas {get; set;}
        int wins;
        public Bolillero()
        { }
        Random rnd = new Random();
        public void SacarBolilla()
        {
            Bolilla bolilla = new Bolilla(){Numero = rnd.Next(0, 50)};
            bolillas.Add(bolilla);
        }
        public void Jugada (List<Bolilla> a)
        {
            
                Console.WriteLine("-----------------------");
                for (int i = 0; i == 9; i++)
                {
                    SacarBolilla();
                }
                if (a == bolillas)
                {
                    Console.WriteLine("Mamamguevo");
                }
                else 
                {
                    Console.WriteLine("Digo glugluglu");
                }
                bolillas.Clear();
            
        }
    }
}