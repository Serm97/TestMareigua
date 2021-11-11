using System;
using System.Collections.Generic;
using System.Linq;

namespace AppMareigua // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 3.Cree un programa que sea capaz de escribir los números del 1 al 100. 
                *Si un número es múltiplo de 3, se escribe “mare” en su lugar. 
                *Si el número es múltiplo de 5, se escribe “igua”. 
                *Si el número es múltiplo de ambos se escribe “mareigua”.
            */
            Task1 task1 = new Task1();
            Console.WriteLine("Cree un programa que sea capaz de escribir los números del 1 al 100. \n\n");
            task1.Print100Numbers();

            /* 4.Escriba una función que encuentre el entero más grande en un arreglo de 
                 enteros positivos (En cualquier lenguaje).
            */
            Task2 task2 = new Task2();
            Console.WriteLine("\n\nEscriba una función que encuentre el entero más grande en un arreglo de enteros positivos \n");
            task2.FindLargestInteger();

            /* 5. Escriba una función que reverse una cadena (En cualquier lenguaje) sin 
             * usar un método prexistente para esto.
            */
            Task3 task3 = new Task3();
            Console.WriteLine("\n\nEscriba una función que reverse una cadena (En cualquier lenguaje) sin usar un método prexistente para esto. \n\n");
            task3.Reverse();


        }
    }

}