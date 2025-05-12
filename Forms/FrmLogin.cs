using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCnpj.Factories;
using ConsultaCnpj.Forms.Principal;
using ConsultaCnpj.Repositories;

namespace ConsultaCnpj.Forms.Login
{
    public partial class FrmLogin : Form
    {

        //Construtor do formulário de Login
        public FrmLogin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            //Criação da fábrica de usuários através da fábrica
            var factory = new MySqlRepositoryFactory();

            // Realiza a verificação de login no banco de dados
            var usuarioRepo = factory.CriarUsuarioRepository();

            //Realiza a verificação no banco de dados
            var usuario = usuarioRepo.ObterUsuario(tbUsuario.Text, tbSenha.Text);

            if (usuario != null)
            {
                //Abrir tela principal
                FrmPrincipal telaPrincipal = new FrmPrincipal();
                telaPrincipal.Show();

                //Ocultar a tela de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos!");
            }
        }

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

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            //Ativa o modo de senha com caracteres ocultos
            tbSenha.UseSystemPasswordChar = true;
        }
    }
}
