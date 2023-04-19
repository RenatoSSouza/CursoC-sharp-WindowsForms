using CadastroBiblioteca;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;

        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNomeCompleto.Text, textBoxNumeroDocumento.Text, Convert.ToDateTime(textBoxDataNascimento.Text), textBoxNomeRua.Text, Convert.ToUInt32(textBoxNumeroCasa.Text));
            baseDeDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show($"Usuário {textBoxNomeCompleto.Text} cadastrado com sucesso!");
            textBoxNomeCompleto.Text = string.Empty;
            textBoxNumeroDocumento.Text = string.Empty;
            textBoxDataNascimento.Text = string.Empty;
            textBoxBuscaNumeroDocumento.Text = string.Empty;
            textBoxNomeRua.Text = string.Empty;
            textBoxNumeroCasa.Text = string.Empty;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemoverPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
                MessageBox.Show($"Usuário {textBoxNomeCompleto.Text} encontrado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Usuário não localizado!");
            }
            
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisaPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = listaPessoas[0].NumeroDaCasa.ToString();
            }
            else
            {
                MessageBox.Show($"Usuário não localizado!");
            }
        }
    }
}