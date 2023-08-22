using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (aprovado.Checked)
            {
                sexo = aprovado.Text;
            }
            else if (recuperacao.Checked)
            {
                sexo = recuperacao.Text;
            }
            MessageBox.Show(sexo);
        }
    }
}
