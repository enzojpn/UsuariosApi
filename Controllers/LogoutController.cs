using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers

{
    [Route("[controller]")]
    [ApiController]
    public class LogoutController :ControllerBase
    {
        private LogoutService _logoutService;
        public LogoutController(LogoutService logoutService)
        {
            _logoutService = logoutService;
        }

        [HttpPost]
        public IActionResult Logout()
        {
            Result result = _logoutService.deslogaUsuario();
            if (result.IsFailed) return Unauthorized();
            return Ok();
        }

    }
}
