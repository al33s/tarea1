using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ciclos_y_condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre = "Juan";
            int? num1 = null;
            var persona = new { nombre = "felipe", edad = 20 };
            float valor1, valor2;
            float salario;
            var variable = true;

            dynamic dinamico = 25;
            dinamico = "cadena de caracteres";
            dinamico = false;
            Console.WriteLine(num1);



            valor1 = 15f;
            valor2 = 20f;
            salario = 325.56f;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"la suma de: {valor1} + {valor2} = {valor1 + valor2}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"la multiplicacion de: {valor1} * {valor2} = {valor1 * valor2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"la multiplicacion de: {valor1} - {valor2} = {valor1 - valor2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"la multiplicacion de: {valor1} / {valor2} = {valor1 / valor2}");


            float total = salario * salario * 0.13f;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"elsalario de {persona.nombre} es de {salario} y el IVA es de {salario * 0.13} y el; total va a ser igual a: {total}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nombre: " + persona.nombre + " edad: " + persona.edad);
            Console.WriteLine($"Nombre: {persona.nombre}  edad: {persona.edad}");
            Console.WriteLine("nombre: {0} edad: {1}", persona.nombre, persona.edad);
            Console.ReadLine();

            //Arreglos y matrices


            string[] musicos = new string[] {"ringo","george","paul","jhon"};

            float[] salarios = new float[4];
            salarios[0]= 500;
            salarios[1]= 300;
            salarios[2]= 100;
            salarios[3]= 250;

            float promedio = 0;


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Musico:{musicos[i]} salario: {salarios[i]}");
            }
            Console.WriteLine($"el promedio de salarios es de: {0}",(promedio/=musicos.Length));
            Console.ReadKey();
        }
    }
}
