using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaLab
{
    class Ejercicios
    {
        public void Ejercicio1() 
        {
            int parN1 = 0, parN2 = 0, resultado = 1000;
            int[] nums = { 21, 40, 59, 19, 31 };

            // Si el arreglo tiene un solo numero o ninguno debe retornar un -1
            if (nums.Length <= 1)
            {
                resultado = -1;
                Console.WriteLine("Resultado: {0}", resultado);
            }
            else 
            {
                for (int i = 0; i < nums.Length - 1; i++) 
                {
                    int j = i + 1;
                    if (Math.Abs(nums[i] - nums[j]) < resultado)
                    {
                        parN1 = nums[i];
                        parN2 = nums[j];
                        resultado = Math.Abs(nums[i] - nums[j]);
                    }
                }
                Console.WriteLine("El Par de numeros es: {0} y {1}", parN1, parN2);
                Console.WriteLine("Resultado: {0}", resultado);
            }
        }

    }
}
