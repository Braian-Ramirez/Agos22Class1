using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agos22Class1
{
    internal class Class1
    {
        public static void ExecuteExecersice1()
        {
            Console.WriteLine("Ingrese tres números enteros:");
                int a, b, c, ResultadoSuma, ResultadoPromedio;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            ResultadoSuma = a + b + c;
            ResultadoPromedio = ResultadoSuma / 3;
            Console.WriteLine("La suma resultante es: " + ResultadoSuma);    
            Console.WriteLine("El promedio de los números ingresados es: " +  ResultadoPromedio);
        }
        public static void ExecuteExecersice2()
        {
            Console.WriteLine("Ingrese la base y la altura del rectangulo:");
            int altura, cimiento, perimetro, area;
            cimiento = int.Parse(Console.ReadLine());
            altura = int.Parse(Console.ReadLine());
            perimetro = (cimiento * 2) + (altura * 2);
            area = cimiento * altura;
            Console.WriteLine("El área del rectangulo es: " +  area + " El perimetro del rectangulo es: " + perimetro);
        }
        public static void ExecuteExecersice3()
        {
            Console.WriteLine("Ingrese el número total de hombres y de mujeres que hay en su grupo: ");
            int hombres, mujeres, poblacion; 
            int porcentajeHombres, porcentajeMujeres;
            hombres = int.Parse(Console.ReadLine());
            mujeres = int.Parse(Console.ReadLine());
            poblacion = hombres + mujeres;
            porcentajeHombres = (hombres * 100) / poblacion ;
            porcentajeMujeres = mujeres * 100 / poblacion ;
            Console.WriteLine("El porcentaje de hombres es de: %" + porcentajeHombres + " El porcentaje de mujeres es: %" +  porcentajeMujeres);
        } 
    }
}
