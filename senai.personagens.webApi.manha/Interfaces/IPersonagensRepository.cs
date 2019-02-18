using senai.personagens.webApi.manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.personagens.webApi.manha.Interfaces
{
    interface IPersonagensRepository
    {
        List<Personagens> Listar();

        void Cadastrar(Personagens personagem);
    }
}
