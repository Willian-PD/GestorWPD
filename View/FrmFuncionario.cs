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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
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
                //Método de criação do objeto do tipo Funcionario
                Funcionario pess = CriarFuncionarioDoForm();

                //Método para Armazenar Objeto Criado (Funcionario)
                FuncionarioCtrl control = new FuncionarioCtrl();
                if (control.SalvarFuncionarioNoArquivo(pess))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR PESSOA: " + ex.Message);
            }
        }

        private Funcionario CriarFuncionarioDoForm()
        {
            Funcionario p = new Funcionario();

            String cpfSemPontos = mtbCpf.Text.Replace(".", "");
            String cpfSemTracos = cpfSemPontos.Replace("-", "");
            //mtbCpf.Text.Replace(".", "").Replace("-", "");
            p.CPF = cpfSemTracos;
            p.Nome = txbNome.Text;
            p.Idade = (int)nudIdade.Value;
            p.Email = txbEmail.Text;
            p.Endereco = textEndereco.Text;
            p.matricula = txtMatriculaFunc.Text;
            p.salario = (float)Convert.ToDouble(txtSal.Text);

            return p;
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrar.Visible = false;
                    btnAtualizar.Visible = true;
                    mtbCpf.Enabled = false;

                    //Carregar os dados do Objeto Funcionario no formulário
                    Funcionario p = (Funcionario)this.Tag;
                    CarregarFormComDados(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarFormComDados(Funcionario _funcionario)
        {
            mtbCpf.Text = _funcionario.CPF.ToString();
            txbNome.Text = _funcionario.Nome;
            nudIdade.Value = _funcionario.Idade;
            txbEmail.Text = _funcionario.Email;
            textEndereco.Text = _funcionario.Endereco;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
