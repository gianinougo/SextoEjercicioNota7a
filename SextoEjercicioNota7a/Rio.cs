using System;
using System.Collections.Generic;
using System.Text;


class Rio : PuntoDeInteres
{
    protected int longitud { get; set; }

    public Rio(string nombre, string ubicacion, int longitud) : base(nombre, ubicacion)
    {
        this.nombre = nombre;
        this.ubicacion = ubicacion;
        this.longitud = longitud;
    }


    public override string ToString()
    {
        return base.ToString() + " , " + longitud;
    }
}

