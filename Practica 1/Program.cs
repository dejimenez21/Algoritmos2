using System;
using System.Collections.Generic;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarArrayMerger();
            Console.ReadKey();
        }

        static void IniciarTuercasYTornillos()
        {
            List<Pieza> piezas = new List<Pieza>(){
                
            };
        }

        static void IniciarArrayMerger()
        {
            int[] arr1 = new int[]{
                2, 3, 6, 7, 10
            };

            int[] arr2 = new int[]{
                1, 3, 4, 5, 8, 9
            };

            ArrayMerger merger = new ArrayMerger(arr1, arr2);
            merger.Start();
        }
    }
}
