using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseMatrices
{
    internal class Program
    {
        public static float num1, num2;  
        public static void datos()
        
        {

            Console.WriteLine("digite  num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite num2");
            num2 = int.Parse(Console.ReadLine());
        }



        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            int[,] matrix2 = new[,] { { 0, 1, 2 }, { 2, 3, 6 } };
            float sumatoria = 0;
            Console.WriteLine("**********  MATRIX  **************");
            for (int f = 0; f < 3; f++) //filas
            {
                for (int c = 0; c < 3; c++) //coluimnas
                {
                    Console.WriteLine(matrix[f, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("********** MATRIX 2 **************");
            for (int f = 0; f < 2; f++) //filas
            {
                for (int c = 0; c < 3; c++) //coluimnas
                {
                    Console.WriteLine(matrix2[f, c]);
                    sumatoria += matrix2[f, c];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria  = {0}", sumatoria);
            Console.WriteLine("promedio {0}", sumatoria /= matrix2.Length);




            int salir = 0;
            do
            {
                Console.WriteLine("1- sumar 1");
                Console.WriteLine("2- multiplicar 2");
                Console.WriteLine("3- restar 3"); //siclo tipo menu muestra el texto hasta que terminemos la condicion 
                Console.WriteLine("4- dividir 4");
                Console.WriteLine("digite una opcion: ");
                salir = int.Parse(Console.ReadLine());





                //ESTE ES EL EJERCICO CREO,  NO ENTENDI  BIEN SI ERA ESTE?



                switch (salir)
                {
                    case 1:
                        Console.WriteLine("digite  num1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite num2");
                        num2= int.Parse(Console.ReadLine());
                        Console.WriteLine("total suma {0}", num1+num2);
                        break;
                    case 2:
                        datos();
                        Console.WriteLine("total multiplicacion {0}", num1 * num2);                      
                        break;
                    case 3:
                        datos();
                        Console.WriteLine("total resta {0}", num1 - num2);
                        break;
                    case 4:
                        datos();
                        Console.WriteLine("total division {0}", num1 / num2);
                        break;
                    default:
                        Console.WriteLine("salir :v ");
                        break;
                }
            } while (salir != 4);

            
 

            Console.WriteLine("quires hacerlo?");
            String opcion =(Console.ReadLine());
            while (opcion !="n")
            {
                Console.WriteLine("digite monto para el  prestamo: ");
                float monto = float.Parse(Console.ReadLine());

                Console.WriteLine("digite el salario");
                float salario = float.Parse(Console.ReadLine());

                if ((monto >= 100000) && (salario < 100000))
                {
                    Console.WriteLine("no se le p[uede pagar");
                }
                else if ((monto >= 100000) && (salario >= 100000))
                {
                    Console.WriteLine("se le presta a 6  meses");
                }
                else if ((monto < 100000) && (salario >= 100000))
                {
                    Console.WriteLine("se le presta a 24  meses");
                }
                Console.WriteLine("desea continuar?");
                opcion = (Console.ReadLine());
            }          
            Console.ReadLine();
        }
    }
}
