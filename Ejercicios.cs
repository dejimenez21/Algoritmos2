using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaLab
{
    class Ejercicios
    {
        public void Ejercicio1() 
        {
            int result = 1000; int par1 = 0, par2 = 0;
            int[] nums = { 21, 16, 40, 59, 19};

            // Si el arreglo tiene un solo numero o ninguno debe retornar un -1
            if (nums.Length <= 1)
            {
                result = -1;
                Console.WriteLine("Resultado: {0}", result);
            }
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        // Calculando resta con valor absoluto para obtener el par de numeros
                        // cuya distancia sea la menor dentro del arreglo
                        if (Math.Abs(nums[i] - nums[j]) < result)
                        {
                            par1 = nums[i];
                            par2 = nums[j];
                            result = Math.Abs(nums[i] - nums[j]);
                        }
                    }
                }
                Console.WriteLine("El Par de numeros es: {0} y {1}", par1, par2);
                Console.WriteLine("Resultado: {0}", result);
            }
        }
    }    
}
