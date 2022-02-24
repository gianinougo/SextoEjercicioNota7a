﻿using System;
using System.Collections.Generic;
using System.Text;


class Operaciones
{
    public void Ejecutar()
    {
        const ushort MAX = 500;
        bool salir = false;
        int numPuntosInteres = 4;


        Ciudad[] ciudades = new Ciudad[MAX];
        Rio[] rios = new Rio[MAX];
        Montanya[] montanyas = new Montanya[MAX];

        ciudades[0] = new Ciudad("Madrid", "Espanya", 200000);
        ciudades[1] = new Ciudad("Barcelona", "Espanya", 10000);
        rios[0] = new Rio("Ebro", "Galicia", 1000);
        montanyas[0] = new Montanya("Himalaya", "Conchinchina", 1500);


        do
        {

            MostrarMenu();

            switch (ElegirOpcion())
            {
                case '1':
                    AnyadirPuntoInteres(ref ciudades, ref numPuntosInteres, ref rios, ref montanyas);
                    break;
                case '2':
                    MostrarPuntosInteres(ref ciudades, ref numPuntosInteres, ref rios, ref montanyas);
                    break;
                case '3':
                    //BuscarPuntosInteres();
                    break;
                case '4':
                    //ModificarPuntosInteres();
                    break;
                case '5':
                    //EliminarPuntoInteres();
                    break;
                case '6':
                    //OrdenarDatosAlfabeticamente();
                    break;
                case '7':
                    //RepasarGeograrfia();
                    break;
                case 'S':
                    salir = true;
                    Console.WriteLine("Gracias hasta pronto");
                    break;
                default:
                    Console.WriteLine("Opcion no válida");
                    break;
            }

        } while (!salir);
    }

    private void MostrarPuntosInteres(ref Ciudad[] ciudades,
        ref int numPuntosInteres, ref Rio[] rios, ref Montanya[] montanyas)
    {
        bool encontrado = false;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    for (int i = 0; i < numPuntosInteres; i++)
                    {
                        Console.WriteLine(ciudades[i]);
                    }
                    encontrado = true;
                    break;
                case '2':
                    for (int i = 0; i < numPuntosInteres; i++)
                    {
                        Console.WriteLine(rios[i]);
                    }
                    encontrado = true;
                    break;
                case '3':
                    for (int i = 0; i < numPuntosInteres; i++)
                    {
                        Console.WriteLine(montanyas[i]);
                    }
                    encontrado = true;
                    break;
                default:
                    break;
            }

        } while (!encontrado);
        
    }

    private void AnyadirPuntoInteres(ref Ciudad[] ciudades, 
        ref int numPuntosInteres, ref Rio[] rios, ref Montanya[] montanyas)
    {
        bool insertado = false;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    string nombreCiudad = PedirDato("Nombre de la ciudad: ");
                    string ubicacionCiudad = PedirDato("Ubicacion de la ciudad: ");
                    int habitantesCiudad = Convert.ToInt32(PedirDato("Numero de habitante en miles: "));

                    ciudades[numPuntosInteres] = new Ciudad(nombreCiudad, ubicacionCiudad, habitantesCiudad);
                    numPuntosInteres++;
                    insertado = true;

                    Console.WriteLine("Ciudad anyadida correctamente.");
                    break;
                case '2':
                    string nombreRio = PedirDato("Nombre de la ciudad: ");
                    string ubicacionRio = PedirDato("Ubicacion de la ciudad: ");
                    int longitudRio = Convert.ToInt32(PedirDato("Numero de habitante en miles: "));

                    rios[numPuntosInteres] = new Rio(nombreRio, ubicacionRio, longitudRio);
                    numPuntosInteres++;

                    Console.WriteLine("Rio anyadido correctamente.");
                    insertado = true;
                    break;
                case '3':
                    string nombreMontanya = PedirDato("Nombre de la ciudad: ");
                    string ubicacionMontanya = PedirDato("Ubicacion de la ciudad: ");
                    int alturaMontaya = Convert.ToInt32(PedirDato("Numero de habitante en miles: "));

                    ciudades[numPuntosInteres] = new Ciudad(nombreMontanya, ubicacionMontanya, alturaMontaya);
                    numPuntosInteres++;

                    Console.WriteLine("Montnya anyadida correctamente.");
                    insertado = true;
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        } while (!insertado);
    }

    private string PedirDato(string campo)
    {
        Console.WriteLine("Introduce el campor \"" + campo + "\": ");
        string respuesta = Console.ReadLine();
        return respuesta;
    }

    private char ElegirOpcion()
    {
        Console.WriteLine();
        Console.WriteLine("Elige una opción: ");
        char opcion = Convert.ToChar(Console.ReadLine().ToUpper());
        return opcion;
    }

    private void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1 - Añadir un nuevo punto de interés geográfico.");
        Console.WriteLine("2 - Mostrar todos los puntos de interés");
        Console.WriteLine("3 - Buscar puntos que contengan un texto determinado.");
        Console.WriteLine("4 - Modificar un punto de interés");
        Console.WriteLine("5 - Eliminar un punto");
        Console.WriteLine("6 - Ordenar los datos alfabéticamente, por nombre");
        Console.WriteLine("7 - Repasar geografía");
        Console.WriteLine("S - Salir.");
    }

    private void MenuPuntos()
    {
        Console.WriteLine();
        Console.WriteLine("1 - Ciudad");
        Console.WriteLine("2 - Rio");
        Console.WriteLine("3 - Montanyas");
        Console.WriteLine();
    }

    public static void Main()
    {
        Operaciones Operaciones = new Operaciones();
        Operaciones.Ejecutar();
    }
}
