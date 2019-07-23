using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    public class UsuarioController: Controller
    {
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
