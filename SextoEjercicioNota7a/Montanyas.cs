using System;
using System.Collections.Generic;
using System.Text;


class Montanyas : PuntoDeInteres
{
    private int altitud;

    public Montanyas(string nombre, string ubicacion) : base(nombre, ubicacion)
    {
    }

    protected int Altitud { get => altitud; set => altitud = value; }
}

