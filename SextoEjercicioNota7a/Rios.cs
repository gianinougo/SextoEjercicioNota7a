using System;
using System.Collections.Generic;
using System.Text;


class Rios : PuntoDeInteres
{
    private int longitud;
    public Rios(string nombre, string ubicacion, int longitud) : base(nombre, ubicacion)
    {
        this.longitud = longitud;
    }

    protected int Longitud { get => longitud; set => longitud = value; }
}

