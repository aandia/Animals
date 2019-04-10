using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animales.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string Especie { get; set; }
        public string Imagen { get; set; }

        public Animal(int id, string nombre, string clase, string especie, string imagen)
        {
            Id = id;
            Nombre = nombre;
            Clase = clase;
            Especie = especie;
            Imagen = imagen;
        }

        public Animal()
        {
        }
    }
}
