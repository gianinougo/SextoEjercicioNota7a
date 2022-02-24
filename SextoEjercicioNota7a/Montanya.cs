using System;
using System.Collections.Generic;
using System.Text;


class Montanya : PuntoDeInteres
{
    private int altitud;

    public Montanya(string nombre, string ubicacion, int altitud) : base(nombre, ubicacion)
    {
        this.altitud = altitud;
    }

    protected int Altitud { get => altitud; set => altitud = value; }

    public override string ToString()
    {
        return base.ToString() + " , " + altitud;
    }
}

