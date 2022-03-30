using System;

namespace Sopra.Labs.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            int n, n1, valores;

            Console.WriteLine("Introduzca los 8 dígitos de su DNI");
            num = Console.ReadLine();

            CalcularLetraDNI(num);

            Console.WriteLine("Introduzca un número entero");
            n = int.Parse(Console.ReadLine());

            MostrarTablaMultiplicar(n);

            Console.WriteLine("Introduzca un número entero");
            n1 = int.Parse(Console.ReadLine());

            MostrarValores(n1);

            Console.WriteLine("Introduzca el número de valores");
            valores = int.Parse(Console.ReadLine());

            CalcularValores(valores);

        }

        static void MostrarTablaMultiplicar(int n)
        {
            // Utiliza For

            // Utiliza While

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        static void MostrarValores(int n1)
        {
            int saltos;
            int valorfinal;

            Console.WriteLine("Introduzca el valor final");
            valorfinal = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca de cuánto quiere que sea el incremento de los saltos");
            saltos = int.Parse(Console.ReadLine());

            for (int i = n1; i <= valorfinal; i=i+saltos)
            {
                Console.WriteLine($"{i}");
            }
            // desde el valor de inicio al valor final
            // en diferentes saltos
        }

        static void CalcularValores(int valores)
        {
            int a = 20, b, max, min, suma=0;
            int[] array = new int[a];
            Array.Resize(ref array, valores);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduzca un número");
                b = array[i];

            }
            max = array[0];
            min = array[0];
            for (int i = 1; i < valores; i++)
            {
                if (array[i] > max)
                {
                    array[i] = max;
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    array[i] = min;
                }
            }

            Console.WriteLine($"El valor máximo es {max}");
            Console.WriteLine($"El valor mínimo es {min}");

            for (int i = 0; i < valores; i++)
            {
                suma=suma+array[i];
            }

            Console.WriteLine($"El valor de la suma es {suma}");
            Console.WriteLine($"El valor de la media es {suma/valores}");

            // número de valores
            // almacenamos en un array
            // calculos, max, min, media, suma
        }

        static void CalcularLetraDNI(string num)
        {
            // numero % 23
            // posición de Array de las letras

            int digitos, posicion;

            while (num.Length != 8)
            {
                Console.WriteLine("Introduzca los 8 dígitos de su DNI");
            }

            digitos = byte.Parse(num);
            posicion = digitos % 23;

            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            Console.WriteLine($"La letra correspondiente a su DNI es {letras[posicion]}");
        }
    }
}
