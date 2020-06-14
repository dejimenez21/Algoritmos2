using System;

namespace Trabajo_Práctico_3
{
    class Ejercicio1
    {
        public void Ejercicio()
        {
            Node head = null;

            int cantidad = 0; int valor = 0;
            
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("Introduczca la cantidad de valores deseados");
            cantidad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nIntroduczca los valores para el LinkedList");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write((i + 1) + ". ");
                valor = Convert.ToInt16(Console.ReadLine());
                LinkedList.Agregar(ref head, valor);
            }

            //Console.Clear();
            Console.WriteLine("\nLista desde el TAIL hasta el HEAD:");
            LinkedList.Reversa(ref head);
        }

        //Clase nodo para tener las referencias de las siguientes posiciones
        public class Node
        {
            public int Data = 0;
            public Node Next = null;
        }

        public static class LinkedList
        {
            //Funcion agregar para tomar en cuenta la posicion del Head y insertar el valor en el HEAD
            public static void Agregar(ref Node head, int data)
            {
                if (head != null)
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = new Node();
                    current.Next.Data = data;
                }
                else
                {
                    head = new Node();
                    head.Data = data;
                }
            }

            //Funcion que pregunta si el Head esta null o mientras el head no este nulo, avanzara en la lista moviendose de nodo
            public static void Reversa(ref Node head)
            {
                if (head == null) return;

                Node prev = null, current = head, next = null;

                while (current.Next != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }
                current.Next = prev;
                head = current;

                //Aqui decidimos imprimir la lista en la posicion actual.

                if (head == null) return;
                Node NewCurrent = head;
                while (NewCurrent != null)
                {
                    Console.WriteLine(NewCurrent.Data + " ");
                    NewCurrent = NewCurrent.Next;
                }
            }
        }
    }
}

