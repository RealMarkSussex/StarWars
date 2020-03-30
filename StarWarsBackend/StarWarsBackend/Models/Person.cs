using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsBackend.Models
{
    public class Person
    {
        public string BirthYear { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string EyeColor { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public Homeworld HomeWorld { get; set; }
        public string Mass { get; set; }
        public string Name { get; set; }
        public string SkinColor { get; set; }
        public Species Species { get; set; }
        public List<Starship> Starships { get; set; }
        public List<Vehicle> Vehicles { get; set; }

    }
}
