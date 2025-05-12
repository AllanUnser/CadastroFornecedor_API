using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Models;

namespace ConsultaCnpj.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario ObterUsuario(string nome, string senha);
    }
}
