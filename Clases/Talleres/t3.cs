using System;
using Helpers.validaciones;

namespace CTalleres.Talleres
{
    /// <summary>
    /// Clase que contiene la serie de ejercicios básicos de C# para práctica de condicionales y validaciones.
    /// </summary>
    public static class T3
    {
        /// <summary>
        /// 1. Imprimir los números del 1 al 100 usando un ciclo for.
        /// </summary>
        public static void Ej1()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine($"Numero: {i}");
            }
        }

        /// <summary>
        /// 2. Solicitar un número entero positivo e imprimir todos los números pares desde 1 hasta ese número usando un ciclo for.
        /// </summary>
        public static void Ej2()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");
            for (int i = 1; i < numero + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Número par: {i}");
                }
            }
        }

        /// <summary>
        /// 3. Pedir un número entero positivo e imprimir la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.
        /// </summary>
        public static void Ej3()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(@$"{numero} x {i} = {numero * i}");
            }
        }

        /// <summary>
        /// 4. Generar un número aleatorio entre 1 y 100. El usuario debe adivinar el número. Indicar si es muy alto, muy bajo o correcto. Seguir hasta acertar usando un ciclo do-while.
        /// </summary>
        public static void Ej4()
        {
            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101);
            int intento;

            do
            {
                intento = Validaciones.validateNumber("Adivina el número (entre 1 y 100):\n> ");
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Muy bajo. Intenta de nuevo.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Muy alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                }
            } while (intento != numeroSecreto);
        }

        /// <summary>
        /// 5. Solicitar un número entero positivo e imprimir todos los números impares desde ese número hasta 1 usando un ciclo while.
        /// </summary>
        public static void Ej5()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");

            int indice = 1;
            while (indice < numero)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine($"Número impar: {numero}");
                }
                indice++;
            }

        }

        /// <summary>
        /// 6. Solicitar al usuario una contraseña. Mientras no sea "secreta", seguir pidiendo la contraseña usando un ciclo while.
        /// </summary>
        public static void Ej6()
        {

            string? contrasena;
            do
            {
                Console.Write("Ingrese la contraseña:\n> ");
                contrasena = Console.ReadLine();
                if (contrasena != "secreta")
                {
                    Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
                }
            } while (contrasena != "secreta");
            Console.WriteLine("¡Contraseña correcta!");
        }

        /// <summary>
        /// 7. Solicitar un número entero positivo e imprimir la secuencia de Fibonacci hasta ese número usando un ciclo for.
        /// </summary>
        public static void Ej7()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");
            int a = 0, b = 1, siguiente;

            Console.WriteLine("Secuencia de Fibonacci:");
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(a);
                siguiente = a + b;
                a = b;
                b = siguiente;
            }
        }

        /// <summary>
        /// 8. Solicitar un número entero positivo e imprimir si es primo o no usando un ciclo for.
        /// </summary>
        public static void Ej8()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");
            bool esPrimo = true;

            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
                Console.WriteLine($"El número {numero} es primo.");
            else
                Console.WriteLine($"El número {numero} no es primo.");
        }


        /// <summary>
        /// 9. Solicitar una palabra y luego imprimir cada letra en una línea separada usando un ciclo foreach.
        /// </summary>
        public static void Ej9()
        {
            string palabra = Validaciones.validarContenido("Ingrese una palabra:\n> ");
            foreach (char letra in palabra)
            {
                Console.WriteLine(letra);
            }
        }

        /// <summary>
        /// 10. Solicitar un número entero positivo e imprimir la suma de todos los números desde 1 hasta ese número usando un ciclo for.
        /// </summary>
        public static void Ej10()
        {
            int numero = Validaciones.validateNumber("Ingrese un número entero positivo:\n> ");
            int suma = 0;

            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de todos los números desde 1 hasta {numero} es: {suma}");
        }
    }
}
