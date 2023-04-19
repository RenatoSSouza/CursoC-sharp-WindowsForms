namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonCadastrar = new Button();
            textBoxNumeroCasa = new TextBox();
            textBoxNomeRua = new TextBox();
            textBoxDataNascimento = new TextBox();
            textBoxNumeroDocumento = new TextBox();
            textBoxNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonExcluir = new Button();
            buttonBusca = new Button();
            textBoxBuscaNumeroDocumento = new TextBox();
            labelNumeroCasa = new Label();
            labelNomeRua = new Label();
            labelDataNascimento = new Label();
            labelNomeCompleto = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(510, 437);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonCadastrar);
            tabPage1.Controls.Add(textBoxNumeroCasa);
            tabPage1.Controls.Add(textBoxNomeRua);
            tabPage1.Controls.Add(textBoxDataNascimento);
            tabPage1.Controls.Add(textBoxNumeroDocumento);
            tabPage1.Controls.Add(textBoxNomeCompleto);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(502, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.Location = new Point(6, 152);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(490, 251);
            buttonCadastrar.TabIndex = 10;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.Location = new Point(111, 123);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(385, 23);
            textBoxNumeroCasa.TabIndex = 9;
            // 
            // textBoxNomeRua
            // 
            textBoxNomeRua.Location = new Point(97, 94);
            textBoxNomeRua.Name = "textBoxNomeRua";
            textBoxNomeRua.Size = new Size(399, 23);
            textBoxNomeRua.TabIndex = 8;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(133, 65);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.Size = new Size(363, 23);
            textBoxDataNascimento.TabIndex = 7;
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(154, 35);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(342, 23);
            textBoxNumeroDocumento.TabIndex = 6;
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(111, 6);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(385, 23);
            textBoxNomeCompleto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Número da casa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome da rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Número do documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcluir);
            tabPage2.Controls.Add(buttonBusca);
            tabPage2.Controls.Add(textBoxBuscaNumeroDocumento);
            tabPage2.Controls.Add(labelNumeroCasa);
            tabPage2.Controls.Add(labelNomeRua);
            tabPage2.Controls.Add(labelDataNascimento);
            tabPage2.Controls.Add(labelNomeCompleto);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(502, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.Location = new Point(261, 222);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(225, 180);
            buttonExcluir.TabIndex = 16;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonBusca
            // 
            buttonBusca.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBusca.Location = new Point(15, 222);
            buttonBusca.Name = "buttonBusca";
            buttonBusca.Size = new Size(225, 180);
            buttonBusca.TabIndex = 15;
            buttonBusca.Text = "Busca";
            buttonBusca.UseVisualStyleBackColor = true;
            buttonBusca.Click += buttonBusca_Click;
            // 
            // textBoxBuscaNumeroDocumento
            // 
            textBoxBuscaNumeroDocumento.Location = new Point(141, 19);
            textBoxBuscaNumeroDocumento.Name = "textBoxBuscaNumeroDocumento";
            textBoxBuscaNumeroDocumento.Size = new Size(342, 23);
            textBoxBuscaNumeroDocumento.TabIndex = 14;
            // 
            // labelNumeroCasa
            // 
            labelNumeroCasa.AutoSize = true;
            labelNumeroCasa.Location = new Point(99, 131);
            labelNumeroCasa.Name = "labelNumeroCasa";
            labelNumeroCasa.Size = new Size(12, 15);
            labelNumeroCasa.TabIndex = 13;
            labelNumeroCasa.Text = "-";
            // 
            // labelNomeRua
            // 
            labelNomeRua.AutoSize = true;
            labelNomeRua.Location = new Point(82, 103);
            labelNomeRua.Name = "labelNomeRua";
            labelNomeRua.Size = new Size(12, 15);
            labelNomeRua.TabIndex = 12;
            labelNomeRua.Text = "-";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(119, 75);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(12, 15);
            labelDataNascimento.TabIndex = 11;
            labelDataNascimento.Text = "-";
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(101, 49);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(12, 15);
            labelNomeCompleto.TabIndex = 10;
            labelNomeCompleto.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 131);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 9;
            label6.Text = "Número da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 103);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 8;
            label7.Text = "Nome da rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 74);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 7;
            label8.Text = "Data de nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 22);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 6;
            label9.Text = "Número do documento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 49);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 5;
            label10.Text = "Nome completo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 461);
            Controls.Add(tabControl1);
            MaximumSize = new Size(550, 500);
            MinimumSize = new Size(550, 500);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button buttonCadastrar;
        private TextBox textBoxNumeroCasa;
        private TextBox textBoxNomeRua;
        private TextBox textBoxDataNascimento;
        private TextBox textBoxNumeroDocumento;
        private TextBox textBoxNomeCompleto;
        private Label labelNomeCompleto;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxBuscaNumeroDocumento;
        private Label labelNumeroCasa;
        private Label labelNomeRua;
        private Label labelDataNascimento;
        private Button buttonExcluir;
        private Button buttonBusca;
    }
}