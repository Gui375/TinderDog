using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinderDog.Domain.Models;
using TinderDog.Domain.ValueObject;

namespace TinderDog.Domain.Entity
{
    public class Dono
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int DonoId { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public List<Animal> Animais { get; set; }


    }
}
