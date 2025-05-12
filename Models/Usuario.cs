using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCnpj.Models
{
    //Representa a tabela "Usuairos" no banco de dados
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }
}
