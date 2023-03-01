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
	public class AlumnosController : ControllerBase
	{
		
		[HttpGet]
        public ActionResult<List<Alumno>> GetAlumnos()
        {
            return new List<Alumno>(){
                new Alumno(){ Id = 1, Nombre = "Antenor Lopez May", Edad = 23},
                new Alumno(){ Id = 2, Nombre = "Felipe", Edad = 22}
                };
        }
	}
}