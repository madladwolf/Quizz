namespace Quizz
{
    partial class q3
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
            this.btn_mickey = new System.Windows.Forms.Button();
            this.btn_sora = new System.Windows.Forms.Button();
            this.btn_backstreet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_val = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mickey
            // 
            this.btn_mickey.Location = new System.Drawing.Point(248, 54);
            this.btn_mickey.Name = "btn_mickey";
            this.btn_mickey.Size = new System.Drawing.Size(134, 64);
            this.btn_mickey.TabIndex = 2;
            this.btn_mickey.Text = "Mickey, Donald, and Goofy";
            this.btn_mickey.UseVisualStyleBackColor = true;
            this.btn_mickey.Click += new System.EventHandler(this.btn_mickey_Click);
            // 
            // btn_sora
            // 
            this.btn_sora.Location = new System.Drawing.Point(248, 124);
            this.btn_sora.Name = "btn_sora";
            this.btn_sora.Size = new System.Drawing.Size(134, 64);
            this.btn_sora.TabIndex = 3;
            this.btn_sora.Text = "Sora, Kurt Zisa, Riku ";
            this.btn_sora.UseVisualStyleBackColor = true;
            this.btn_sora.Click += new System.EventHandler(this.btn_sora_Click);
            // 
            // btn_backstreet
            // 
            this.btn_backstreet.Location = new System.Drawing.Point(248, 199);
            this.btn_backstreet.Name = "btn_backstreet";
            this.btn_backstreet.Size = new System.Drawing.Size(134, 64);
            this.btn_backstreet.TabIndex = 4;
            this.btn_backstreet.Text = "Backstreet Boys";
            this.btn_backstreet.UseVisualStyleBackColor = true;
            this.btn_backstreet.Click += new System.EventHandler(this.btn_backstreet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quizz.Properties.Resources.TheKing;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 209);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Who was suposed to be the protagonist?";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(352, 12);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(35, 13);
            this.lbl_score.TabIndex = 7;
            this.lbl_score.Text = "label2";
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(10, 269);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(372, 62);
            this.btn_val.TabIndex = 8;
            this.btn_val.Text = "Next";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 339);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_backstreet);
            this.Controls.Add(this.btn_sora);
            this.Controls.Add(this.btn_mickey);
            this.Name = "q3";
            this.Text = "q3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mickey;
        private System.Windows.Forms.Button btn_sora;
        private System.Windows.Forms.Button btn_backstreet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_val;
    }
}