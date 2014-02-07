using System;
using System.Windows.Forms;
using VerificaForcaSenha;

namespace VerificarForcaDaSenha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

             private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != string.Empty)
            {
                ChecaForcaSenha verifica = new ChecaForcaSenha();
                int placar;
                ForcaDaSenha forca;

                placar = verifica.geraPontosSenha(txtSenha.Text);
                forca = verifica.GetForcaDaSenha(txtSenha.Text);

                lblPontosSenha.Text = placar.ToString() + " Pontos";
                lblForcaSenha.Text = forca.ToString();
            }
        }
    }
}
