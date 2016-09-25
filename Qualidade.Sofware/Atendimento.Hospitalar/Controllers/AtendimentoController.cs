using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Paleativa = Atendimento.Hospitalar.Models;
using  PaleativaBO = Atendimento.Hospitalar.BO;

namespace Atendimento.Hospitalar.Controllers
{
    public class AtendimentoController : Controller
    {
        private PaleativaBO.AtendimentoBO atendimentoBO = new PaleativaBO.AtendimentoBO(new Paleativa.AtendimentoHospitalarContext());
        private PaleativaBO.PacienteBO pacienteBO = new PaleativaBO.PacienteBO(new Paleativa.AtendimentoHospitalarContext());
        private PaleativaBO.ServicoBO servicoBO = new PaleativaBO.ServicoBO(new Paleativa.AtendimentoHospitalarContext());
        public ActionResult Index()
        {
            return View(atendimentoBO.Selecionar());
        }
        public ActionResult Novo()
        {
            ViewBag.paciente = new SelectList(pacienteBO.Selecionar(), "pacienteId", "Nome");
            ViewBag.servico = new SelectList(servicoBO.Selecionar(), "servicoId", "Descricao");
            return View();
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Novo(Paleativa.Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                atendimentoBO.Inserir(atendimento);
                return RedirectToAction("Index");
            }
            return View(atendimento);
        }
        public ActionResult Alterar(int? id)
        {
            
            Paleativa.Atendimento atendimento = atendimentoBO.SelecionarPorId(id.Value);
            
            return View(atendimento);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Alterar(Paleativa.Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                atendimentoBO.Alterar(atendimento);
                return RedirectToAction("Index");
            }
            return View(atendimento);
        }

        public ActionResult Excluir(int? id)
        {
           
            Paleativa.Atendimento atendimento = atendimentoBO.SelecionarPorId(id.Value);
           
            return View(atendimento);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atendimentoBO.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
