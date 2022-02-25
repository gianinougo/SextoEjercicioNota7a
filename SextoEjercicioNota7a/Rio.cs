using System;
using System.Collections.Generic;
using System.Text;


class Rio : PuntoDeInteres
{
    public int Longitud { get; set; }

    public Rio(string nombre, string ubicacion, int longitud) : base(nombre, ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Longitud = longitud;
    }


    public override string ToString()
    {
        return base.ToString() + " , " + Longitud;
    }
}

