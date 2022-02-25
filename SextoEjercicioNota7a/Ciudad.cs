using System;
using System.Collections.Generic;
using System.Text;


class Ciudad : PuntoDeInteres
{
    public int habitantes { get; set; }

    public Ciudad(string nombre, string ubicacion, int habitantes) : base(nombre, ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.habitantes = habitantes;
    }

    public override string ToString()
    {
        return base.ToString() + " , " + habitantes;
    }
}

