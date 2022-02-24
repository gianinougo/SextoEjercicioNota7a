using System;
using System.Collections.Generic;
using System.Text;


abstract class PuntoDeInteres
{
    private string nombre;
    private string ubicacion;

    public PuntoDeInteres(string nombre, string ubicacion)
    {
        this.nombre = nombre;
        this.ubicacion = ubicacion;
    }

    protected string Nombre { get => nombre; set => nombre = value; }
    protected string Ubicacion { get => ubicacion; set => ubicacion = value; }
}

