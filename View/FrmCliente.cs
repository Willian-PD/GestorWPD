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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
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
                //Método de criação do objeto do tipo Cliente
                Cliente pess = CriarClienteDoForm();

                //Método para Armazenar Objeto Criado (Cliente)
                ClienteCtrl control = new ClienteCtrl();
                if (control.SalvarClienteNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Cliente CriarClienteDoForm()
        {
            Cliente p = new Cliente();

            String cpfSemPontos = mtbCpf.Text.Replace(".", "");
            String cpfSemTracos = cpfSemPontos.Replace("-", "");
            //mtbCpf.Text.Replace(".", "").Replace("-", "");
            p.CPF = cpfSemTracos;
            p.codigo = txtCodigoCli.Text;
            p.Nome = txbNome.Text;
            p.Idade = (int)nudIdade.Value;
            p.Email = txbEmail.Text;
            p.Endereco = textEndereco.Text;
            p.preferencias = txtPrefCliente.Text;
            p.totalDeCompras = Convert.ToInt32(txtTotalCompCli.Text);

            return p;
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    mtbCpf.Enabled = false;

                    //Carregar os dados do Objeto Cliente no formulário
                    Cliente p = (Cliente)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Cliente _cliente)
        {
            mtbCpf.Text = _cliente.CPF.ToString();
            txtCodigoCli.Text = _cliente.codigo;
            txbNome.Text = _cliente.Nome;
            nudIdade.Value = _cliente.Idade;
            txbEmail.Text = _cliente.Email;
            textEndereco.Text = _cliente.Endereco;
            txtPrefCliente.Text = _cliente.preferencias;
            txtTotalCompCli.Text = _cliente.totalDeCompras.ToString();
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

        }
    }
}
