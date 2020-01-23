using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPontos.Models
{
    public class Ponto
    {
        public Ponto()
        {
            Id = Guid.NewGuid();
            DTPonto = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DTPonto { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
