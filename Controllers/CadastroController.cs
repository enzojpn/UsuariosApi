using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Data.Requests;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;
        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastroUsuario(CreateUsuarioDto createDto)
        {

            string result = _cadastroService.CadastroUsuario(createDto);
            if (string.IsNullOrWhiteSpace(result)) return StatusCode(500);
            return Ok(result);
        }

        [HttpGet("/Ativa")]
        public IActionResult AtivarContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result resultado = _cadastroService.AtivaContaUsuario(request);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}
