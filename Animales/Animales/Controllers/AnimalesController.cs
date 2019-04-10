using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animales.Models;

namespace Animales.Controllers
{
    public class AnimalesController : Controller
    {
        List<Animal> animales = new List<Animal>
        {
                new Animal(1,"Dassie", "Mamífero","Procavia capensis","~/images/dassie.jpeg"),
                new Animal(2,"Perro", "Mamífero","Canis lupus familiaris","~/images/dog.jpeg"),
                new Animal(3,"Dormouse", "Mamífero","Gliridae","~/images/dormouse.jpeg"),
                new Animal(4, "Erizo", "Mamífero", "Erinaceus europaeus", "~/images/erizo.jpeg"),
                new Animal(5,"Zorro", "Mamífero","Vulpes vulpes","~/images/fox.jpg"),
                new Animal(6,"Nutria", "Mamífero","Lutra lutra","~/images/nutria.jpg"),
                new Animal(7,"Pingüino", "Ave","Spheniscus","~/images/pingu.jpg"),
                new Animal(8,"Oso perezoso", "Mamífero","Folivora","~/images/sloth.jpeg"),
                new Animal(9,"Tortuga", "Reptil","Testudine","~/images/turtle.jpg"),
        };



        public IActionResult Index(string searchString, string clase)
        {

            if (string.IsNullOrEmpty(searchString))
            {
                searchString = "";
            }

            if (string.IsNullOrEmpty(clase))
            {
                clase = "";
            }

            List<Animal> animalesFiltros = new List<Animal>();

         
            animalesFiltros = animales.Where(x => x.Clase.Contains(clase)).ToList();
            animalesFiltros = animalesFiltros.Where(x=> x.Nombre.ToLower().Contains(searchString.ToLower())).ToList();


            return View(animalesFiltros);
        }
        public IActionResult Mamifero()
        {
            List<Animal> mamiferos = new List<Animal>();

            //foreach (Animal animal in animales.)
            //{
            //    if (animal.Clase == "Mamífero")
            //    {
            //        mamiferos.Add(animal);
            //    }
            //}


           Animal zorro = animales.Single(x => x.Nombre == "Zorro");
           mamiferos = animales.Where(x => x.Clase == "Mamífero").ToList();
           mamiferos = mamiferos.OrderByDescending(x => x.Nombre).ToList();

            return View(mamiferos);
        }
        public IActionResult Reptiles()
        {
            return View(animales.Where(x => x.Clase == "Reptil").ToList());
        }
        public IActionResult Peces()
        {
            return View(animales);
        }
        public IActionResult Aves()
        {
            return View(animales);
        }
        public IActionResult Anfibios()
        {
            return View(animales);
        }
    }
}