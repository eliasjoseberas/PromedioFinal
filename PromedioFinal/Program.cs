using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P1, P2, P3, P4, prom, examen, trabajoF, promFinal;

            Console.WriteLine("Ingrese la primera calificacion");
            P1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda calificacion");
            P2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera calificacion");
            P3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta calificacion");
            P4 = float.Parse(Console.ReadLine());

            prom = ((P1 + P2 + P3 + P4) / 4) * 0.55f;

            Console.WriteLine("Ingrese la  calificacion de su examen");

            examen = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion del trabajo final");

            trabajoF = float.Parse(Console.ReadLine());

            promFinal = (prom + (examen * 0.30f)) + (trabajoF * 0.15f);

            if (promFinal > 90)
            {
                Console.WriteLine("Felicitaciones, obtuviste una A");
            }
            else
            {
                if (promFinal > 80)
                {
                    Console.WriteLine("Felicitaciones, obtuviste una B");
                }
                else
                {
                    if (promFinal > 75)
                    {
                        Console.WriteLine("Felicitaciones, obtuviste una C");
                    }
                    else
                    {
                        if (promFinal > 69)
                        {
                            Console.WriteLine("Felicitaciones, obtuviste una D");
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, debes esforzarte mas para la proxima vez");
                        }
                    }
                }
            }

            Console.WriteLine("El promedio final es: " + promFinal);


        }
    }
}
