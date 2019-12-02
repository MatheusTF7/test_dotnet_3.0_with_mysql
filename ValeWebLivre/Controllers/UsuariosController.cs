using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValeWebLivre.Models;
//using ValeWebLivre.Models;

namespace ValeWebLivre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ValeWebLivreDbContext _context;
        public UsuariosController(ValeWebLivreDbContext context)
        {
            this._context = context;
        }

        // GET api/usuarios
        [HttpGet("")]
        public ActionResult Getstrings()
        {
            var users = _context.Usuarios.ToList();
            return  Ok(users);
        }

        // GET api/usuarios/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/usuarios
        [HttpPost("")]
        public IActionResult Poststring(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();


            return Ok();
        }

        // PUT api/usuarios/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/usuarios/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}