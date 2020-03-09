using System;
using ApiHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiHub.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase {
        [HttpPost]
        public ActionResult Post([FromBody] Auth auth) {

            var usuario = new Usuario();
            usuario.Nome = "admin";
            usuario.Email = "admin@gmail.com";
            usuario.Senha = "123";
            usuario.DataNascimento = new DateTime(1997, 10, 26);

            try {
                if (auth.Username == usuario.Email) {
                    if (auth.Password == usuario.Senha) {
                        return Ok(usuario);
                    } else {
                        return Unauthorized();
                    }
                } else {
                    return NotFound();
                }
            } catch (Exception) {
                return BadRequest();
            }
        }
    }
}
