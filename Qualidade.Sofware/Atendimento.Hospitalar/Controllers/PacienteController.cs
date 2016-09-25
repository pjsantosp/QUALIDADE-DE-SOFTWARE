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
    public class PacienteController : Controller
    {
        private PacienteBO pacienteBO = new PacienteBO(new AtendimentoHospitalarContext());


        public ActionResult Index()
        {
            return View(pacienteBO.Selecionar());
        }
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Novo(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                pacienteBO.Inserir(paciente);
                return RedirectToAction("Index");
            }

            return View(paciente);
        }


        public ActionResult Alterar(int? id)
        {
            Paciente paciente = pacienteBO.SelecionarPorId(id.Value);

            return View(paciente);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Alterar(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                pacienteBO.Alterar(paciente);
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        public ActionResult Excluir(int? id)
        {
            Paciente paciente = pacienteBO.SelecionarPorId(id.Value);
            return View(paciente);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ConfirmarExclusao(int id)
        {
            Paciente paciente = pacienteBO.SelecionarPorId(id);
            pacienteBO.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
