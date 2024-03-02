using System.Globalization;

namespace PrimerParcial_Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba de cada metodo dentro del programa
            Console.WriteLine("Prueba del Programa");
            Console.WriteLine(Calculadora.Sumar(3, 4));
            Console.WriteLine(Calculadora.Restar(4, 4));
            Console.WriteLine(Calculadora.Multiplicar(4, 10));
            Console.WriteLine(Calculadora.Dividir(9, 3));
            Console.WriteLine("\n");
            //Prueba piediendole al usuario los datos

            //suma
            Console.WriteLine("Prueba del Programa con datos del usuario");
            Console.WriteLine("Suma");
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            int Suma = Calculadora.Sumar(num1, num2);
            Console.WriteLine($"La suma de los dos numeros ingresados es {Suma}");

            //Resta
            Console.WriteLine("Resta");

            Console.WriteLine("Ingrese el primer número");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num4 = int.Parse(Console.ReadLine());
            int Resta = Calculadora.Restar(num3, num4);
            Console.WriteLine($"La resta de los dos numeros ingresados es {Resta}");

            //Multiplicacion
            Console.WriteLine("Multiplicacion");

            Console.WriteLine("Ingrese el primer número");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num6 = int.Parse(Console.ReadLine());
            int Multiplicacion = Calculadora.Multiplicar(num5, num6);
            Console.WriteLine($"La multiplicación de los dos numeros ingresados es {Multiplicacion}");

            //Division
            Console.WriteLine("Division");

            Console.WriteLine("Ingrese el primer número");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num8 = int.Parse(Console.ReadLine());
            int Division = Calculadora.Dividir(num7, num8);
            Console.WriteLine($"La division de los dos numeros ingresados es {Division}");

            try
            {
                Console.WriteLine($"División: {Calculadora.Dividir(num7, num8)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Ejecución del programa terminada");
            }
        }
    }
}
