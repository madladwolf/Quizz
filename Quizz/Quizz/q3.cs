using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quizz
{
    public partial class q3 : Form
    {
        int resultado;
        public q3(int r)
        {
            InitializeComponent();
            resultado = r;
            btn_val.Enabled = false;
            lbl_score.Text = resultado.ToString();
        }

        private void btn_mickey_Click(object sender, EventArgs e)
        {
            resultado++;
            btn_backstreet.Enabled = false;
            btn_mickey.Enabled = false;
            btn_sora.Enabled = false;
            btn_backstreet.BackColor = Color.Red;
            btn_mickey.BackColor = Color.Green;
            btn_sora.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_score.Text = resultado.ToString();
        }

        private void btn_sora_Click(object sender, EventArgs e)
        {
            btn_backstreet.Enabled = false;
            btn_mickey.Enabled = false;
            btn_sora.Enabled = false;
            btn_backstreet.BackColor = Color.Red;
            btn_mickey.BackColor = Color.Green;
            btn_sora.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_score.Text = resultado.ToString();
        }

        private void btn_backstreet_Click(object sender, EventArgs e)
        {
            btn_backstreet.Enabled = false;
            btn_mickey.Enabled = false;
            btn_sora.Enabled = false;
            btn_backstreet.BackColor = Color.Red;
            btn_mickey.BackColor = Color.Green;
            btn_sora.BackColor = Color.Red;
            btn_val.Enabled = true;
            lbl_score.Text = resultado.ToString();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            this.Hide();
            end end = new end(resultado);
            end.Show();
        }
    }
}
