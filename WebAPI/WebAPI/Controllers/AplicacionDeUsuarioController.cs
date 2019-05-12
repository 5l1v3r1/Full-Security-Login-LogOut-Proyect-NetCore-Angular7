using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AplicacionDeUsuarioController : ControllerBase
    {
        private UserManager<AplicacionDeUsuario> _userManager;
        private UserManager<AplicacionDeUsuario> _signInManager;
        public AplicacionDeUsuarioController(UserManager<AplicacionDeUsuario> userManager, UserManager<AplicacionDeUsuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        //POST : api/AplicacionDeUsuario/Register
        public async Task<Object> PostAplicacionDeUsuario(AplicacionDeUsuarioModel model)
        {
            var aplicacionDeUsuario = new AplicacionDeUsuario()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
            };
            try
            {
                var result = await _userManager.CreateAsync(aplicacionDeUsuario, model.Password);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}