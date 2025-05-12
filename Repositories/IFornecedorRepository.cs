using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Models;
using Org.BouncyCastle.Asn1.Cmp;

namespace ConsultaCnpj.Repositories
{
    public interface IFornecedorRepository
    {
        //Adicona um fornecedor no banco de dados
        void Adicionar(Fornecedor fornecedor);

        //Atualiza um fornecedor existente no banco de dados
        void Atualizar(Fornecedor fornecedor);

        //Remove um fornecedor do banco de dados no seu ID
        void Excluir (int id);

        //Busca um fornecedor específico pelo ID
        Fornecedor ObterPorId (int id);

        //Retorna uma lista com todos os fornecedores cadastrados
        IEnumerable<Fornecedor> ObterTodos();
    }
}
