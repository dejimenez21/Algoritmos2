using AlgorithmsProblems.Solutions.SortingAlgorithms;
using System;
using System.Collections.Generic;

namespace Practica_2
{
    class Program
    {
        static Dictionary<int, int> map;
        static void Main(string[] args)
        {
            int[] numbers = new int[]{
                6, 2, 15, 5, 13, -4, -6, -8, 10
            };

            int value = 2;

            numbers = Sort(numbers);
            int result = MinPairIndex(numbers);
            
            SumFinder(numbers, value);

            Console.WriteLine("Resultado ejercicio 1. El par cuya distancia es la minima:");
            System.Console.WriteLine($"{numbers[result]}, {numbers[result+1]}");
            
            Console.WriteLine();
            
            Console.WriteLine("Resultado ejercicio 2. Suma de dos numeros cuyo resultado sea el valor ({0}) dado:", value);
            foreach(var pair in map)
            {
                System.Console.Write($"{pair.Key} + {pair.Value}\n");
            }

            Console.ReadKey();
        }

        static int MinPairIndex(int[] numbers) // Ejercicio 1
        {
            Merge merge = new Merge();
            numbers = merge.Sort(numbers); // Se ordena el arreglo

            int minDistance=0;
            int resultIndex = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if(i==0)
                {
                    minDistance=numbers[i+1]-numbers[i];
                    resultIndex=i;
                    continue;
                }
                int temp = numbers[i+1]-numbers[i];
                if(temp < minDistance)
                {
                    minDistance=temp;
                    resultIndex=i;
                }
            }
            
            return resultIndex; /* Se retorna el indice del arreglo donde se encuentra el primer valor del par 
                                   una vez ordenado el arreglo     */
        }

        static int[] Sort(int[] numbers)
        {
            Merge merge = new Merge();
            var sortedNumbers = merge.Sort(numbers);
            return sortedNumbers;
        }

        static void SumFinder(int[] numbers, int value) // Ejercicio 2
        {
            map = new Dictionary<int, int>();
            int i =0;
            int j = numbers.Length -1;

            while(i!=j)
            {
                
                int sum = numbers[i] + numbers[j];
                if(sum == value)
                {
                    if(!map.ContainsKey(numbers[i]))
                        map.Add(numbers[i], numbers[j]);
                    else
                    {
                        i++;
                        j--;
                        continue;
                    }
                }
                else if(sum < value)
                {
                    i++;
                }
                else if(sum > value)
                {
                    j--;
                }
            }
        }
    }
}