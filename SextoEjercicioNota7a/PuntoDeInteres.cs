using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;


abstract class PuntoDeInteres : IComparable<PuntoDeInteres>
{
    public string Nombre { get; set; }
    public string Ubicacion { get; set; }

    public PuntoDeInteres(string nombre, string ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
    }


    public override string ToString()
    {
        return Nombre
            + " , " + Ubicacion;
    }

    public int CompareTo(PuntoDeInteres other)
    {
        return this.Nombre.CompareTo(other.Nombre);
    }
}

