using System;
using System.Collections.Generic;
using System.Text;


class Ciudades : PuntoDeInteres
{
    private int habitantes;

    public Ciudades(string nombre, string ubicacion, int habitantes) : base(nombre, ubicacion)
    {
        this.habitantes = habitantes;
    }

    protected int Habitantes { get => habitantes; set => habitantes = value; }
}

