using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimeex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {

            //Obtem a data de nascimento selecionada pelo usuário no controle dateTimePicker1
            DateTime datanascimento = dtp_nascimento.Value;

            // Obtem a data atual do sistema
            DateTime dataAtual = DateTime.Today;

            // Calcula a idade subtraindo o ano de nascimento do ano atual
            int idade = dataAtual.Year - datanascimento.Year;

            // Verifica se o aniversário já ocorreu este ano
            if (dataAtual < datanascimento.AddYears(idade))
            {
                // Se o aniversário ainda não ocorreu, decrementa a idade em 1
                idade--;
            }

            // Exibe a idade no controle Label com o nome lb_idade
            lb_resultado.Text = "idade: " + idade.ToString();
           
        }
    }
}
