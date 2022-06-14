using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstadosStruc _estado;
            Estados es = new Estados();

            string opci;
            do
            {
                EstadosStruc esta = new EstadosStruc();
                Console.WriteLine("Menu de opciones, seleccione una");
                Console.WriteLine("1.- Consultar Todos ");
                Console.WriteLine("2.- Consultar 1");
                Console.WriteLine("3.- Agregar");
                Console.WriteLine("4.- Actualizar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("6.- Termina ");
                opci = Console.ReadLine();
                Console.WriteLine("Usted seleccionó la opcion: " + opci);

                switch (opci)
                {
                    case "1":
                        Console.WriteLine("1.- Consultar Todos ");

                        Dictionary<string, EstadosStruc> _listEstados = es.ConsultaTodos();

                        foreach (KeyValuePair<string, EstadosStruc> kvp in _listEstados)
                        {
                            Console.WriteLine("ID: " + kvp.Key + " Estado: " + kvp.Value.DES+".");
                        }

                        Console.ReadKey();

                        break;

                    case "2":
                        Console.WriteLine("2.- Consultar 1");
                        Console.WriteLine("Ingresa id a consultar");
                        string ide = Console.ReadLine();
                        esta = es.ConsultaUno(ide);
                        Console.WriteLine($"key = {esta.IDE}  Des {esta.DES}");
                        break;

                    case "3":
                        Console.WriteLine("3.- Agregar");
                        Console.WriteLine("Ingresa ID");
                        esta.IDE = Console.ReadLine();
                        Console.WriteLine("Ingresa nombre");
                        esta.DES = Console.ReadLine();

                        Estados.Agregar(esta);

                        //Dictionary<string, EstadosStruc> _listEstadosA = es.Agregar();
                        break;

                    case "4":
                        Console.WriteLine("4.- Actualizar");
                        Console.WriteLine("Ingresa ID para actualizar");
                        esta.IDE = Console.ReadLine();

                        Console.WriteLine("Ingresa name");
                        esta.DES = Console.ReadLine();

                        Estados.Actualizar(esta);

                        break;

                    case "5":
                        Console.WriteLine("5.- Eliminar");
                        Console.WriteLine("Ingresa ID para eliminar");
                        esta.IDE = Console.ReadLine();
                        Estados.Eliminar(esta);

                        break;

                    case "6":
                        Console.WriteLine("6.- Termina ");
                        return;
                        

                    default:
                        Console.WriteLine("No valido");
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Presiona una tecla para repetir ");
                Console.WriteLine("Presiona una 0 para cerrar ");
                Char opci3 = ' ';
                opci3 = Console.ReadKey().KeyChar;
                if (opci3 == '0')
                {
                    Environment.Exit(0);
                }
                else
                    Console.Clear();
            }
            while (opci != "f");

            Console.ReadKey();

            

        }
    }
}
