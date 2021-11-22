using estudoMVC.Data;
using estudoMVC.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace estudoMVC.Controllers
{
    public class RhController : Controller
    {

        private readonly ApplicationDbContext database;

        public RhController(ApplicationDbContext database){
            this.database = database;
        }
        public IActionResult Index(){
            return View();
        }

        public IActionResult Endereco(){
            var endereco = database.Enderecos.Where(e => e.Status == true).ToList();
            return View(endereco);
        }

        public IActionResult NovoEndereco(){
            return View();
        }

        public IActionResult EditarEndereco(int id){
            var endereco = database.Enderecos.First(e => e.Id == id);
            EnderecoDTO enderecoView = new EnderecoDTO();
            enderecoView.Id = endereco.Id;
            enderecoView.Logradouro = endereco.Logradouro;
            enderecoView.NomeLogradouro = endereco.NomeLogradouro;
            enderecoView.Numero = endereco.Numero;
            enderecoView.Bairro = endereco.Bairro;
            enderecoView.Cidade = endereco.Cidade;
            enderecoView.Estado = endereco.Estado;
            return View(enderecoView);
        }

        public IActionResult Cargo(){
            var cargo = database.Cargos.Where(c => c.Status == true).ToList();
            return View(cargo);
        }

        public IActionResult NovoCargo(){
            return View();
        }

         public IActionResult EditarCargo(int id){
            var cargo = database.Cargos.First(c => c.Id == id);
            CargoDTO cargoView = new CargoDTO();
            cargoView.Id = cargo.Id;
            cargoView.Nome = cargo.Nome;
            cargoView.Departamento = cargo.Departamento;
            return View(cargoView);
        }
    }
}