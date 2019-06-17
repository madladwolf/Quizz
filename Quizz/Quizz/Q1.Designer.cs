namespace Quizz
{
    partial class Q1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sora = new System.Windows.Forms.Button();
            this.btn_riku = new System.Windows.Forms.Button();
            this.btn_kairi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_val = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who is Sora\'s rival?";
            // 
            // btn_sora
            // 
            this.btn_sora.Location = new System.Drawing.Point(248, 54);
            this.btn_sora.Name = "btn_sora";
            this.btn_sora.Size = new System.Drawing.Size(134, 64);
            this.btn_sora.TabIndex = 1;
            this.btn_sora.Text = "Sora";
            this.btn_sora.UseVisualStyleBackColor = true;
            this.btn_sora.Click += new System.EventHandler(this.btn_sora_Click);
            // 
            // btn_riku
            // 
            this.btn_riku.Location = new System.Drawing.Point(248, 124);
            this.btn_riku.Name = "btn_riku";
            this.btn_riku.Size = new System.Drawing.Size(134, 64);
            this.btn_riku.TabIndex = 2;
            this.btn_riku.Text = "Riku";
            this.btn_riku.UseVisualStyleBackColor = true;
            this.btn_riku.Click += new System.EventHandler(this.btn_riku_Click);
            // 
            // btn_kairi
            // 
            this.btn_kairi.Location = new System.Drawing.Point(248, 194);
            this.btn_kairi.Name = "btn_kairi";
            this.btn_kairi.Size = new System.Drawing.Size(134, 64);
            this.btn_kairi.TabIndex = 3;
            this.btn_kairi.Text = "Kairi";
            this.btn_kairi.UseVisualStyleBackColor = true;
            this.btn_kairi.Click += new System.EventHandler(this.btn_kairi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quizz.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 219);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(346, 13);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "Score";
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(13, 265);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(372, 62);
            this.btn_val.TabIndex = 6;
            this.btn_val.Text = "Next";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 339);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_kairi);
            this.Controls.Add(this.btn_riku);
            this.Controls.Add(this.btn_sora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Q1";
            this.Text = "Q1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sora;
        private System.Windows.Forms.Button btn_riku;
        private System.Windows.Forms.Button btn_kairi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_val;
    }
}