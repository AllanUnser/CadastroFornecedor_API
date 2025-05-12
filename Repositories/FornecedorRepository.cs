using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Data;
using ConsultaCnpj.Models;

namespace ConsultaCnpj.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        //Instância única da classe
        private static FornecedorRepository _instance;

        //contexto do banco de dados
        private readonly AppDbContext _context;

        //Construtor privado para impedir múltiplas instâncias
        private FornecedorRepository()
        {
            //Obtém instância úncia do contexto
           _context = AppDbContext.GetInstance();
        }

        //Método para acessar a instância única do repositório
        public static FornecedorRepository GetInstance()
        {
            if(_instance == null)
                _instance = new FornecedorRepository();
            return _instance;
        }

        //Adiciona um fornecedor do banco de dados
        public void Adicionar(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
        }

        //Atualiza um fornecedor Existente ou o adiciona se não existir
        public void Atualizar(Fornecedor fornecedor)
        {
            _context.Fornecedores.AddOrUpdate(fornecedor);
            _context.SaveChanges();
        }

        //Remove um fornecedor do banco de dados com base no ID Informado
        public void Excluir(int id)
        {
            var fornecedor = _context.Fornecedores.Find(id);
            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                _context.SaveChanges();
            }
        }

        // Busca um fornecedor específico pelo ID
        public Fornecedor ObterPorId(int id)
        {
            return _context.Fornecedores.Find(id);
        }

        //Busca todos os fornecedores cadastrados
        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _context.Fornecedores.ToList();
        }
    }
}
