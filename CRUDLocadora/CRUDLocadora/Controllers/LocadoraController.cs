using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using CRUDLocadora.Models;
using CRUDLocadora.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CRUDLocadora.Controllers
{
    public class LocadoraController : Controller
    {
        private ILocadoraRepository _repositorio;
        public LocadoraController(ILocadoraRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult> Index(FiltroLocadoraModel filtroLocadoraModel)
        {
            filtroLocadoraModel.ListaModelo = await BuscarModelos();
            return View(filtroLocadoraModel);
        }

        [HttpGet]
        public IActionResult CadastrarLocadora()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarLocadora(LocadoraModel locadora)
        {
            _repositorio.CriarLocadora(locadora);
            var modelo = new FiltroLocadoraModel();
            return View("ListarLocadora", modelo);
        }

        [HttpGet]
        public async Task<IActionResult> CadastrarModeloAsync()
        {
            ModeloModel modelo = new ModeloModel();
            modelo.ListaMontadora = await BuscarMontadoras();
            return View(modelo);
        }

        [HttpPost]
        public void CadastrarModelo(ModeloModel modelo)
        {
            _repositorio.CriarModelo(modelo);
        }

        [HttpGet]
        public IActionResult CadastrarMontadora()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarMontadora(MontadoraModel montadora)
        {
            List<MontadoraModel> listaMontadoras = await BuscarMontadoras();
            if (listaMontadoras.Any(x => x.NomeMontadora == montadora.NomeMontadora))
            {
                string mensagem = $"Já existe uma montadora com o nome {montadora.NomeMontadora}.";
                TempData["MensagemAlerta"] = mensagem;
                return RedirectToAction("CadastrarMontadora");
            }
            else
            {
                _repositorio.CriarMontadora(montadora);
                string mensagem = $"Cadastro realizado com sucesso.";
                TempData["MensagemAlerta"] = mensagem;
                return RedirectToAction("CadastrarMontadora");
            }
        }

        [HttpGet]
        public async Task<ActionResult> CadastrarVeiculo()
        {
            VeiculoModel veiculo = new VeiculoModel();
            veiculo.ListaModelo = await BuscarModelos();
            return View(veiculo);
        }

        [HttpPost]
        public void CadastrarVeiculo(VeiculoModel veiculo)
        {
            if (veiculo.IdModelo == 0 || veiculo.IdModelo == null)
            {

            }
            _repositorio.CriarVeiculo(veiculo);
        }

        [HttpGet]
        public async Task<List<ModeloModel>> BuscarModelos()
        {
            var lista = await _repositorio.BuscarModelos();
            return lista;
        }

        [HttpGet]
        public async Task<List<MontadoraModel>> BuscarMontadoras()
        {
            var lista = await _repositorio.BuscarMontadoras();
            return lista;
        }

        [HttpGet]
        public async Task<List<VeiculoModel>> BuscarVeiculos()
        {
            var lista = await _repositorio.BuscarVeiculos();
            return lista;
        }

        [HttpGet]
        public async Task<List<VeiculoModel>> BuscarVeiculos(int idLocadora)
        {
            var lista = await _repositorio.BuscarVeiculos(idLocadora, true);
            return lista;
        }

        [HttpGet]
        public async Task<ActionResult> ListarLocadora(FiltroLocadoraModel filtroLocadoraModel)
        {
            filtroLocadoraModel.ListaModelo = await BuscarModelos();
            return View(filtroLocadoraModel);
        }

        [HttpGet]
        public async Task<ActionResult> ListarModelo(FiltroLocadoraModel filtroLocadoraModel)
        {
            filtroLocadoraModel.ListaMontadora = await BuscarMontadoras();
            return View(filtroLocadoraModel);
        }

        [HttpGet]
        public async Task<ActionResult> ListarVeiculo(FiltroLocadoraModel filtroLocadoraModel)
        {
            filtroLocadoraModel.ListaModelo = await BuscarModelos();
            return View(filtroLocadoraModel);
        }

        [HttpGet]
        public async Task<ActionResult> ListarMontadora(FiltroLocadoraModel filtroLocadoraModel)
        {
            filtroLocadoraModel.ListaMontadora = await BuscarMontadoras();
            return View(filtroLocadoraModel);
        }

        [HttpPost]
        public async Task<ActionResult> BuscarLocadora(FiltroLocadoraModel filtro)
        {
            filtro.ListaLocadora = await _repositorio.BuscarLocadora(filtro);
            return View("ListarLocadora", filtro);
        }

        [HttpPost]
        public async Task<ActionResult> BuscarModelo(FiltroLocadoraModel filtro)
        {
            filtro.ListaModelo = await _repositorio.BuscarModelo(filtro);
            filtro.ListaMontadora = await BuscarMontadoras();
            return View("ListarModelo", filtro);
        }

        [HttpPost]
        public async Task<ActionResult> BuscarMontadora(FiltroLocadoraModel filtro)
        {
            filtro.ListaMontadora = await _repositorio.BuscarMontadora(filtro);
            return View("ListarMontadora", filtro);
        }

        [HttpPost]
        public async Task<ActionResult> BuscarVeiculo(FiltroLocadoraModel filtro)
        {
            filtro.ListaVeiculo = await _repositorio.BuscarVeiculo(filtro);
            return View("ListarVeiculo", filtro);
        }

        [HttpGet]
        public async Task<ActionResult> EditarLocadora(int idLocadora)
        {
            var modelo = await _repositorio.BuscarLocadora(idLocadora);
            modelo.ListaVeiculo = await _repositorio.BuscarVeiculos(idLocadora, false);
            modelo.ListaVeiculosUtilizados = await _repositorio.BuscarVeiculosUtilizados(idLocadora);
            return View("EditarLocadora", modelo);
        }

        [HttpGet]
        public async Task<ActionResult> EditarModelo(int idModelo)
        {
            var modelo = await _repositorio.BuscarModelo(idModelo);
            modelo.ListaMontadora = await _repositorio.BuscarMontadoras();
            return View("EditarModelo", modelo);
        }

        [HttpPost]
        public async Task<ActionResult> EditarModelo(ModeloModel modelo)
        {
            await _repositorio.SalvarModelo(modelo);
            return RedirectToAction("EditarModelo", new { modelo.IdModelo });
        }

        [HttpGet]
        public async Task<ActionResult> ExcluirLocadora(int idLocadora)
        {
            await _repositorio.ExcluirLocadora(idLocadora);
            return RedirectToAction("ListarLocadora");
        }

        [HttpPost]
        public async Task<ActionResult> SalvarCarroNaLocadora(int idLocadora, int idVeiculo)
        {
            await _repositorio.SalvarCarroNaLocadora(idLocadora, idVeiculo);
            return RedirectToAction("EditarLocadora", new { idLocadora });
        }

        [HttpGet]
        public async Task<ActionResult> RemoverCarroNaLocadora(int idLocadora, int idVeiculo)
        {
            await _repositorio.RemoverCarroNaLocadora(idLocadora, idVeiculo);
            return RedirectToAction("EditarLocadora", new { idLocadora });
        }

        [HttpGet]
        public async Task<ActionResult> ExcluirModelo(int idModelo)
        {
            await _repositorio.ExcluirModelo(idModelo);
            return RedirectToAction("ListarModelo");
        }

        [HttpGet]
        public async Task<ActionResult> EditarMontadora(int idMontadora)
        {
            var modelo = await _repositorio.BuscarMontadora(idMontadora);
            return View("EditarMontadora", modelo);
        }

        [HttpPost]
        public async Task<ActionResult> EditarMontadora(MontadoraModel modelo)
        {
            await _repositorio.SalvarMontadora(modelo);
            return RedirectToAction("EditarMontadora", new { modelo.IdMontadora });
        }

        [HttpGet]
        public async Task<ActionResult> ExcluirMontadora(int idMontadora)
        {
            await _repositorio.ExcluirMontadora(idMontadora);
            return RedirectToAction("ListarMontadora");
        }
        [HttpGet]
        public async Task<ActionResult> EditarVeiculo(int idVeiculo)
        {
            var modelo = await _repositorio.BuscarVeiculo(idVeiculo);
            modelo.ListaModelo = await BuscarModelos();
            return View("EditarVeiculo", modelo);
        }

        [HttpPost]
        public async Task<ActionResult> EditarVeiculo(VeiculoModel veiculo)
        {
            await _repositorio.SalvarVeiculo(veiculo);
            return RedirectToAction("EditarVeiculo", new { veiculo.IdVeiculo });
        }

        [HttpGet]
        public async Task<ActionResult> ExcluirVeiculo(int idVeiculo)
        {
            await _repositorio.ExcluirVeiculo(idVeiculo);
            return RedirectToAction("ListarVeiculo");
        }
    }
}
