using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecosologic.Models;

namespace Ecosologic.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orcamento()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetEstruturaOrcamento()
        {
            EcoSolContexto _contexto = new EcoSolContexto();
            PedidoOrcamento _pedidoOrcamento = new PedidoOrcamento();

            List<UF> _listuf = _contexto.UFS.Where(x=> ! String.IsNullOrEmpty( x.Descricao)).ToList();
            _pedidoOrcamento.ListUF = _listuf;

            return Json(_pedidoOrcamento);
        }

          [HttpPost]
        public ActionResult GravarPedidoOrcamento(PedidoOrcamento _pedidoOrcamento)
        {
            EcoSolContexto _contexto = new EcoSolContexto();

            _pedidoOrcamento.DataPedido = DateTime.Now;
            _pedidoOrcamento.Estado = _pedidoOrcamento.UFSelecionado.Descricao;

             _contexto.PedidosOrcamento.Add(_pedidoOrcamento);
             _contexto.SaveChanges();

            return Json(_pedidoOrcamento);
        }
    }
}