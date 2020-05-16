using System;
using System.Collections.Generic;

namespace Practica1A
{
    class Program
    {
        static int[] array1;
        static int[] array2;

        static void Main(string[] args)
        {
            int y = 0, z = 0;

            Console.WriteLine("Ingrese el tamaño del Primer Array");
            y = Convert.ToInt16(Console.ReadLine()); array1 = new int[y];

            Console.WriteLine("\nIngrese el tamaño del Segundo Array");
            z = Convert.ToInt16(Console.ReadLine()); array2 = new int[z];

            //Llenamos los 2 arreglos con valores que uno mismo puede asignar

            Console.WriteLine("\nIngrese valores al Primer Array");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese valores al Segundo Array");
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = Convert.ToInt16(Console.ReadLine());
            }

            //Aqui ya ordenamos el arreglo usando List, agregamos los valores de los 2 array al List y se lo asignamosa una variable
            var tempList = new List<int>();
            tempList.AddRange(array1); tempList.AddRange(array2);
            int[] newArray = tempList.ToArray();
            //--------- 

            //Ahora procedemos a realizar un Bubble Sort

            int temp = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < array2.Length - i - 1; j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        temp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap) break;
            }

            /*
            for (int i = 0; i < newArray.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < newArray.Length - i - 1; j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        temp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap) break;
            }
            */

            Console.WriteLine("\nEl nuevo arreglo ya ordenado:");
            for (int u = 0; u < newArray.Length; u++)
            {
                Console.WriteLine(newArray[u]);
            }

            Console.ReadKey();
        }
    }
}
