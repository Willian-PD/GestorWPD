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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
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
                //Método de criação do objeto do tipo Compra
                Compra pess = CriarCompraDoForm();

                //Método para Armazenar Objeto Criado (Compra)
                CompraCtrl control = new CompraCtrl();
                if (control.SalvarCompraNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Compra CriarCompraDoForm()
        {
            Compra p = new Compra();

            String valor = txtValorCompra.Text;

            p.codigo = mtbCpf.Text;
            p.fornecedor = txbNome.Text;
            p.totalDeProdutos = (int)nudIdade.Value;
            p.tipoDeProduto = txbEmail.Text;
            p.local = textEndereco.Text;
            p.valor = (float)Convert.ToDouble(valor);

            return p;
        }

        private void FrmCadCompra_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    mtbCpf.Enabled = false;

                    //Carregar os dados do Objeto Compra no formulário
                    Compra p = (Compra)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Compra _compra)
        {
            mtbCpf.Text = _compra.codigo.ToString();
            txbNome.Text = _compra.fornecedor;
            nudIdade.Value = _compra.totalDeProdutos;
            txbEmail.Text = _compra.tipoDeProduto;
            textEndereco.Text = _compra.local;
            txtValorCompra.Text = Convert.ToString(_compra.valor);
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

        private void mtbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
