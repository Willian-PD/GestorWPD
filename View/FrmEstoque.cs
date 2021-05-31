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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
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
                //Método de criação do objeto do tipo Estoque
                Estoque pess = CriarEstoqueDoForm();

                //Método para Armazenar Objeto Criado (Estoque)
                EstoqueCtrl control = new EstoqueCtrl();
                if (control.SalvarEstoqueNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Estoque CriarEstoqueDoForm()
        {
            Estoque p = new Estoque();

            p.secao = txtSecaoEst.Text;
            p.local = txtLocalEst.Text;
            p.totalDeProdutos = (int)txtTotalDeProd.Value;

            return p;
        }

        private void FrmCadEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    txtSecaoEst.Enabled = false;

                    //Carregar os dados do Objeto Estoque no formulário
                    Estoque p = (Estoque)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Estoque _cliente)
        {
            txtSecaoEst.Text = _cliente.secao.ToString();
            txtLocalEst.Text = _cliente.local;
            txtTotalDeProd.Value = _cliente.totalDeProdutos;
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
