namespace YilanOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrOyun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSkor.Location = new System.Drawing.Point(563, 9);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(49, 24);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "000";
            // 
            // pnlOyun
            // 
            this.pnlOyun.BackColor = System.Drawing.Color.Black;
            this.pnlOyun.Location = new System.Drawing.Point(12, 42);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Size = new System.Drawing.Size(600, 600);
            this.pnlOyun.TabIndex = 1;
            this.pnlOyun.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOyun_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Herhangi bir yön tuşuna basarak oyunu başlatın ve yön tuşlarıyla yılanı yönlendir" +
    "in.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Skor";
            // 
            // tmrOyun
            // 
            this.tmrOyun.Interval = 300;
            this.tmrOyun.Tick += new System.EventHandler(this.tmrOyun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 695);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlOyun);
            this.Controls.Add(this.lblSkor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSkor;
        private Panel pnlOyun;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer tmrOyun;
    }
}