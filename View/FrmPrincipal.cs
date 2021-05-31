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

namespace View
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            itsRelogio.Text = DateTime.Now.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();

            FrmLogin login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                User user = (User)login.Tag;

                itsUsuarioLogado.Text = user.Usuario;

                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void itsListarUsuarios_Click(object sender, EventArgs e)
        {
            FrmPessoa f = new FrmPessoa();

            f.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCliente f = new FrmCliente();

            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmProduto f = new FrmProduto();

            f.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmEstoque f = new FrmEstoque();

            f.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmVenda f = new FrmVenda();

            f.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmCompra f = new FrmCompra();

            f.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();

            f.ShowDialog();
        }
    }
}
