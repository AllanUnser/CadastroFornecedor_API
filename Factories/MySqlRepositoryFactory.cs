using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Repositories;

namespace ConsultaCnpj.Factories
{
    //Implementação concreta da fábrica de repositórios para o banco de dados MySQL
    public class MySqlRepositoryFactory : IRepositoryFactory
    {
        //Retorna uma instância do repositório de Usuario específico para o MySQL
        public IUsuarioRepository CriarUsuarioRepository()
        {
            //Retorna a implementação concreta de UsuarioRepository
            return new UsuarioRepository();
        }
    }
}
