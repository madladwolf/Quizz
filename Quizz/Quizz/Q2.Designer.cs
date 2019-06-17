namespace Quizz
{
    partial class Q2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_kurt = new System.Windows.Forms.Button();
            this.btn_toto = new System.Windows.Forms.Button();
            this.btn_ynazuka = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_val = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(13, 13);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(29, 13);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "label";
            // 
            // btn_kurt
            // 
            this.btn_kurt.Location = new System.Drawing.Point(248, 54);
            this.btn_kurt.Name = "btn_kurt";
            this.btn_kurt.Size = new System.Drawing.Size(134, 64);
            this.btn_kurt.TabIndex = 1;
            this.btn_kurt.Text = "Kurt Zisa";
            this.btn_kurt.UseVisualStyleBackColor = true;
            this.btn_kurt.Click += new System.EventHandler(this.btn_kurt_Click);
            // 
            // btn_toto
            // 
            this.btn_toto.Location = new System.Drawing.Point(248, 124);
            this.btn_toto.Name = "btn_toto";
            this.btn_toto.Size = new System.Drawing.Size(134, 64);
            this.btn_toto.TabIndex = 2;
            this.btn_toto.Text = "Totoshima";
            this.btn_toto.UseVisualStyleBackColor = true;
            this.btn_toto.Click += new System.EventHandler(this.btn_toto_Click);
            // 
            // btn_ynazuka
            // 
            this.btn_ynazuka.Location = new System.Drawing.Point(248, 194);
            this.btn_ynazuka.Name = "btn_ynazuka";
            this.btn_ynazuka.Size = new System.Drawing.Size(134, 64);
            this.btn_ynazuka.TabIndex = 3;
            this.btn_ynazuka.Text = "Ynazuka Yomoto";
            this.btn_ynazuka.UseVisualStyleBackColor = true;
            this.btn_ynazuka.Click += new System.EventHandler(this.btn_ynazuka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quizz.Properties.Resources._13465215405_3607cb7a14_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 97);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(352, 12);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "label1";
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(10, 265);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(372, 62);
            this.btn_val.TabIndex = 7;
            this.btn_val.Text = "Next";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 339);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ynazuka);
            this.Controls.Add(this.btn_toto);
            this.Controls.Add(this.btn_kurt);
            this.Controls.Add(this.lbl_question);
            this.Name = "Q2";
            this.Text = "Q2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Button btn_kurt;
        private System.Windows.Forms.Button btn_toto;
        private System.Windows.Forms.Button btn_ynazuka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_val;
    }
}