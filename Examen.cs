using System.Linq;

namespace Examen;

public static class Program
{
    public static void Main()
    {
        int opcion;

        do
        {

            Console.WriteLine(" MENÚ DE OPERACIONES MATEMÁTICAS ");
            Console.WriteLine("1) Calcular el séxtuple de un número");
            Console.WriteLine("2) Calcular el doble del cubo de un número");
            Console.WriteLine("3) Calcular el producto por 7 de un número");
            Console.WriteLine("4) Cerrar aplicación");
            Console.Write("Elige una opción del 1 al 4: ");


            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un número entero para su séxtuple: ");
                    int num1 = int.Parse(Console.ReadLine());
                    int sextuple = num1 * 6;
                    Console.WriteLine(" El séxtuple de {num1} es: {sextuple}");
                    break;
                case 2:
                    Console.Write("Ingresa un número entero para el doble de su cubo: ");
                    int num2 = int.Parse(Console.ReadLine());
                    int dobleCubo = 2 * (num2 * num2 * num2);
                    Console.WriteLine("El doble del cubo de {num2} es: {dobleCubo}");
                    break;
                case 3:
                    Console.Write("Ingresa un número entero para multiplicarlo por 7: ");
                    int num3 = int.Parse(Console.ReadLine());
                    int porSiete = num3 * 7;
                    Console.WriteLine("El resultado de {num3} × 7 es: {porSiete}");
                    break;
                case 4:
                    Console.WriteLine("¡Aplicación cerrada correctamente! ¡Nos vemos!");
                    break;
                default:
                    Console.WriteLine("¡Opción incorrecta! solo del 1 al 4");
                    break;
            }
        } while (opcion != 4);
    }
}






