using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Repositories;

namespace ConsultaCnpj.Factories
{
    //Interface para Abstract Factory de repositórios
    //Define contratos para obterrepositórios específicos, promovendo desacoplamento e flexibilidade
    public interface IRepositoryFactory
    {
        //Retorna uma instância de repositório para a entidade Usuario
        IUsuarioRepository CriarUsuarioRepository();

    }

}
