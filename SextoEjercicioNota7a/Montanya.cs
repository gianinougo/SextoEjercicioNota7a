using System;
using System.Collections.Generic;
using System.Text;


class Montanya : PuntoDeInteres
{
    protected int altitud { get; set; }

    public Montanya(string nombre, string ubicacion, int altitud) : base(nombre, ubicacion)
    {
        this.nombre = nombre;
        this.ubicacion = ubicacion;
        this.altitud = altitud;
    }

    public override string ToString()
    {
        return base.ToString() + " , " + altitud;
    }
}

