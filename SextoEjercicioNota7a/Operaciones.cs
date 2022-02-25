//Por Ugo Gianino Ejercicio con Nota
using System;
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
                    BuscarPuntosInteres(ciudades, ref numPuntosInteres, ref rios, ref montanyas);
                    break;
                case '4':
                    ModificarPuntosInteres(ciudades, ref numPuntosInteres, ref rios, ref montanyas);
                    break;
                case '5':
                    EliminarPuntoInteres(ciudades, ref numPuntosInteres, ref rios, ref montanyas);
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

    private void ModificarPuntosInteres(Ciudad[] ciudades,
        ref int numPuntosInteres, ref Rio[] rios, ref Montanya[] montanyas)
    {
        bool modificado = false;

        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    int posicion = Convert.ToInt32(PedirDato("Posicion")) - 1;
                    if (posicion < 0 || posicion >= numPuntosInteres)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine("Nombre: " + ciudades[posicion].nombre);
                        //Me he quedado por aquí
                    }



                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    break;
            }
        } while (!modificado);
    }

    private void EliminarPuntoInteres(Ciudad[] ciudades,
        ref int numPuntosInteres, ref Rio[] rios, ref Montanya[] montanyas)
    {
        bool eliminado = false;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    int eliminar = Convert.ToInt32(PedirDato("Que posicion quiere eliminar?")) - 1;

                    if (eliminar < 0 || eliminar >= numPuntosInteres)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine("Desea eliminar {0}, {1}", eliminar + 1, ciudades[eliminar].ToString());
                        //Console.WriteLine("Desea eliminar s/n");
                        string decision = PedirDato("Eliminar? S/N").ToLower();

                        if (decision == "s")
                        {
                            for (int i = eliminar; i < numPuntosInteres - 1; i++)
                            {
                                ciudades[i] = ciudades[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numPuntosInteres--;
                            eliminado = true;
                        }
                        else
                        {
                            Console.WriteLine("No se ha eliminado nada");
                        }

                    }
                    Console.WriteLine();
                    break;
                case '2':
                    int eliminar2 = Convert.ToInt32(PedirDato("Que posicion quiere eliminar?")) - 1;

                    if (eliminar2 < 0 || eliminar2 >= numPuntosInteres)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine("Desea eliminar {0}, {1}", eliminar2 + 1, rios[eliminar2].ToString());
                        //Console.WriteLine("Desea eliminar s/n");
                        string decision = PedirDato("Eliminar? S/N").ToLower();

                        if (decision == "s")
                        {
                            for (int i = eliminar2; i < numPuntosInteres - 1; i++)
                            {
                                rios[i] = rios[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numPuntosInteres--;
                            eliminado = true;
                        }
                        else
                        {
                            Console.WriteLine("No se ha eliminado nada");
                        }

                    }
                    Console.WriteLine();
                    break;

                case '3':
                    int eliminar3 = Convert.ToInt32(PedirDato("Que posicion quiere eliminar?")) - 1;

                    if (eliminar3 < 0 || eliminar3 >= numPuntosInteres)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine("Desea eliminar {0}, {1}", eliminar3 + 1, montanyas[eliminar3].ToString());
                        //Console.WriteLine("Desea eliminar s/n");
                        string decision = PedirDato("Eliminar? S/N").ToLower();

                        if (decision == "s")
                        {
                            for (int i = eliminar3; i < numPuntosInteres - 1; i++)
                            {
                                montanyas[i] = montanyas[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numPuntosInteres--;
                            eliminado = true;
                        }
                        else
                        {
                            Console.WriteLine("No se ha eliminado nada");
                        }

                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }

        } while (!eliminado);

    }

    private void BuscarPuntosInteres(Ciudad[] ciudades,
        ref int numPuntosInteres, ref Rio[] rios, ref Montanya[] montanyas)
    {
        bool encontrado = false;
        do
        {   //ME DA NULL CREO QUE ES POR NUMPUNTOSINTERES
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    if (numPuntosInteres > 0) 
                    {
                        string buscar2 = PedirDato("Cidudad");

                        for (int i = 0; i < numPuntosInteres; i++)
                        {
                            if (ciudades[i].ToString().ToLower().Contains(buscar2))
                            {
                                Console.WriteLine(ciudades[i]);
                                encontrado = true;

                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se ha encontrado " +
                                "la ciudad que buscabas");
                        }
                    }
                    break;
                case '2':
                    string buscar = PedirDato("Rio");
                    for (int i = 0; i < numPuntosInteres; i++)
                    {
                        if (rios[i].ToString().ToLower().Contains(buscar))
                        {
                            Console.WriteLine(rios[i]);
                            encontrado = true;
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No se ha encontrado " +
                                "el rio que buscabas");
                        }
                    }
                    break;
                case '3':
                    string buscar3 = PedirDato("Montanya");
                    for (int i = 0; i < numPuntosInteres; i++)
                    {
                        if (montanyas[i].ToString().ToLower().Contains(buscar3))
                        {
                            Console.WriteLine(montanyas[i]);
                            encontrado = true;
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No se ha encontrado " +
                                "la montanya que buscabas");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (!encontrado);


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
                    string ubicacionRio = PedirDato("Ubicación de la ciudad: ");
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

