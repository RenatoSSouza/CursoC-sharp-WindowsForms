namespace ProjetoLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome do usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maskedTextBoxPassword.Text.Length == 0 && textBoxUser.Text.Length != 0)
            {
                MessageBox.Show("Digite a senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (maskedTextBoxPassword.Text.Length != 0 && textBoxUser.Text.Length != 0)
            {
                MessageBox.Show("Usuario ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}