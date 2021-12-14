﻿using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioApi.Data.Requests;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService =  loginService;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
           Result result =  _loginService.LogaUsuario(request);
            if (result.IsFailed) return Unauthorized();
            return Ok();

        }

    }
}
