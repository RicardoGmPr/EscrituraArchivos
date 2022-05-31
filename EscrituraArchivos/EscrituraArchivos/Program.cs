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

            string[] lines =
            {
                "Esta es la nueva información de la primera línea",
                "Esta es la segunda línea",
                "Fin del texto"
            };
            //Recorrer el arreglo
            foreach(string line in lines)
            {
                sw.WriteLine(line); //Escribe en el archivo
            }
            sw.Close(); //Se debe cerrar el archivo

            Console.WriteLine("Escribiendo  en el archivo...");
            Console.ReadKey();
        }
    }
}
