using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPontos.Models;
using SistemaPontos.Services.Core;

namespace SistemaPontos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontoController : ControllerBase
    {
        private readonly IPontoService _pontoService;
        public PontoController(IPontoService pontoService)
        {
            _pontoService = pontoService;
        }
        // GET: api/Ponto
        [HttpGet]
        public IEnumerable<Ponto> Get()
        {
            return _pontoService.ListarPontos();
        }

        // GET: api/Ponto/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Ponto
        [HttpPost]
        public void Post([FromBody] Ponto item)
        {
            _pontoService.Adicionar(new Ponto { Latitude = item.Latitude, Longitude = item.Longitude });
        }

        // PUT: api/Ponto/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
