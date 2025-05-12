using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCnpj.Forms.CadastroFornecedores;

namespace ConsultaCnpj.Forms.Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Evento ao clicar no botao Sair
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
                Application.Exit();
            }
        }

        //Evento ao clicar no botao Cadastro Funcionario
        private void btCadastroFuncionario_Click(object sender, EventArgs e)
        {

            var formCadastroFuncionario = new FrmCadastroFuncionario();
            formCadastroFuncionario.ShowDialog();
        }

        //Evento ao clicar no botao Cadastro Fornecedor
        private void btCadastroFornecedor_Click(object sender, EventArgs e)
        {
            var formBuscarCnpj = new FrmBuscaCnpj();
            formBuscarCnpj.ShowDialog();
        }

        //Evento ao clicar no botao Consultar Fornecedor
        private void btConsultaFornecedor_Click(object sender, EventArgs e)
        {
            var formConsultaFornecedor = new FrmConsultarFornecedor();
            formConsultaFornecedor.ShowDialog();
        }

        //Evento ao clicar no botao Consultar Funcionario
        private void btConsultaFuncionario_Click(object sender, EventArgs e)
        {
            var formColsutaFuncionario = new FrmCadastroFuncionario();
            formColsutaFuncionario.ShowDialog();
        }
    }
}
