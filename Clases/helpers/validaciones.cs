using System;


namespace Helpers.validaciones
{
   /// <summary>
   /// Colección de métodos estáticos para validar entradas por consola.
   /// </summary>
   public static class Validaciones
   {


       /// <summary>
       /// Solicita al usuario una entrada por consola y valida que no esté vacía ni contenga sólo espacios.
       /// </summary>
       /// <param name="mensaje">Texto que se muestra al usuario antes de leer la entrada.</param>
       /// <returns>La cadena ingresada por el usuario que no está vacía ni es solamente espacios en blanco.</returns>
       /// <remarks>
       /// Este método repite la petición hasta que el usuario ingrese una cadena no vacía. Devuelve el
       /// primer valor válido ingresado.
       /// </remarks>
       public static string validarContenido(string mensaje){
           while (true)
           {
               Console.Write(mensaje);
               string? input = Console.ReadLine();            
               if (string.IsNullOrWhiteSpace(input)){
                   Console.WriteLine("⚠️ Entrada inválida. Por favor no puede dejar el campo vacio.");
               }else{
                   return input;
               }
           }
       }

       /// <summary>
       /// Solicita al usuario una entrada por consola y valida que corresponda a un número entero.
       /// </summary>
       /// <param name="mensaje">Texto que se muestra al usuario antes de leer la entrada.</param>
       /// <returns>El número entero ingresado por el usuario.</returns>
       /// <remarks>
       /// El método utiliza <c>int.TryParse</c> para validar la entrada. Si la conversión falla,
       /// se muestra un mensaje de error y se pide la entrada nuevamente.
       /// </remarks>
       public static int validateNumber(string mensaje){
           while (true)
           {
               int num;
               Console.Write(mensaje);
               string? input = Console.ReadLine();            
               if (int.TryParse(input, out num)){
                   return num;
               }
               else{
                   Console.WriteLine("⚠️ Entrada inválida. Por favor ingrese un número entero.");
               }
           }
       }

       public static double validateDouble(string mensaje){
           while (true)
           {
               double num;
               Console.Write(mensaje);
               string? input = Console.ReadLine();            
               if (double.TryParse(input, out num)){
                   return num;
               }
               else{
                   Console.WriteLine("⚠️ Entrada inválida. Por favor ingrese un número flotante.");
               }
           }
       }

   }

}