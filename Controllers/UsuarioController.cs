﻿using Microsoft.AspNetCore.Mvc;

namespace MODULOAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString(),
            };

            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo(a)!";
            return Ok(new { mensagem });
        }
    }
}
