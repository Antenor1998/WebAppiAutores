using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Controllers
{
    [ApiController]
    [Route("api/V1/[controller]")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>(){
                new Autor(){ Id = 1, Nombre = "Antenor Lopez May"},
                new Autor(){ Id = 2, Nombre = "Felipe"}
                };
        }
    }
}