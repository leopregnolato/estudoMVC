using System.ComponentModel.DataAnnotations;

namespace estudoMVC.DTO
{
    public class CargoDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Departamento { get; set; }  
    }
}