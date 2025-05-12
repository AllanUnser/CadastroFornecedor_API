using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCnpj.Data;
using ConsultaCnpj.Models;
using ConsultaCnpj.Services;
using Newtonsoft.Json.Linq;
using ConsultaCnpj.Repositories;
using System.Diagnostics.Eventing.Reader;

namespace ConsultaCnpj.Forms.CadastroFornecedores
{
    public partial class FrmCadastroFornecedor : Form
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        
        //Construtor para cadastro Manual
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            tbId.BackColor = SystemColors.Control;
            //Instância Singleton do repositório
            _fornecedorRepository = FornecedorRepository.GetInstance();

            //Define o proximo Id
            using (var context = new AppDbContext())
            {
                int proximoId = context.Fornecedores.Any()
                    ? context.Fornecedores.Max(f => f.Id) + 1
                    : 1;

                tbId.Text = proximoId.ToString();
            }
        }

        //Construtor com dados preenchidos via API
        public FrmCadastroFornecedor(JObject dadosCNPJ) : this()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            tbId.BackColor = SystemColors.Control;
            _fornecedorRepository = FornecedorRepository.GetInstance();

            //Preenchimento automático dos campos com dados da API
            tbRazaoSocial.Text = dadosCNPJ["nome"].ToString();
            tbFantasia.Text = dadosCNPJ["fantasia"].ToString();
            tbCnpj.Text = dadosCNPJ["cnpj"].ToString();
            tbCep.Text = dadosCNPJ["cep"].ToString();
            tbLogradouro.Text = dadosCNPJ["logradouro"].ToString();
            tbBairro.Text = dadosCNPJ["bairro"].ToString();
            tbMunicipio.Text = dadosCNPJ["municipio"].ToString();
            tbUf.Text = dadosCNPJ["uf"].ToString();
            tbNumero.Text = dadosCNPJ["numero"].ToString();
            tbTelefone.Text = dadosCNPJ["telefone"].ToString() ;   
            tbEmail.Text = dadosCNPJ["email"].ToString() ;

            //Define o proximo Id
            using (var context = new AppDbContext()) 
            { 
            int proximoId = context.Fornecedores.Any()
                ? context.Fornecedores.Max(f => f.Id) + 1
                : 1;

            tbId.Text = proximoId.ToString();
            }
        }

        //Evento de clique no botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja salvar ?",
                "Salvar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if ( resultado == DialogResult.Yes) 
            { 
                try
                {
                    using (var context = new AppDbContext())
                    {
                        //Cria um novo objeto Fornecedor com os dados dos campos
                        var fornecedor = new Fornecedor
                        {
                            Cnpj = tbCnpj.Text.Trim(),
                            RazaoSocial = tbRazaoSocial.Text.Trim(),
                            Fantasia = tbFantasia.Text.Trim(),
                            Logradouro = tbLogradouro.Text.Trim(),
                            Numero = tbNumero.Text.Trim(),
                            Bairro = tbBairro.Text.Trim(),
                            Municipio = tbMunicipio.Text.Trim(),
                            UF = tbUf.Text.Trim(),
                            Cep = tbCep.Text.Trim(),
                            Telefone = tbTelefone.Text.Trim(),
                            Email = tbEmail.Text.Trim()
                        };

                        //Salva os dados no Banco de dados
                        context.Fornecedores.Add(fornecedor);
                        context.SaveChanges();

                        MessageBox.Show("Fornecedor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); //Fecha o formuláio após salvar
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        

        //Evento de clique no botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair ?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
