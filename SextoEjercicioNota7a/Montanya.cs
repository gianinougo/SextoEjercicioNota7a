using System;
using System.Collections.Generic;
using System.Text;


class Montanya : PuntoDeInteres
{
    public int Altitud { get; set; }

    public Montanya(string nombre, string ubicacion, int altitud) : base(nombre, ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Altitud = altitud;
    }

    public override string ToString()
    {
        return base.ToString() + " , " + Altitud;
    }
}

