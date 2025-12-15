using System.Linq;

namespace Programas_Cuatro;

public static class Program
{
    public static void Main()
    {
        Console.Write("Escribe primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Escribe segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe operación (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case '/':
                if (num2 == 0)
                    Console.WriteLine("Error: No se divide entre cero!");


                else
                    Console.WriteLine("Resultado: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Operación no válida!");
                break;
        }





    }


}

