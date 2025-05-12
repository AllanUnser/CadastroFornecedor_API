using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaCnpj.Models
{
    //Representa a tabela "Fornecedores" no banco de daos
    public class Fornecedor
    {
        //chave primária da tabela
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Garante que o ID seja auto-incrementado
        public int Id { get; set; }

        [Required]
        public string Cnpj {  get; set; }

        public string RazaoSocial { get; set; }
        public string Fantasia {  get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
