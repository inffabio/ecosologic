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

        public ActionResult QuemSomos()
        {
            return View();
        }

        public ActionResult AnalisePedidoOrcamento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetEstruturaOrcamento()
        {
            EcoSolContexto _contexto = new EcoSolContexto();
            PedidoOrcamento _pedidoOrcamento = new PedidoOrcamento();

            List<UF> _listuf = _contexto.UFS.Where(x => !String.IsNullOrEmpty(x.Descricao)).ToList();
            _pedidoOrcamento.ListUF = _listuf;

            //List<UF> _listuf = new List<UF>();
            //_listuf.Add(new UF { Descricao = "Rio de Janeiro", Sigla = "RJ", UFId = 1 });
            //_pedidoOrcamento.ListUF = _listuf;

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

          [HttpPost]
          public ActionResult GetListaPedidosOrcamento()
          {
              EcoSolContexto _contexto = new EcoSolContexto();

              List<PedidoOrcamento> _listPedidoOrcamento = new List<PedidoOrcamento>();

              _listPedidoOrcamento = (from lst in _contexto.PedidosOrcamento select lst).ToList();

              return Json(_listPedidoOrcamento);
          }
    }
}