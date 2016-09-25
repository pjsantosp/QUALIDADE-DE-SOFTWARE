using Atendimento.Hospitalar.BO;
using Atendimento.Hospitalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atendimento.Hospitalar.Controllers
{
    public class LoginController : Controller
    {
        private UsuarioAtendenteBO usuarioBO = new UsuarioAtendenteBO(new AtendimentoHospitalarContext());
        private UsuarioAtendente usuario = new UsuarioAtendente();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string login, string senha)
        {
           
            UsuarioAtendente usuario = usuarioBO.VerificaUsuario(login, senha);
            if (usuario == null)
            {
                TempData["Erro"] = "Usuario ou Senha Invalido!";

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Paciente");

            }
        }

    }
}