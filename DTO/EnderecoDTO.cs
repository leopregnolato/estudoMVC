using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace estudoMVC.DTO
{
    public class EnderecoDTO
    {   
        [Required]
        public int Id { get; set; }

        
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        
        public string Logradouro { get; set; }
        
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        
        public string NomeLogradouro { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]           
        public int Numero { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]              
        public string Bairro { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
           
        public string Cidade { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]         
        public string Estado { get; set; }
    }
}