using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardapio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text=" ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Entrada: " + cboEntrada.Text + ", Prato Principal: " + cboPrato.Text + ", Sobremesa: " + cboSobremesa.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if(mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void LblSobremesa_Click(object sender, EventArgs e)
        {

        }
    }
}
