using System;
using System.Collections.Generic;
using System.Text;


class Ciudad : PuntoDeInteres
{
    private int habitantes;

    public Ciudad(string nombre, string ubicacion, int habitantes) : base(nombre, ubicacion)
    {
        this.habitantes = habitantes;
    }

    protected int Habitantes { get => habitantes; set => habitantes = value; }

    public override string ToString()
    {
        return base.ToString() + " , " + habitantes;
    }
}

