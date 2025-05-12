using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaCnpj.Models;

namespace ConsultaCnpj.Data
{
    //Classe de contexto principal do Entity Framework para interagir com o banco de dados
    public class AppDbContext : DbContext
    {
        // Armazena a única instância de AppDbContext
        private static AppDbContext _instance;

        //Construtor do AppDbContext que usa a string de conexão chamada "AppDbContext" definida no arquivo App.config
        public AppDbContext() : base("AppDbContext") { }

        //Retorna a instância única de AppDbContext
        public static AppDbContext GetInstance()
        {
            //Se ainda não foi criada, cria a instância
            if(_instance == null)
                _instance = new AppDbContext();

            //Retorna a instância exitente ou recém-criada
            return _instance;
        }
        //Representa a tabela de Usuarios no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }

        //Representa a tabela de fornecedores no banco de dados
        public DbSet<Fornecedor> Fornecedores { get; set; }

        //Configuração do mapeamento entre as classes e o banco (opcional, mas útil para personalizações)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Define a tabela no banco como "fornecedores"
            modelBuilder.Entity<Fornecedor>().ToTable("fornecedores");

            base.OnModelCreating(modelBuilder); //Chama a configuração padrão
        }
    }
}
