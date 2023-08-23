namespace Agos22Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el ejercicio que desea ejecutar:\n 1. Suma de tres enteros y su promedio\n 2. Área y perimetro de un rectángulo\n 3. Porcentaje población\n");
            int op;
            op = int.Parse(Console.ReadLine());
            switch (op) {
                case 1: 
                    Console.WriteLine("Promedio");
                    Class1.ExecuteExecersice1();
                    break;
                case 2:
                    Console.WriteLine("Área y perimetro");
                    Class1.ExecuteExecersice2();
                    break;
                case 3:
                    Console.WriteLine("Porcentaje poblacional");
                    Class1.ExecuteExecersice3();
                    break;
            
            }


               
        
        }

            
        }
    }
