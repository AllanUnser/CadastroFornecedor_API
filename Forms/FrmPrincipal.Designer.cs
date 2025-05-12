namespace ConsultaCnpj.Forms.Principal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastroFuncionario = new System.Windows.Forms.Button();
            this.btConsultaFuncionario = new System.Windows.Forms.Button();
            this.btCadastroFornecedor = new System.Windows.Forms.Button();
            this.btConsultaFornecedor = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEM VINDO!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistema de Cadatro de Fornecedores";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btCadastroFuncionario
            // 
            this.btCadastroFuncionario.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroFuncionario.Location = new System.Drawing.Point(18, 101);
            this.btCadastroFuncionario.Name = "btCadastroFuncionario";
            this.btCadastroFuncionario.Size = new System.Drawing.Size(181, 52);
            this.btCadastroFuncionario.TabIndex = 3;
            this.btCadastroFuncionario.Text = "Cadastro Funcionários";
            this.btCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btCadastroFuncionario.Click += new System.EventHandler(this.btCadastroFuncionario_Click);
            // 
            // btConsultaFuncionario
            // 
            this.btConsultaFuncionario.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaFuncionario.Location = new System.Drawing.Point(239, 101);
            this.btConsultaFuncionario.Name = "btConsultaFuncionario";
            this.btConsultaFuncionario.Size = new System.Drawing.Size(181, 52);
            this.btConsultaFuncionario.TabIndex = 4;
            this.btConsultaFuncionario.Text = "Consulta Funcionários";
            this.btConsultaFuncionario.UseVisualStyleBackColor = true;
            this.btConsultaFuncionario.Click += new System.EventHandler(this.btConsultaFuncionario_Click);
            // 
            // btCadastroFornecedor
            // 
            this.btCadastroFornecedor.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroFornecedor.Location = new System.Drawing.Point(18, 181);
            this.btCadastroFornecedor.Name = "btCadastroFornecedor";
            this.btCadastroFornecedor.Size = new System.Drawing.Size(181, 52);
            this.btCadastroFornecedor.TabIndex = 5;
            this.btCadastroFornecedor.Text = "Cadastro Fornecedor";
            this.btCadastroFornecedor.UseVisualStyleBackColor = true;
            this.btCadastroFornecedor.Click += new System.EventHandler(this.btCadastroFornecedor_Click);
            // 
            // btConsultaFornecedor
            // 
            this.btConsultaFornecedor.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultaFornecedor.Location = new System.Drawing.Point(239, 181);
            this.btConsultaFornecedor.Name = "btConsultaFornecedor";
            this.btConsultaFornecedor.Size = new System.Drawing.Size(181, 52);
            this.btConsultaFornecedor.TabIndex = 6;
            this.btConsultaFornecedor.Text = "Consultar Fornecedor";
            this.btConsultaFornecedor.UseVisualStyleBackColor = true;
            this.btConsultaFornecedor.Click += new System.EventHandler(this.btConsultaFornecedor_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(155, 247);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(124, 46);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 305);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btConsultaFornecedor);
            this.Controls.Add(this.btCadastroFornecedor);
            this.Controls.Add(this.btConsultaFuncionario);
            this.Controls.Add(this.btCadastroFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastroFuncionario;
        private System.Windows.Forms.Button btConsultaFuncionario;
        private System.Windows.Forms.Button btCadastroFornecedor;
        private System.Windows.Forms.Button btConsultaFornecedor;
        private System.Windows.Forms.Button btSair;
    }
}