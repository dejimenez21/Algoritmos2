using AlgorithmsProblems.Solutions.SortingAlgorithms;
using System;
using System.Collections.Generic;

namespace Trabajo_Práctico_3
{
    class Ejercicio2
    {
        static LinkedList<int> result = new LinkedList<int>();
        public void Ejercicio()
        {
            // Se ingresa longitud de los arreglos
            Console.WriteLine("Ejercicio 2:");
            Console.WriteLine("Introduczca la longitud que tendran los arreglos");
            int cantidad = Convert.ToInt16(Console.ReadLine());
            
            int[] arr1 = new int[cantidad];
            int[] arr2 = new int[cantidad];
            
            Console.WriteLine();

            // Se registran los valores de los arreglos
            Console.WriteLine("Ingrese los valores del primer arreglo");
            for (int i = 0; i <= cantidad - 1; i++) 
            {
                Console.Write((i+1) + ". ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Ingrese los valores del segundo arreglo");
            for (int i = 0; i <= cantidad-1; i++)
            {
                Console.Write((i + 1) + ". ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Se ordenan los arreglos ingresados
            Merge merge = new Merge();
            merge.Sort(arr1);
            merge.Sort(arr2);

            LinkedList<int> list1 = new LinkedList<int>(arr1);
            LinkedList<int> list2 = new LinkedList<int>(arr2);

            Merge(list1.First, list2.First);
            
            Console.WriteLine();
            Console.WriteLine("Lista ordenada:");
            foreach (var n in result)
            {
                System.Console.Write(n + " ");
            }

            Console.Read();
        }

        static void Merge(LinkedListNode<int> node1, LinkedListNode<int> node2)
        {

            if (node1 is null && node2 is null)
            {
                return;
            }
            else if (node1 is null)
            {
                result.AddLast(node2.Value);
                Merge(node1, node2.Next);
            }
            else if (node2 is null)
            {
                result.AddLast(node1.Value);
                Merge(node1.Next, node2);
            }
            else
            {
                if (node1.Value < node2.Value)
                {
                    result.AddLast(node1.Value);
                    Merge(node1.Next, node2);
                }
                else
                {
                    result.AddLast(node2.Value);
                    Merge(node1, node2.Next);
                }
            }
        }
    }
}
