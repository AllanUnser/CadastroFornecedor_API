using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Data;
using ConsultaCnpj.Models;

namespace ConsultaCnpj.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public AppDbContext _context;

        public UsuarioRepository()
        {
            _context = AppDbContext.GetInstance();
        }

        public Usuario ObterUsuario(string nome, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.NomeUsuario == nome && u.Senha == senha);
        }
    }
}
