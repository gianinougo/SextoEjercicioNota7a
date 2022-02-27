//Por Ugo Gianino Ejercicio con Nota
using System;
using System.Collections.Generic;
using System.Text;


class Operaciones
{
    public void Ejecutar()
    {
        //const ushort MAX = 500;
        bool salir = false;
        //int numPuntosInteres = 0;
        int numCiudades = 2;
        int numRios = 2;
        int numMontanyas = 2;


        List<Ciudad> ciudades = new List<Ciudad>();
        List<Rio> rios = new List<Rio>();
        List<Montanya> montanyas = new List<Montanya>();
        

        ciudades.Add(new Ciudad("Ciudad 9", "Ciudad", 2));
        ciudades.Add(new Ciudad("aCiudad 2", "Ciudad", 1));

        rios.Add(new Rio("Rio 9", "Rio", 2));
        rios.Add(new Rio("aRio 2", "Rio", 3));

        montanyas.Add(new Montanya("Montanya 9", "Montanya", 4));
        montanyas.Add(new Montanya("aMontanya 2", "Montanya", 5));



        do
        {

            MostrarMenu();

            switch (ElegirOpcion())
            {
                case '1':
                    AnyadirPuntoInteres(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
                    break;
                case '2':
                    MostrarPuntosInteres(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
                    break;
                case '3':
                    BuscarPuntosInteres(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
                    break;
                case '4':
                    ModificarPuntosInteres(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
                    break;
                case '5':
                    EliminarPuntoInteres(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
                    break;
                case '6':
                    OrdenarDatosAlfabeticamente(ref ciudades, ref rios, ref montanyas, ref numCiudades, ref numRios, ref numMontanyas);
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

    private void OrdenarDatosAlfabeticamente(ref List<Ciudad> ciudades,
        ref List<Rio> rios, ref List<Montanya> montanyas,
        ref int numCiudades, ref int numRios, ref int numMontanyas)
    {
        bool ordenado = true;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    ciudades.Sort();
                    for (int i = 0; i < numCiudades; i++)
                    {
                        Console.WriteLine(ciudades[i]);
                    }
                    ordenado = true;
                    Console.WriteLine();
                    break;
                case '2':
                    rios.Sort();
                    for (int i = 0; i < numRios; i++)
                    {
                        Console.WriteLine(rios[i]);
                    }
                    ordenado = true;
                    Console.WriteLine();
                    break;
                case '3':
                    montanyas.Sort();
                    for (int i = 0; i < numMontanyas; i++)
                    {
                        Console.WriteLine(montanyas[i]);
                    }
                    ordenado = true;
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (!ordenado);
    }

    private void ModificarPuntosInteres(ref List<Ciudad> ciudades,
        ref List<Rio> rios, ref List<Montanya> montanyas,
        ref int numCiudades, ref int numRios, ref int numMontanyas)
    {
        bool modificado = false;

        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    int posicion = Convert.ToInt32(PedirDato("Posicion")) - 1;
                    if (posicion < 0 || posicion >= numCiudades)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine(ciudades[posicion]);
                        string nuevoNombre = PedirDato("Nuevo nombre");
                        string nuevaUbicacion = PedirDato("Nueva ubicación");
                        int nuevosHabitantes = Convert.ToInt32(PedirDato("Numero de Habitantes"));
                        if (nuevoNombre != "")
                        {
                            ciudades[posicion].Nombre = nuevoNombre.Trim();
                            ciudades[posicion].Ubicacion = nuevaUbicacion.Trim();
                            ciudades[posicion].habitantes = nuevosHabitantes;
                            modificado = true;
                        }
                    }
                    break;
                case '2':
                    int posicion2 = Convert.ToInt32(PedirDato("Posicion")) - 1;
                    if (posicion2 < 0 || posicion2 >= numRios)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine(rios[posicion2]);
                        string nuevoNombre = PedirDato("Nuevo nombre");
                        string nuevaUbicacion = PedirDato("Nueva ubicación");
                        int nuevaLongitud = Convert.ToInt32(PedirDato("Longitud"));
                        if (nuevoNombre != "")
                        {
                            rios[posicion2].Nombre = nuevoNombre.Trim();
                            rios[posicion2].Ubicacion = nuevaUbicacion.Trim();
                            rios[posicion2].Longitud = nuevaLongitud;
                            modificado = true;
                        }
                    }
                    break;
                case '3':
                    int posicion3 = Convert.ToInt32(PedirDato("Posicion")) - 1;
                    if (posicion3 < 0 || posicion3 >= numMontanyas)
                    {
                        Console.WriteLine("Número no valido");
                    }
                    else
                    {
                        Console.WriteLine(montanyas[posicion3]);
                        string nuevoNombre = PedirDato("Nuevo nombre");
                        string nuevaUbicacion = PedirDato("Nueva ubicación");
                        int nuevaAltitud = Convert.ToInt32(PedirDato("Longitud"));
                        if (nuevoNombre != "")
                        {
                            montanyas[posicion3].Nombre = nuevoNombre.Trim();
                            montanyas[posicion3].Ubicacion = nuevaUbicacion.Trim();
                            montanyas[posicion3].Altitud = nuevaAltitud;
                            modificado = true;
                        }
                    }
                    break;
                default:
                    break;
            }
        } while (!modificado);
    }

    private void EliminarPuntoInteres(ref List<Ciudad> ciudades,
        ref List<Rio> rios, ref List<Montanya> montanyas,
        ref int numCiudades, ref int numRios, ref int numMontanyas)
    {
        bool eliminado = false;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    int eliminar = Convert.ToInt32(PedirDato("Que posicion quiere eliminar?")) - 1;

                    if (eliminar < 0 || eliminar >= numCiudades)
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
                            for (int i = eliminar; i < numCiudades - 1; i++)
                            {
                                ciudades[i] = ciudades[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numCiudades--;
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

                    if (eliminar2 < 0 || eliminar2 >= numRios)
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
                            for (int i = eliminar2; i < numRios - 1; i++)
                            {
                                rios[i] = rios[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numRios--;
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

                    if (eliminar3 < 0 || eliminar3 >= numMontanyas)
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
                            for (int i = eliminar3; i < numMontanyas - 1; i++)
                            {
                                montanyas[i] = montanyas[i + 1];
                            }
                            Console.WriteLine("Eliminado correctamente");
                            numMontanyas--;
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

    private void BuscarPuntosInteres(ref List<Ciudad> ciudades,
        ref List<Rio> rios, ref List<Montanya> montanyas,
        ref int numCiudades, ref int numRios, ref int numMontanyas)
    {
        bool encontrado = false;
        do
        {   //ME DA NULL CREO QUE ES POR NUMPUNTOSINTERES
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    if (numCiudades > 0) 
                    {
                        string buscar2 = PedirDato("Cidudad");

                        for (int i = 0; i < numCiudades; i++)
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
                    if (numRios > 0)
                    {
                        string buscar = PedirDato("Rio");
                        for (int i = 0; i < numRios; i++)
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
                    }
                    break;
                case '3':
                    if (numMontanyas > 0)
                    {
                        string buscar3 = PedirDato("Montanya");
                        for (int i = 0; i < numMontanyas; i++)
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
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (!encontrado);


    }

    private void MostrarPuntosInteres(ref List<Ciudad> ciudades,
        ref List<Rio> rios, ref List<Montanya> montanyas,
        ref int numCiudades, ref int numRios, ref int numMontanyas)
    {
        bool encontrado = false;
        do
        {
            MenuPuntos();
            switch (ElegirOpcion())
            {
                case '1':
                    for (int i = 0; i < numCiudades; i++)
                    {
                        Console.WriteLine(ciudades[i]);
                    }
                    encontrado = true;
                    break;
                case '2':
                    for (int i = 0; i < numRios; i++)
                    {
                        Console.WriteLine(rios[i]);
                    }
                    encontrado = true;
                    break;
                case '3':
                    for (int i = 0; i < numMontanyas; i++)
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

    private void AnyadirPuntoInteres(ref List<Ciudad> ciudades, 
        ref List<Rio> rios, ref List<Montanya> montanyas, 
        ref int numCiudades, ref int numRios, ref int numMontanyas)
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

                    ciudades.Add(new Ciudad(nombreCiudad, ubicacionCiudad, habitantesCiudad));
                    numCiudades++;
                    insertado = true;

                    Console.WriteLine("Ciudad anyadida correctamente.");
                    break;
                case '2':
                    string nombreRio = PedirDato("Nombre de la ciudad: ");
                    string ubicacionRio = PedirDato("Ubicación de la ciudad: ");
                    int longitudRio = Convert.ToInt32(PedirDato("Numero de habitante en miles: "));

                    rios.Add(new Rio(nombreRio,ubicacionRio,longitudRio));
                    numRios++;

                    Console.WriteLine("Rio anyadido correctamente.");
                    insertado = true;
                    break;
                case '3':
                    string nombreMontanya = PedirDato("Nombre de la ciudad: ");
                    string ubicacionMontanya = PedirDato("Ubicacion de la ciudad: ");
                    int alturaMontaya = Convert.ToInt32(PedirDato("Numero de habitante en miles: "));

                    montanyas.Add(new Montanya(nombreMontanya, ubicacionMontanya, alturaMontaya));
                    numMontanyas++;

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

