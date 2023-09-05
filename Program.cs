using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Libro
    {
        public string CodigoLibro { get; set; }
        public string TituloLibro { get; set; }
        public string ISBN { get; set; }
        public string Edicion { get; set; }
        public string Autor { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean Flag = true;
            int opcion = 0;
            while (Flag == true)
            {
                Console.WriteLine("Examen practico 1, digite la opcion que desea evaluar");
                Console.WriteLine("Oprima ENTER al finalizar cada accion");
                Console.WriteLine("1 - Ejercicio 1");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Salir del sistema");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Digite la clave: ");
                    int clave = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite los minutos: ");
                    int minutos = int.Parse(Console.ReadLine());
                    calcularCosto(clave, minutos);
                }
                else if (opcion == 2)
                {
                    GestionLibros();
                }
                else if (opcion == 3)
                {
                    Flag = false;
                    Console.WriteLine("Saliendo del sistema");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
                Console.ReadKey();
            }
        }
        public static void calcularCosto(int clave, int minutosTotal)
        {
            double costo = 0;
            if (clave == 12)
            {
                costo = minutosTotal * 2;
                Console.WriteLine("El costo total de la llamada a America del norte es $" + costo);
            }
            else if (clave == 15)
            {
                costo = minutosTotal * 2.2;
                Console.WriteLine("El costo total de la llamada a America central es $" + costo);
            }
            else if (clave == 18)
            {
                costo = minutosTotal * 4.5;
                Console.WriteLine("El costo total de la llamada a America del sur es $" + costo);
            }
            else if (clave == 19)
            {
                costo = minutosTotal * 3.5;
                Console.WriteLine("El costo total de la llamada a Europa es $" + costo);
            }
            else if (clave == 23)
            {
                costo = minutosTotal * 6;
                Console.WriteLine("El costo total de la llamada a Asia es $" + costo);
            }
            else
            {
                Console.WriteLine("No se ha ingresado una clave correcta");
            }
        }
        public static void GestionLibros()
        {
            int accion;
            int confirmacion = 0;
            Boolean Flag2 = true;
            List<Libro> Libros = new List<Libro>();
            Libro libro0 = new Libro();

            libro0.CodigoLibro = "10045";

            libro0.Autor = "Lovecraft";

            libro0.ISBN = "1000098";

            libro0.Edicion = "Primera edicion";

            libro0.TituloLibro = "La llamada de chtulu";
            Libros.Add(libro0);



            while (Flag2 == true)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Gestor de libros");
                Console.WriteLine("1 - Agregar un libro");
                Console.WriteLine("2 - Mostrar libros");
                Console.WriteLine("3 - Buscar por codigo");
                Console.WriteLine("4 - Editar informacion");
                Console.WriteLine("5 - Salir del sistema");
                Console.WriteLine("Seleccione la accion a realizar: ");
                accion = int.Parse(Console.ReadLine());
                confirmacion = 0;



                if (accion == 1)
                {
                    Libro libro = new Libro();
                    Console.WriteLine("Digite el codigo del libro: ");
                    libro.CodigoLibro = Console.ReadLine();
                    Console.WriteLine("Digite el autor del libro: ");
                    libro.Autor = Console.ReadLine();
                    Console.WriteLine("Digite el ISBN del libro: ");
                    libro.ISBN = Console.ReadLine();
                    Console.WriteLine("Digite la edicion del libro: ");
                    libro.Edicion = Console.ReadLine();
                    Console.WriteLine("Digite el titulo del libro: ");
                    libro.TituloLibro = Console.ReadLine();
                    Libros.Add(libro);
                    Console.WriteLine("Libro agregado excitosamente");
                }
                else if (accion == 2)
                {
                    foreach (var info in Libros)
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Nombre de libro: " + info.TituloLibro);
                        Console.WriteLine("Autor de libro: " + info.Autor);
                        Console.WriteLine("Codigo de libro: " + info.CodigoLibro);
                        Console.WriteLine("Edicion de libro: " + info.Edicion);
                        Console.WriteLine("ISBN de libro: " + info.ISBN);

                    }
                }
                else if (accion == 3)
                {
                    Console.WriteLine("Digite el codigo del libro a buscar: ");
                    string codUusario = Console.ReadLine();
                    for (int i = 0; i < Libros.Count; i++)
                    {
                        if (Libros[i].CodigoLibro == codUusario)
                        {
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("Se ha encontrado el siguiente libro: ");
                            Console.WriteLine("Nombre de libro: " + Libros[i].TituloLibro);
                            Console.WriteLine("Autor de libro: " + Libros[i].Autor);
                            Console.WriteLine("Codigo de libro: " + Libros[i].CodigoLibro);
                            Console.WriteLine("Edicion de libro: " + Libros[i].Edicion);
                            Console.WriteLine("ISBN de libro: " + Libros[i].ISBN);
                            confirmacion = 1;
                        }
                    }
                    if (confirmacion == 0)
                    {
                        Console.WriteLine("No se ha encontrado un libro con el codigo " + codUusario);
                    }
                }
                else if (accion == 4)
                {
                    Console.WriteLine("Digite el codigo del libro a buscar: ");
                    string codUusario = Console.ReadLine();
                    for (int i = 0; i < Libros.Count; i++)
                    {
                        if (Libros[i].CodigoLibro == codUusario)
                        {
                            Console.WriteLine("Digite los actos a actualuzar del libro: " + Libros[i].TituloLibro);
                            Console.WriteLine("Nombre de libro: ");
                            Libros[i].TituloLibro = Console.ReadLine();
                            Console.WriteLine("Autor de libro: ");
                            Libros[i].Autor = Console.ReadLine();
                            Console.WriteLine("Codigo de libro: ");
                            Libros[i].CodigoLibro = Console.ReadLine();
                            Console.WriteLine("Edicion de libro: ");
                            Libros[i].Edicion = Console.ReadLine();
                            Console.WriteLine("ISBN de libro: ");
                            Libros[i].ISBN = Console.ReadLine();
                            Console.WriteLine("Datos actualizados exitosamente!");
                            confirmacion = 1;
                        }
                    }
                    if (confirmacion == 0)
                    {
                        Console.WriteLine("No se ha encontrado un libro con el codigo " + codUusario);
                    }
                }
                else if (accion == 5)
                {
                    Console.WriteLine("Saliendo del gestor de libros!");
                    Flag2 = false;

                }
                else
                {
                    Console.WriteLine("Opcion no valida!");
                }
            }
        }
    }
}

