using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova2
{
    public partial class gabarito : Form
    {
        public gabarito()
        {
            InitializeComponent();
            Lb resultado ="";
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            int tamanhoGabarito = 10;
            int[] questao1 = new int[tamanhoGabarito];
            int[] questao2 = new int[tamanhoGabarito];
            int[] questao3 = new int[tamanhoGabarito];
            int[] questao4 = new int[tamanhoGabarito];
            int[] questao5 = new int[tamanhoGabarito];
            int[] questao6 = new int[tamanhoGabarito];
            int[] questao7 = new int[tamanhoGabarito];
            int[] questao8 = new int[tamanhoGabarito];
            int[] questao9 = new int[tamanhoGabarito];
            int[] questao10 = new int[tamanhoGabarito];

            for (int i = 0; i < tamanhoGabarito; i++)
            {
                int respostaQuestao1 = A;
                int respostaQuestao2 = B;
                int respostaQuestao3 = C;
                int respostaQuestao4 = D;
                int respostaQuestao5 = E;
                int respostaQuestao6 = A;
                int respostaQuestao7 = B;
                int respostaQuestao8 = C;
                int respostaQuestao9 = D;
                int respostaQuestao10 = E;


                if (respostaQuestao1 == respostaQuestao1 )
                {
                    MessageBox.Show("esta certo")
                }
                    
                else
                    questao1[i] = 0;

                if (respostaQuestao2 == 2)
                    questao2[i] = 1;
                else
                    questao2[i] = 0;

                if (respostaQuestao3 == 3)
                    questao3[i] = 1;
                else
                    questao3[i] = 0;

                if (respostaQuestao4 == 4)
                    questao4[i] = 1;
                else
                    questao4[i] = 0;

                if (respostaQuestao5 == 5)
                    questao5[i] = 1;
                else
                    questao5[i] = 0;

                if (respostaQuestao6 == 1)
                    questao6[i] = 1;
                else
                    questao6[i] = 0;

                if (respostaQuestao7 == 2)
                    questao7[i] = 1;
                else
                    questao7[i] = 0;

                if (respostaQuestao8 == 3)
                    questao8[i] = 1;
                else
                    questao8[i] = 0;

                if (respostaQuestao9 == 4)
                    questao9[i] = 1;
                else
                    questao9[i] = 0;

                if (respostaQuestao10 == 5)
                    questao10[i] = 1;
                else
                    questao10[i] = 0;
            }

        }
    }
}
