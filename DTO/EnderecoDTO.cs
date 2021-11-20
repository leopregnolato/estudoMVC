using System.ComponentModel.DataAnnotations;
using System;

namespace estudoMVC.DTO
{
    public class EnderecoDTO
    {   
        [Required]
        public int Id { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string NomeLogradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
    }
}