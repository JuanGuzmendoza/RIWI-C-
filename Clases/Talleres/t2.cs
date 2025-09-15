using System;
using Helpers.validaciones;

namespace CTalleres.Talleres
{
    /// <summary>
    /// Clase que contiene la serie de ejercicios básicos de C# para práctica de condicionales y validaciones.
    /// </summary>
    public static class T2
    {
        /// <summary>
        /// Ejercicio 1:
        /// Escribe un programa que pida al usuario un número y muestre si es par o impar usando una condición if.
        /// </summary>
        public static void Ej1()
        {
            Console.WriteLine("=== Ejercicio 1: Número Par o Impar ===");
            int n1 = Validaciones.validateNumber("Ingrese un número entero:\n> ");
            if (n1 % 2 == 0)
            {
                Console.WriteLine($"El número {n1} es par.");
            }
            else
            {
                Console.WriteLine($"El número {n1} es impar.");
            }
            Console.WriteLine("=======================================");
        }

        /// <summary>
        /// Ejercicio 2:
        /// Escribe un programa que pida al usuario que ingrese su nombre. 
        /// Luego, verifica si el nombre ingresado no es nulo ni está vacío. 
        /// Si el nombre es válido, muestra un mensaje de bienvenida; de lo contrario, muestra un mensaje de error.
        /// </summary>
        public static void Ej2()
        {
            string nombre = Validaciones.validarContenido("Ingrese su nombre:\n> ");
            Console.WriteLine($"¡Bienvenido, {nombre}!");
        }

        /// <summary>
        /// Ejercicio 3:
        /// Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad usando if-else.
        /// </summary>
        public static void Ej3()
        {
            int edad = Validaciones.validateNumber("Ingrese su edad:\n> ");
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
        }

        /// <summary>
        /// Ejercicio 4:
        /// Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) 
        /// y muestre el nombre del día correspondiente usando switch.
        /// </summary>
        public static void Ej4()
        {

            Console.WriteLine("=== Ejercicio 4: Día de la Semana ===");

            while (true)
            {
                int dia = Validaciones.validateNumber("Ingrese un número del 1 al 7 para determinar el día de la semana:\n> ");
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("Día no válido");
                        continue;
                }
            }

        }

        /// <summary>
        /// Ejercicio 5:
        /// Escribe un programa que pida al usuario su equipo de nacionalidad. 
        /// Si es colombiana debe decirle que es nativo del país y si no, debe decir que es extranjero (usar operador ternario).
        /// </summary>
        public static void Ej5()
        {
            string equipo = Validaciones.validarContenido("Ingrese su equipo de nacionalidad:\n> ");
            string mensaje = (equipo.Trim().ToLower() == "colombiana") ? "Es nativo del país." : "Es extranjero.";
            Console.WriteLine(mensaje);
        }

        /// <summary>
        /// Ejercicio 6:
        /// Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando if-else.
        /// </summary>
        public static void Ej6()
        {

            int n1 = Validaciones.validateNumber("Ingrese el primer número:\n> ");
            int n2 = Validaciones.validateNumber("Ingrese el segundo número:\n> ");
            int n3 = Validaciones.validateNumber("Ingrese el tercer número:\n> ");

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"El número mayor es: {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"El número mayor es: {n2}");
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine($"El número mayor es: {n3}");
            }
            else
            {
                Console.WriteLine("Hay números iguales, no hay un único mayor.");

            }
        }

        /// <summary>
        /// Ejercicio 7:
        /// Escribe un programa que pida al usuario que ingrese una contraseña. 
        /// Verifica si la contraseña no es nula ni está vacía. 
        /// Si es válida, muestra un mensaje indicando que la contraseña es aceptada; 
        /// de lo contrario, muestra un mensaje indicando que no puede estar en blanco.
        /// </summary>
        public static void Ej7()
        {
            string password = Validaciones.validarContenido("Ingrese su contraseña:\n> ");
            Console.WriteLine("Contraseña aceptada.");
        }

        /// <summary>
        /// Ejercicio 8:
        /// Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del mes correspondiente usando switch.
        /// </summary>
        public static void Ej8()
        {

            int mes;

            while (true)
            {
                mes = Validaciones.validateNumber("Ingrese un número del 1 al 12 para determinar el mes del año:\n> ");

                if (mes > 12)
                {
                    Console.WriteLine("Mes no válido");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
            }

        }

        /// <summary>
        /// Ejercicio 9:
        /// Escribe un programa que pida al usuario una calificación numérica 
        /// y muestre la letra correspondiente (A, B, C, D, F) usando if-else.
        /// </summary>
        public static void Ej9()
        {
            int calificación;
            while (true)
            {
                calificación = Validaciones.validateNumber("Ingrese una calificación numérica (0-100):\n> ");


                if (calificación > 100 || calificación < 0)
                {
                    Console.WriteLine("Calificación no válida. Debe estar entre 0 y 100.");
                    continue;
                }
                else
                {
                    break;
                }
            }



            if (calificación >= 90 && calificación <= 100)
            {
                Console.WriteLine("Calificación: A");
            }
            else if (calificación >= 80 && calificación < 90)
            {
                Console.WriteLine("Calificación: B");
            }
            else if (calificación >= 70 && calificación < 80)
            {
                Console.WriteLine("Calificación: C");
            }
            else if (calificación >= 60 && calificación < 70)
            {
                Console.WriteLine("Calificación: D");
            }
            else if (calificación >= 0 && calificación < 60)
            {
                Console.WriteLine("Calificación: F");
            }
            else
            {
            }
        }

        /// <summary>
        /// Ejercicio 10:
        /// Escribe un programa que pida al usuario un carácter y determine si es una vocal o consonante usando switch.
        /// </summary>
        public static void Ej10() {

            char caracter;
            while (true)
            {
                string input = Validaciones.validarContenido("Ingrese un carácter:\n> ");
                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un solo carácter alfabético.");
                    continue;
                }
                else
                {
                    caracter = char.ToLower(input[0]);
                    break;
                }
            }


            switch (caracter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"El carácter '{caracter}' es una vocal.");
                    break;
                default:
                    Console.WriteLine($"El carácter '{caracter}' es una consonante.");
                    break;
            }
        }

        /// <summary>
        /// Ejercicio 11:
        /// Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes usando if-else.
        /// </summary>
        public static void Ej11() {

            int n1 = Validaciones.validateNumber("Ingrese el primer número:\n> ");
            int n2 = Validaciones.validateNumber("Ingrese el segundo número:\n> ");

            if (n1 == n2)
            {
                Console.WriteLine("Los números son iguales.");
            }
            else
            {
                Console.WriteLine("Los números son diferentes.");
            }
         }

        /// <summary>
        /// Ejercicio 12:
        /// Escribe un programa que solicite al usuario que ingrese su dirección. 
        /// Verifica que no sea nula, vacía o solo espacios en blanco. 
        /// Si es válida, muestra un mensaje de confirmación; de lo contrario, muestra un error.
        /// </summary>
        public static void Ej12() { 
            string direccion = Validaciones.validarContenido("Ingrese su dirección:\n> ");
            Console.WriteLine("Dirección aceptada.");
        }

        /// <summary>
        /// Ejercicio 13:
        /// Escribe un programa que pida al usuario un número 
        /// y determine si es positivo, negativo o cero usando if-else.
        /// </summary>
        public static void Ej13() { 
            int numero = Validaciones.validateNumber("Ingrese un número:\n> ");
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }

        /// <summary>
        /// Ejercicio 14:
        /// Escribe un programa que pida al usuario una letra 
        /// y determine si es una vocal usando if-else.
        /// </summary>
        public static void Ej14() { 
            char letra;
            while (true)
            {
                string input = Validaciones.validarContenido("Ingrese una letra:\n> ");
                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un solo carácter alfabético.");
                    continue;
                }
                else
                {
                    letra = char.ToLower(input[0]);
                    break;
                }
            }

            if ("aeiou".Contains(letra))
            {
                Console.WriteLine($"La letra '{letra}' es una vocal.");
            }
            else
            {
                Console.WriteLine($"La letra '{letra}' no es una vocal.");
            }
        }

        /// <summary>
        /// Ejercicio 15:
        /// Escribe un programa que pida al usuario una temperatura en grados Celsius 
        /// y determine si es caliente (>30), templada (10-30) o fría (<10) usando if-else.
        /// </summary>
        public static void Ej15() { 
            int temperatura = Validaciones.validateNumber("Ingrese la temperatura en grados Celsius:\n> ");
            if (temperatura > 30)
            {
                Console.WriteLine("La temperatura es caliente.");
            }
            else if (temperatura >= 10 && temperatura <= 30)
            {
                Console.WriteLine("La temperatura es templada.");
            }
            else
            {
                Console.WriteLine("La temperatura es fría.");
            }
        }

        /// <summary>
        /// Ejercicio 16:
        /// Escribe un programa que pida al usuario un año 
        /// y determine si es un año bisiesto usando if-else.
        /// </summary>
        public static void Ej16() { 
            int año = Validaciones.validateNumber("Ingrese un año:\n> ");
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
        }

        /// <summary>
        /// Ejercicio 17:
        /// Escribe un programa que pida al usuario que ingrese un valor. 
        /// Verifica si el valor no es nulo, vacío o solo espacios. 
        /// Si es válido, muestra el valor; de lo contrario, pide uno válido.
        /// </summary>
        public static void Ej17() {
            string valor = Validaciones.validarContenido("Ingrese un valor:\n> ");
            Console.WriteLine($"Valor ingresado: {valor}");
         }

        /// <summary>
        /// Ejercicio 18:
        /// Escribe un programa que pida al usuario un número del 1 al 7 
        /// y determine si es un día laborable o de fin de semana usando switch.
        /// </summary>
        public static void Ej18() { 
            int dia;
            while (true)
            {
                dia = Validaciones.validateNumber("Ingrese un número del 1 al 7 para determinar si es día laborable o fin de semana:\n> ");
                if (dia < 1 || dia > 7)
                {
                    Console.WriteLine("Número no válido. Debe estar entre 1 y 7.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (dia)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Es un día laborable.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Es fin de semana.");
                    break;
            }
        }
    }
}
