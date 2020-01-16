using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab0.Modelos;
using Lab0.Servicios;

namespace Lab0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ServicioPeli _servicioPeli;
        public MovieController(ServicioPeli servicioPeli)
        {
            _servicioPeli = servicioPeli;
        }

        // GET: api/Movie
        [HttpGet]
        public ActionResult<List<ActuPeliculas>> Get() =>
            _servicioPeli.Get();   

        // POST: api/Movie
        [HttpPost]
        public ActionResult<ActuPeliculas> Post(ActuPeliculas Pelicula)
        {
            _servicioPeli.Post(Pelicula);
            return Ok();
        }
    }
}
