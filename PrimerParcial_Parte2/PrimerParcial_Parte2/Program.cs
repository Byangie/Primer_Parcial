namespace PrimerParcial_Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números que desea ingresar: ");
            int Numeros = int.Parse(Console.ReadLine());

         
            int num_par = 0;
            int num_impar = 0;
            int Suma_par = 0;
            int Suma_impar = 0;

            for (int i = 1; i <= Numeros; i++) 
            {
                Console.WriteLine("Ingrese cada uno de los números que desea ingresar");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0 )
                {
                    num_par++;
                    Suma_par += numero;
                }
           
                else
                {
                    num_impar++;
                    Suma_impar += numero;
                }

            }
            Console.WriteLine($"Hay {num_par} números pares y {num_impar} números impares");
            Console.WriteLine($"La suma de todos los números pares es {Suma_par}");
            Console.WriteLine($"La suma de todos los números impares es {Suma_impar}");
        }
    }
}
