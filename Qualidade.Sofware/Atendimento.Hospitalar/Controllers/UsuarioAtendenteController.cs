using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Atendimento.Hospitalar.Models;
using Atendimento.Hospitalar.BO;

namespace Atendimento.Hospitalar.Controllers
{
    public class UsuarioAtendenteController : Controller
    {
        private UsuarioAtendenteBO usuarioAtendenteBO = new UsuarioAtendenteBO(new AtendimentoHospitalarContext());
        public ActionResult Index()
        {
            return View(usuarioAtendenteBO.Selecionar());
        }
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Novo(UsuarioAtendente usuarioAtendente)
        {
            if (ModelState.IsValid)
            {
                usuarioAtendenteBO.Inserir(usuarioAtendente);
                return RedirectToAction("Index");
            }

            return View(usuarioAtendente);
        }

        public ActionResult Alterar(int? id)
        {
           
            UsuarioAtendente usuarioAtendente = usuarioAtendenteBO.SelecionarPorId(id.Value);
          
            return View(usuarioAtendente);
        }

     
        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Alterar(UsuarioAtendente usuarioAtendente)
        {
            if (ModelState.IsValid)
            {
                usuarioAtendenteBO.Alterar(usuarioAtendente);
                return View(usuarioAtendente);
            }
            return View(usuarioAtendente);
        }

        
      
    }
}
