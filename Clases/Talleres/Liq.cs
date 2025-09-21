
using System;
using System.Runtime.CompilerServices;
using Helpers.validaciones;

namespace CTalleres.Talleres
{
    /// <summary>
    /// Clase que contiene la serie de ejercicios básicos de C# para práctica de methodos LIQ con colecciones .
    /// </summary>
    public static class Liq
    {
        /// <summary>
        /// Lista estática de números enteros (1 al 10) disponible para todos
        /// los ejercicios de la clase Liq.
        /// </summary>
        public static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
       
        /// <summary>
        /// Lista estática de nombres disponible para todos
        /// los ejercicios de la clase Liq.
        /// </summary>
        public static List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David","Eve" };



        /// <summary>
        /// Ejercicio 1:
        /// Filtra y muestra los números pares de la lista estática "numbers".
        /// Usa LINQ (Where) para seleccionar solo los múltiplos de 2.
        /// </summary>
        public static void Ej1()
        {
            var pares = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Números pares:");
            Console.WriteLine(string.Join(", ", pares));
        }

        /// <summary>
        /// Ejercicio 2:
        /// Calcula y muestra la suma de los números impares de la lista estática "numbers".
        /// </summary>
        public static void Ej2()
        {
            var impares = numbers.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"La suma de los números impares es: {impares}");

        }

        /// <summary>
        /// Ejercicio 3:
        /// Muestra los números mayores a 5 de la lista estática "numbers".
        /// </summary>
        public static void Ej3()
        {
            var mayores = numbers.Select(n => n > 5).OrderByDescending(n => n).ToList();
            Console.WriteLine("Números mayores a 5:");
            Console.WriteLine(string.Join(", ", mayores));
        }

        /// <summary>
        /// Ejercicio 4:
        /// Cuenta y muestra cuántos números en la lista estática "numbers" son menores o iguales a 3.
        /// </summary>
        public static void Ej4()
        {
            var numeros = numbers.Select(n => n <= 3).Count();
            Console.WriteLine($"Cantidad de números menores o iguales a 3: {numeros}");
        }

        /// <summary>
        /// Ejercicio 5:    
        /// Crea una nueva lista con los números de la lista estática "numbers" multiplicados por 2 y muestra el resultado.
        /// </summary>
        public static void Ej5()
        {
            var multiplicados = numbers.Select(n => n * 2).ToList();
            Console.WriteLine("Números multiplicados por 2:");
            Console.WriteLine(string.Join(", ", multiplicados));
        }

        /// <summary>
        /// Ejercicio 6:
        /// Ordena los nombres de la lista estática "names" alfabéticamente y muestra el resultado.
        /// </summary>
        public static void Ej6()
        {
            var ordenados = names.OrderBy(n => n).ToList();
            Console.WriteLine("Nombres ordenados alfabéticamente:");
            Console.WriteLine(string.Join(", ", ordenados));
        }

        /// <summary>
        /// Ejercicio 7:
        /// Muestra los nombres que empiezan con la letra 'A' de la lista estática "names".
        /// </summary>
        public static void Ej7()
        {
            var conA = names.Where(n => n.StartsWith("A")).ToList();
            Console.WriteLine("Nombres que empiezan con 'A':");
            Console.WriteLine(string.Join(", ", conA));
        }

        /// <summary>
        /// Ejercicio 8:
        /// Cuenta cuántos nombres tienen más de 5 caracteres en la lista estática "names".
        /// </summary>
        public static void Ej8()
        {
            var cantidad = names.Count(n => n.Length > 5);
            Console.WriteLine($"Cantidad de nombres con más de 5 caracteres: {cantidad}");
        }

        /// <summary>
        /// Ejercicio 9:
        /// Concatena todos los nombres de la lista estática "names" en una sola cadena separada por espacios.
        /// </summary>
        public static void Ej9()
        {
            var concatenados = string.Join(" ", names);
            Console.WriteLine("Nombres concatenados:");
            Console.WriteLine(concatenados);
        }

        /// <summary>
        /// Ejercicio 10:
        /// Encuentra y muestra el nombre más largo de la lista estática "names".
        /// </summary>
        public static void Ej10()
        {
            var masLargo = names.OrderByDescending(n => n.Length).First();
            Console.WriteLine($"El nombre más largo es: {masLargo}");
        }


    }

}