﻿using Microsoft.AspNetCore.Mvc;
using Service.IServices;

namespace SOA_P1_29AV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonasController : Controller
    {

        private readonly IPersona _persona;

        public PersonasController(IPersona persona)
        {
            _persona = persona;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_persona.GetEmpleado());
        }
    }
}
