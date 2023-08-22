using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbDiferente.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = tx_senha.Text;
            string ConfSenha = tx_confSenha.Text;
            
            if(senha == ConfSenha)
            {
                string cpf = tx_cpf.Text;
                string Telefone = tx_telefone.Text;
                string nome = txnome.Text;
                string email = tx_email.Text;
                MessageBox.Show(nome + "\n" + email + "\n " + cpf + "\n " + senha + "\n " + ConfSenha + "\n" + Telefone);
                lbDiferente.Text = "";
            }
            else
            {
                lbDiferente.Text = "Senha incorreta";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txnome.Clear();
            tx_email.Clear();
            tx_cpf.Clear();
            tx_senha.Clear();
            tx_confSenha.Clear();
            tx_telefone.Clear();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastro_de_cliente cl = new Cadastro_de_cliente();
            cl.ShowDialog();
        }
    }
}
