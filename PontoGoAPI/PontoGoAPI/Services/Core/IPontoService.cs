using SistemaPontos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPontos.Services.Core
{
    public interface IPontoService
    {
        IEnumerable<Ponto> ListarPontos();
        void Adicionar(Ponto item);
    }
}
