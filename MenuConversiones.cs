using System.Linq;

namespace Menú_de_Conversiones;

public static class Program
{
    public static void Main()
    {
        int opcion;
        double valor, res;

        do
        {

            Console.WriteLine("MENÚ CONVERSIONES ");
            Console.WriteLine("1. Celsius → Fahrenheit");
            Console.WriteLine("2. km/h → m/s");
            Console.WriteLine("3. Pesos → Dólares");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Escribe Celsius: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    res = (valor * 9 / 5) + 32;
                    Console.WriteLine("Fahrenheit: " + res);
                    break;
                case 2:
                    Console.Write("Escribe km/h: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    res = valor / 3.6;
                    Console.WriteLine("m/s: " + res);
                    break;
                case 3:
                    Console.Write("Escribe pesos: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    res = valor / 20; 
                    Console.WriteLine("Dólares: " + res);
                    break;
                case 4:
                    Console.WriteLine("Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida!");
                    break;
            }
        } while (opcion != 4); 

    }

}

