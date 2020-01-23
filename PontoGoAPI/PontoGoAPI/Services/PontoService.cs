using SistemaPontos.Models;
using SistemaPontos.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPontos.Services
{
    public class PontoService : IPontoService
    {
        static List<Ponto> listaPontos = new List<Ponto>();
        public void Adicionar(Ponto item)
        {
            listaPontos.Add(item);
        }

        public IEnumerable<Ponto> ListarPontos()
        {
            return listaPontos;
        }
    }
}
