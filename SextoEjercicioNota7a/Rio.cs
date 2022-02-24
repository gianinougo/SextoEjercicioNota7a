using System;
using System.Collections.Generic;
using System.Text;


class Rio : PuntoDeInteres
{
    private int longitud;
    public Rio(string nombre, string ubicacion, int longitud) : base(nombre, ubicacion)
    {
        this.longitud = longitud;
    }

    protected int Longitud { get => longitud; set => longitud = value; }

    public override string ToString()
    {
        return base.ToString() + " , " + longitud;
    }
}

