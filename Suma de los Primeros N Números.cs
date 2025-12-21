using System.Linq;

namespace Suma_de_primeros_números;

public static class Program
{
    public static void Main()
    {
       int n;
       int suma = 0;
       int cont = 1;
         Console.Write("Escribe un número entero N: ");
         n = Convert.ToInt32(Console.ReadLine());
         
         do
         {
             suma = suma + cont; 
             cont = cont + 1; 
         } while (cont <= n);
         Console.WriteLine("Suma de 1 a " + n + ": " + suma);
     }
 }

    }
}

