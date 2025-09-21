
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
        public static List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        /// <summary>
        /// Lista adicional de palabras para ejercicios combinados.
        /// </summary>
        public static List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

        /// <summary>
        /// Lista adicional de números enteros para ejercicios combinados.
        /// </summary>
        public static List<int> data = new List<int> { 1, 2, 3, 4, 5, 6 };

        /// <summary>
        /// Lista adicional de números enteros para ejercicios combinados.
        /// </summary>
        public static List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };


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

        /// <summary>
        /// Ejercicio 11:
        /// Verifica si todas las palabras en la lista estática "words" tienen más de 3 caracteres.
        /// </summary>
        public static void Ej11()
        {
            bool todasMasDe3 = words.All(w => w.Length > 3);
            Console.WriteLine($"¿Todas las palabras tienen más de 3 caracteres?: {todasMasDe3}");
        }

        /// <summary>
        /// Ejercicio 12:
        /// Encuentra y muestra la primera palabra en la lista estática "words" que empieza con la letra 'b'.
        /// </summary>
        public static void Ej12()
        {
            var primeraB = words.FirstOrDefault(w => w.StartsWith("b"));
            Console.WriteLine($"Primera palabra que empieza con 'b': {primeraB}");
        }

        /// <summary>
        /// Ejercicio 13:
        /// Cuenta cuántas palabras en la lista estática "words" contienen la letra 'e'.
        /// </summary>
        public static void Ej13()
        {
            int cantidad = words.Count(w => w.Contains("e"));
            Console.WriteLine($"Cantidad de palabras que contienen 'e': {cantidad}");
        }

        /// <summary>
        /// Ejercicio 14:
        /// Selecciona todas las palabras en la lista estática "words" y conviértelas a mayúsculas.
        /// </summary>
        public static void Ej14()
        {
            var mayusculas = words.Select(w => w.ToUpper()).ToList();
            Console.WriteLine("Palabras en mayúsculas:");
            Console.WriteLine(string.Join(", ", mayusculas));
        }

        /// <summary>
        /// Ejercicio 15:
        /// Verifica si alguna palabra en la lista estática "words" termina con la letra 'y'.
        /// </summary>
        public static void Ej15()
        {
            bool algunaTerminaY = words.Any(w => w.EndsWith("y"));
            Console.WriteLine($"¿Alguna palabra termina con 'y'?: {algunaTerminaY}");
        }
        /// <summary>
        /// Ejercicio 16:
        /// Combina y ordena de manera ascendente las listas "data" y "moreData".
        /// </summary>
        public static void Ej16()
        {
            var combinados = data.Concat(moreData).OrderBy(n => n).ToList();
            Console.WriteLine("Listas combinadas y ordenadas:");
            Console.WriteLine(string.Join(", ", combinados));
        }

        /// <summary>
        /// Ejercicio 17:
        /// Calcula la suma de todos los números pares en la lista "data".
        /// </summary>
        public static void Ej17()
        {
            int sumaPares = data.Where(n => n % 2 == 0).Sum();
            Console.WriteLine($"Suma de números pares en data: {sumaPares}");
        }

        /// <summary>
        /// Ejercicio 18:
        /// Encuentra y muestra el número más grande en la lista "data".
        /// </summary>
        public static void Ej18()
        {
            int maximo = data.Max();
            Console.WriteLine($"Número más grande en data: {maximo}");
        }

        /// <summary>
        /// Ejercicio 19:
        /// Une las listas "data" y "moreData", eliminando los elementos duplicados.
        /// </summary>
        public static void Ej19()
        {
            var union = data.Union(moreData).ToList();
            Console.WriteLine("Listas unidas sin duplicados:");
            Console.WriteLine(string.Join(", ", union));
        }

        /// <summary>
        /// Ejercicio 20:
        /// Calcula el promedio de la lista "moreData" y selecciona los números en "data" que son mayores a ese promedio.
        /// </summary>
        public static void Ej20()
        {
            double promedio = moreData.Average();
            var mayoresQuePromedio = data.Where(n => n > promedio).ToList();

            Console.WriteLine($"Promedio de moreData: {promedio}");
            Console.WriteLine("Números en data mayores al promedio:");
            Console.WriteLine(string.Join(", ", mayoresQuePromedio));
        }

        /// <summary>
        /// Ejercicio 21:
        /// Cuenta cuántos números en la lista "moreData" son primos.
        /// Usa una función auxiliar para validar si un número es primo.
        /// </summary>
        public static void Ej21()
        {
            int cantidadPrimos = moreData.Count(n => EsPrimo(n));
            Console.WriteLine($"Cantidad de números primos en moreData: {cantidadPrimos}");
        }
        /// <summary>
        /// Función auxiliar que determina si un número es primo.
        /// </summary>
        private static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }

}