﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bolillero.Core
{
    public class Bolillero
    {
        // r.Next(cotaInfInc, cotaSupNoInc);
        // r.Next(0, Lista.Count);
        //
        //    .Add(e)
        //    .AddRange(l)
        //
        //   .RemoveAT(num)
        //   Clear()

    byte cantidad {get; set;}
    byte indiceAzar {get; set;}

    List<byte> Afuera {get; set;}
    List<byte> Adentro {get; set;}
    Random r;

    public Bolillero()
    {
        Afuera = new List<byte>{};
        Afuera = new List<byte>{};
        r = new Random();
    }

    public Bolillero(byte cantidad)
    {
        this.Llenar(this.cantidad);
    }

    private void Llenar(byte cantidad)
    {
        for(byte i=0; i < cantidad; i++)
        {
            Adentro.Add(i);
        }
    }

    public byte SacarBolilla()
    {
        byte indiceAzar =(byte)r.Next(0, Adentro.Count);
        byte bolilla = Adentro[indiceAzar];
        Adentro.RemoveAt(indiceAzar);
        Afuera.Add(bolilla);
        
        return bolilla;
    }

    public void RellenarBolillero()
    {
        Adentro.AddRange(Afuera);
        Afuera.Clear();
    }
    
    public Jugada(byte[] jugadas)
	{
		private byte[] jugada;

        if (Add(bolilla) == jugada)
        {
            $"win"
        }
	}

   

	public IngresarBolilla()

    }
}
