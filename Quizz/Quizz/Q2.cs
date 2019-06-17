using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Q2 : Form
    {
        int resultado;
        public Q2(int r)
        {
            InitializeComponent();
            lbl_question.Text = "The winner of a competition won a spot on the game.\n His name is?";
            resultado = r;
            btn_val.Enabled = false;
            lbl_resultado.Text = resultado.ToString();
        }

        private void btn_kurt_Click(object sender, EventArgs e)
        {
            resultado++;
            btn_kurt.Enabled = false;
            btn_toto.Enabled = false;
            btn_ynazuka.Enabled = false;
            btn_kurt.BackColor = Color.Green;
            btn_toto.BackColor = Color.Red;
            btn_ynazuka.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_resultado.Text = resultado.ToString();
        }

        private void btn_toto_Click(object sender, EventArgs e)
        {
            btn_kurt.Enabled = false;
            btn_toto.Enabled = false;
            btn_ynazuka.Enabled = false;
            btn_kurt.BackColor = Color.Green;
            btn_toto.BackColor = Color.Red;
            btn_ynazuka.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_resultado.Text = resultado.ToString();
        }

        private void btn_ynazuka_Click(object sender, EventArgs e)
        {
            btn_kurt.Enabled = false;
            btn_toto.Enabled = false;
            btn_ynazuka.Enabled = false;
            btn_kurt.BackColor = Color.Green;
            btn_toto.BackColor = Color.Red;
            btn_ynazuka.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_resultado.Text = resultado.ToString();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            this.Hide();
            q3 q3 = new q3(resultado);
            q3.Show();
        }
    }
}
