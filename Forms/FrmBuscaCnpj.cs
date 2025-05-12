using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCnpj.Services;

namespace ConsultaCnpj.Forms.CadastroFornecedores
{
    //Formuário responsável por buscar CNPJ e redirecionar para o cadastro
    public partial class FrmBuscaCnpj : Form
    {
        public FrmBuscaCnpj()
        {
            //Inicia os componentes visuais da tela
            InitializeComponent(); 
            //Remove bordas da tela
            FormBorderStyle = FormBorderStyle.None;
        }

        //Evento executado ao apertar o botão sair
        private void btSair_Click(object sender, EventArgs e)
        {
            //Fecha o formulário
            this.Close();
        }

        //Evento executado ao apertar o botão Continuar
        private async void btContinuar_Click(object sender, EventArgs e)
        {
            //Lê o CNPJ digitado. Permitindo o uso de caracteres
            string cnpj = tbCNPJ.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "");

            // Verifica se o campo CNPJ foi preenchido ou se tem no 14 caracteres
            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
            {
                MessageBox.Show("CNPJ inválido! Digite um CNPJ com 14 dígitos.");
            }

            //Pergunta se o usuário deseja consultar a API
            DialogResult resultado = MessageBox.Show(
                "Deseja preencher os dados automatico via API ?",
                "Preenchimento Automático",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //Verifica se o usuário escolheu buscar os dados pela API 
            if (resultado == DialogResult.Yes)
            {
                //Cria uma instância do serviço responsável po consultar o CNPJ na API
                var service = new CnpjService();

                try
                {
                    //Chama o método assíncrono que consulta os dados do CNPJ
                    var dadosCNPJ = await service.ConsultarCnpjAsync(cnpj);

                    //Verifica se a resposta da API indica erro
                    if (dadosCNPJ["status"].ToString() == "ERROR")
                    {
                        MessageBox.Show("CNPJ inválido ou não encontrado!");
                        //Interrompe o fluxo para evitar abrir a tela com dados inválidos
                        return;
                    }
                    //Abre o formulário de cadastro preenchido
                    var FrmCadastro = new FrmCadastroFornecedor(dadosCNPJ);
                    FrmCadastro.ShowDialog();
                }
                catch (Exception ex)
                {
                    //Trata exceções genéricas e exibe mensagem de erro
                    MessageBox.Show("Erro ao consultar CNPJ: " + ex.Message);
                }
            }
            else
            {
                //Abre o formulário de cadastro manual
                var FrmCadastro = new FrmCadastroFornecedor();
                FrmCadastro.ShowDialog();
            }

            this.Hide(); //Oculta a tela de Busca de CNPJ
        }
    }
}
