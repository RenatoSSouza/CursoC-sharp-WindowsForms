namespace ProjetoLogin
{
    partial class Login
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
            labelLogin = new Label();
            labelUser = new Label();
            labelPassword = new Label();
            textBoxUser = new TextBox();
            maskedTextBoxPassword = new MaskedTextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(92, 33);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(195, 86);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(19, 180);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(50, 15);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuário:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(19, 210);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(42, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Senha:";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(75, 177);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(243, 23);
            textBoxUser.TabIndex = 3;
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Location = new Point(75, 206);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new Size(243, 23);
            maskedTextBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(12, 244);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(359, 83);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 374);
            Controls.Add(buttonLogin);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(labelLogin);
            MaximumSize = new Size(399, 413);
            MinimumSize = new Size(399, 413);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUser;
        private Label labelPassword;
        private TextBox textBoxUser;
        private MaskedTextBox maskedTextBoxPassword;
        private Button buttonLogin;
    }
}