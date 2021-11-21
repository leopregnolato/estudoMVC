using estudomvc.Models;
using estudoMVC.Data;
using estudoMVC.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace estudoMVC.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly ApplicationDbContext database;

        public EnderecoController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(EnderecoDTO enderecoTemp){
            if(ModelState.IsValid){
                Endereco endereco = new Endereco();
                endereco.Logradouro = enderecoTemp.Logradouro;
                endereco.NomeLogradouro = enderecoTemp.NomeLogradouro;
                endereco.Numero = enderecoTemp.Numero;
                endereco.Bairro = enderecoTemp.Bairro;
                endereco.Cidade = enderecoTemp.Cidade;
                endereco.Estado = enderecoTemp.Estado;
                endereco.Status = true;
                database.Enderecos.Add(endereco);
                database.SaveChanges();
                return RedirectToAction("Endereco","Rh");
            }else{
                return View("../Rh/NovoEndereco");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(EnderecoDTO enderecoTemp){
            if(ModelState.IsValid){
                var endereco = database.Enderecos.First(e => e.Id == enderecoTemp.Id);
                endereco.Logradouro = enderecoTemp.Logradouro;
                endereco.NomeLogradouro = enderecoTemp.NomeLogradouro;
                endereco.Numero = enderecoTemp.Numero;
                endereco.Bairro = enderecoTemp.Bairro;
                endereco.Cidade = enderecoTemp.Cidade;
                endereco.Estado = enderecoTemp.Estado;
                database.SaveChanges();
                return RedirectToAction("Endereco","Rh");
            }else{
                return View("../Rh/EditarCategoria");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int id){
            if(id > 0){
                var endereco = database.Enderecos.First(e => e.Id == id);
                endereco.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Endereco","Rh");
        }
    }
}
