using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Modulo_API.Controllers
{
    
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("ApresentarUsuario")]
        public IActionResult ApresentarUsuario(string nome)
        {
            var mensagem = $"Olá, {nome}, seja bem vindo!";
            return Ok(mensagem);
            
        }
    }
}