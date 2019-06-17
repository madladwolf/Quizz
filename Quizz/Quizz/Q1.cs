using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Q1 : Form
    {
        int resultado;
        public Q1()
        {
            InitializeComponent();
            btn_val.Enabled = false;
        }


        private void btn_sora_Click(object sender, EventArgs e)
        {
            resultado++;
            btn_sora.BackColor = Color.Green;
            btn_kairi.BackColor = Color.Red;
            btn_riku.BackColor = Color.Red;
            btn_kairi.Enabled = false;
            btn_riku.Enabled = false;
            btn_sora.Enabled = false;
            lbl_resultado.Text = resultado.ToString();
            btn_val.Enabled = true;
        }

        private void btn_riku_Click(object sender, EventArgs e)
        {
            btn_sora.BackColor = Color.Green;
            btn_kairi.BackColor = Color.Red;
            btn_riku.BackColor = Color.Red;
            btn_kairi.Enabled = false;
            btn_riku.Enabled = false;
            btn_sora.Enabled = false;
            lbl_resultado.Text = resultado.ToString();
            btn_val.Enabled = true;
        }

        private void btn_kairi_Click(object sender, EventArgs e)
        {
            btn_sora.BackColor = Color.Green;
            btn_kairi.BackColor = Color.Red;
            btn_riku.BackColor = Color.Red;
            btn_kairi.Enabled = false;
            btn_riku.Enabled = false;
            btn_sora.Enabled = false;
            lbl_resultado.Text = resultado.ToString();
            btn_val.Enabled = true;
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q2 q2 = new Q2(resultado);
            q2.Show();
        }
    }
}
