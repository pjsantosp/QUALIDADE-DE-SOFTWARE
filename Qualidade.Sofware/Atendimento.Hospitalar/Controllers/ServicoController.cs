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
    public class ServicoController : Controller
    {
        private ServicoBO servicoBO = new ServicoBO(new AtendimentoHospitalarContext());
        public ActionResult Index()
        {
            return View(servicoBO.Selecionar());
        }
        public ActionResult ListaServico()
        {
            return PartialView("_ListaServico", servicoBO.Selecionar());
        }

        public ActionResult Novo()
        {
            return View();
        }

        
        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Novo(Servico servico)
        {
            if (ModelState.IsValid)
            {
                servicoBO.Inserir(servico);
                return RedirectToAction("Index");
            }

            return View(servico);
        }

        public ActionResult Alterar(int? id)
        {
            Servico servico = servicoBO.SelecionarPorId(id.Value);
           
            return View(servico);
        }

        
        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Alterar(Servico servico)
        {
            if (ModelState.IsValid)
            {
                servicoBO.Alterar(servico);
                return RedirectToAction("Index");
            }
            return View(servico);
        }

        public ActionResult Excluir(int? id)
        {
           
            Servico servico = servicoBO.SelecionarPorId(id.Value);
           
            return View(servico);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Excluir(int id)
        {
            servicoBO.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
