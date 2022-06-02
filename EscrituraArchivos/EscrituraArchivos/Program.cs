using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no existe lo creará
            //Si ya existe, esxribirá en él
            int num;
            Console.WriteLine("Cuantos carros desea ingresar? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Carro #" + i);
                Console.WriteLine("¿Que año es?");
                int newAño = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Que marca es?");
                string newMarca = Console.ReadLine();
                Console.WriteLine("¿Que color es?");
                string newColor = Console.ReadLine();
                Vehiculo vehiculo = new Vehiculo(newAño, newMarca, newColor);
                Console.Clear();
                sw.WriteLine(vehiculo.año + " " + vehiculo.marca + " " + vehiculo.color); //Escribe en el archivo
                
            }
                sw.Close(); //Se debe cerrar el archivo

                Console.WriteLine("Escribiendo  en el archivo...");
                Console.ReadKey();
            
        }
    }
}
