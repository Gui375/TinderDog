using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinderDog.Domain.ValueObject
{
    public class Parceiro
    {
        public int AnimalIdF { get; set; }
        public int AnimalIdM { get; set; }

        public Animal animalM { get; set; }
        public Animal animalF { get; set; }

        public DateTime AnimalDate { get; set; }
        public string Obs { get; set; } 

    }
}
