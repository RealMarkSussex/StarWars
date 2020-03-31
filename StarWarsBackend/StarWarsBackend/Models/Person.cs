using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsBackend.Models
{
    public class Person
    {
        public string Birth_Year { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Eye_Color { get; set; }
        public string Gender { get; set; }
        public string Hair_Color { get; set; }
        public string Height { get; set; }
        public Homeworld Homeworld { get; set; }
        public string Mass { get; set; }
        public string Name { get; set; }
        public string Skin_Color { get; set; }
        public Species Species { get; set; }
        public List<Starship> Starships { get; set; }
        public List<Vehicle> Vehicles { get; set; }

    }
}
