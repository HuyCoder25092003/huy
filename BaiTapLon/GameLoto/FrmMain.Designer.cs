namespace GameLoto
{
    partial class FrmMain
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
            this.pnTableLoto = new System.Windows.Forms.Panel();
            this.pnRandom = new System.Windows.Forms.Panel();
            this.pictrueRandom = new System.Windows.Forms.PictureBox();
            this.pnRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictrueRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTableLoto
            // 
            this.pnTableLoto.Location = new System.Drawing.Point(13, 23);
            this.pnTableLoto.Name = "pnTableLoto";
            this.pnTableLoto.Size = new System.Drawing.Size(704, 488);
            this.pnTableLoto.TabIndex = 0;
            // 
            // pnRandom
            // 
            this.pnRandom.Controls.Add(this.pictrueRandom);
            this.pnRandom.Location = new System.Drawing.Point(723, 23);
            this.pnRandom.Name = "pnRandom";
            this.pnRandom.Size = new System.Drawing.Size(340, 340);
            this.pnRandom.TabIndex = 1;
            // 
            // pictrueRandom
            // 
            this.pictrueRandom.Image = global::GameLoto.Properties.Resources._336042623_217840374120500_7726163820848773888_n;
            this.pictrueRandom.Location = new System.Drawing.Point(71, 34);
            this.pictrueRandom.Name = "pictrueRandom";
            this.pictrueRandom.Size = new System.Drawing.Size(178, 111);
            this.pictrueRandom.TabIndex = 0;
            this.pictrueRandom.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 523);
            this.Controls.Add(this.pnRandom);
            this.Controls.Add(this.pnTableLoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.pnRandom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictrueRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTableLoto;
        private System.Windows.Forms.Panel pnRandom;
        private System.Windows.Forms.PictureBox pictrueRandom;
    }
}