using System;
using System.Collections.Generic;
using System.Text;


abstract class PuntoDeInteres
{
    public string nombre { get; set; }
    public string ubicacion { get; set; }

    public PuntoDeInteres(string nombre, string ubicacion)
    {
        this.nombre = nombre;
        this.ubicacion = ubicacion;
    }


    public override string ToString()
    {
        return nombre
            + " , " + ubicacion;
    }
}

