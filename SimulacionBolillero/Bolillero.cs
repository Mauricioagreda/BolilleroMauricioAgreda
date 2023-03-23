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

        private const int V = 0;
        List<Bolilla> listBolillas = new List<Bolilla>();
        int wins;
        Random rnd = new Random();

        public Bolillero()
        { 
            for (int i = 1; i == 10; i++)
            {
                bolillas.Add(new Bolilla(i));
            }
        }
        
        public void SacarBolilla()
        {
            int num = rnd.Next(1,10);
            var bolilla = bolillas.Where(x => x.Numero == num).ToList();
            bolillas.RemoveAll(x => x.Numero == num);
            if (bolillas.Count == 9) 
            {
                listBolillas.AddRange(bolilla);
                ReIngresar(bolilla);
            }
            else
            {
                throw new Exception("Error al sacar bolilla");
            }
            bolilla.Clear();
        }
        public void ReIngresar(List<Bolilla> x)
        {
            bolillas.AddRange(x);
            if(bolillas.Count(x => x.Numero > 0) < 10 )
            {
                throw new Exception("Bolillas fuera del bolillero");
            }
        }
        public void Jugada (List<Bolilla> a, int jugadas)
        {
            wins = 0;
            for (var f = 0; f == jugadas; f++)
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
                    wins++;
                    Console.WriteLine("Digo glugluglu");
                }
                bolillas.Clear();
                listBolillas.Clear();
            }
            Console.WriteLine($"Cantidad Aciertos: {wins}");
        }
    }
}