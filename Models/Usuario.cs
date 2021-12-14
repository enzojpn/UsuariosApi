﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuarioApi.Models
{
    public class Usuario
    {

        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

    }
}
