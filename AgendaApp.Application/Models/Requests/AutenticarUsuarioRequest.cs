﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Application.Models.Requests
{
    public class AutenticarUsuarioRequest
    {
        public required string Email { get; set; }
        public required  string Senha { get; set; }
    }
}