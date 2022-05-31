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
            string Name;
            int num;
            Console.WriteLine("Cuantos nombres desea ingresar? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Digite el nombre que desea ingresar: ");
                Name = Console.ReadLine();
                string[] lines =
                {
                    Name
                };

                //Recorrer el arreglo
                foreach (string line in lines)
                {
                    sw.WriteLine(line); //Escribe en el archivo
                }
            }
                sw.Close(); //Se debe cerrar el archivo

                Console.WriteLine("Escribiendo  en el archivo...");
                Console.ReadKey();
            
        }
    }
}
