using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraArchivos
{
    public class Vehiculo
    {
        public int año;
        public string marca;
        public string color;

        public Vehiculo(int año, string marca, string color)
        {
            this.año = año;
            this.marca = marca;
            this.color = color;
        }
    }
}
