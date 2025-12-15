using System.Linq;

namespace Contador_positivo_y_negativo;

public static class Program
{
    public static void Main()
    {
        int positivos = 0;
        int negativos = 0;
        double num;
        Console.WriteLine("Escribe un numero:");


        while (true)
        {
            num = Convert.ToDouble(Console.ReadLine());

            if (num == 0)
                break;
            else if (num > 0)
                positivos++;
            else
                negativos++;
        }

        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);

    }
}

