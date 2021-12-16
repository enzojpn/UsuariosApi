﻿using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UsuarioApi.Data.Requests;
using UsuarioApi.Models;
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
           Token token =  _loginService.LogaUsuario(request);
             
            if (token == null) return Unauthorized();
            
            return Ok(token.Value);

        }

    }
}
