using System;
using System.Collections.Generic;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool salir = false;
            while(!salir)
            {
                Console.Clear();
                System.Console.WriteLine("Elija una opcion:");
                System.Console.WriteLine("1- Mezclador de arreglos");
                System.Console.WriteLine("2- Tuercas y tornillos");
                System.Console.WriteLine("3- Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                

                switch(opcion)
                {
                    case 1:
                        IniciarArrayMerger();
                        break;
                    
                    case 2:
                        IniciarTuercasYTornillos();
                        break;
                    
                    case 3:
                        salir = true;
                        break;
                    

                }
                Console.ReadKey();
            }
            
        }

        static void IniciarTuercasYTornillos()
        {
            List<Pieza> piezas = new List<Pieza>();

            System.Console.WriteLine("Ingrese la lista de tuercas y tornillos separados por espacios.");
            System.Console.WriteLine("Para ingresar una tuerca digite tc seguido de un numero para su tamaño.");
            System.Console.WriteLine("Para un tornillo lo mismo pero con tn");
            System.Console.WriteLine("Ejemplo: tc4 tn5 tc5 tn4");
            System.Console.WriteLine("(Recuerde que debe haber la misma cantidad de tuercas que de tornillos, y a cada tuerca debe corresponderle uno y solo un tornillo.)");

            foreach (var pieza in Console.ReadLine().Split(' '))
            {
                piezas.Add(new Pieza((pieza[1] == 'c' ? "tuerca" : "tornillo"), int.Parse(pieza.Substring(2))));
            }
            TuercasYTornillos tyt = new TuercasYTornillos(piezas);
            tyt.Start();
        }

        static void IniciarArrayMerger()
        {

            Console.Clear();
            System.Console.WriteLine("Mezclador de arreglos ordenados:\n");
            System.Console.WriteLine("Ingrese el primer arreglo (numeros separados por espacios):");
            var arr1String = Console.ReadLine().Split(' ');
            System.Console.WriteLine("Ingrese el segundo arreglo (numeros separados por espacios):");
            var arr2String = Console.ReadLine().Split(' ');

            int[] arr1 = Array.ConvertAll(arr1String, x=>int.Parse(x));
            int[] arr2 = Array.ConvertAll(arr2String, x=>int.Parse(x));

            ArrayMerger merger = new ArrayMerger(arr1, arr2);
            merger.Start();
        }
    }
}
