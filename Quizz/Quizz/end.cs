using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class end : Form
    {
        int score;
        public end(int s)
        {
            InitializeComponent();
            score = s;
            label1.Text = s.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
