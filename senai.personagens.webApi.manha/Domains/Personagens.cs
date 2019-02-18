using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.personagens.webApi.manha.Domains
{
    public class Personagens
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Lancamento { get; set; }
    }
}
