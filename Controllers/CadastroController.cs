using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioApi.Data.Dtos;

namespace UsuarioApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {

        [HttpPost]
        public IActionResult adicionar(CreateUsuarioDto createDto)
        {
            return Ok();
        }
    }
}
