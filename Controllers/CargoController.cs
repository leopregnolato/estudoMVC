using System.Linq;
using estudoMVC.Data;
using estudoMVC.DTO;
using estudoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace estudoMVC.Controllers
{
    public class CargoController : Controller
    {
        private readonly ApplicationDbContext database;

        public CargoController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CargoDTO cargoTemp){
            if(ModelState.IsValid){
                Cargo cargo = new Cargo();
                cargo.Nome = cargoTemp.Nome;
                cargo.Departamento = cargoTemp.Departamento;
                cargo.Status = true;
                database.Cargos.Add(cargo);
                database.SaveChanges();
                return RedirectToAction("Cargo","Rh");
            }else{
                return View("../Rh/NovoCargo");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(CargoDTO cargoTemp){
            if(ModelState.IsValid){
                var cargo = database.Cargos.First(c => c.Id == cargoTemp.Id);
                cargo.Nome = cargoTemp.Nome;
                cargo.Departamento = cargoTemp.Departamento;
                database.SaveChanges();
                return RedirectToAction("Cargo","Rh");
            }else{
                return View("../Rh/EditarCargo");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int id){
            if(id > 0){
                var cargo = database.Cargos.First(e => e.Id == id);
                cargo.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Cargo","Rh");
        }        
    }
}