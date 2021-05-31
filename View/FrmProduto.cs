using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace View
{
    public partial class FrmProduto : Form
    {
        /*public FrmProduto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Método de criação do objeto do tipo Produto
                Produto pess = CriarProdutoDoForm();

                //Método para Armazenar Objeto Criado (Produto)
                ProdutoCtrl control = new ProdutoCtrl();
                if (control.SalvarProdutoNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Produto CriarProdutoDoForm()
        {
            Produto p = new Produto();

            String cpfSemPontos = mtbCpf.Text.Replace(".", "");
            String cpfSemTracos = cpfSemPontos.Replace("-", "");
            //mtbCpf.Text.Replace(".", "").Replace("-", "");
            p.CPF = cpfSemTracos;
            p.Nome = txbNome.Text;
            p.Idade = (int)nudIdade.Value;
            p.Email = txbEmail.Text;
            p.Endereco = textEndereco.Text;

            return p;
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    mtbCpf.Enabled = false;

                    //Carregar os dados do Objeto Produto no formulário
                    Produto p = (Produto)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Produto _pessoa)
        {
            mtbCpf.Text = _pessoa.CPF.ToString();
            txbNome.Text = _pessoa.Nome;
            nudIdade.Value = _pessoa.Idade;
            txbEmail.Text = _pessoa.Email;
            textEndereco.Text = _pessoa.Endereco;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}
