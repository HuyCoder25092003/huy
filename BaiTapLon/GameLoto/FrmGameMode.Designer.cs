namespace GameLoto
{
    partial class FrmGameMode
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
            this.btPlayOnline = new System.Windows.Forms.Button();
            this.btPlayCPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlayOnline
            // 
            this.btPlayOnline.Location = new System.Drawing.Point(298, 131);
            this.btPlayOnline.Name = "btPlayOnline";
            this.btPlayOnline.Size = new System.Drawing.Size(110, 31);
            this.btPlayOnline.TabIndex = 0;
            this.btPlayOnline.Text = "Play Online";
            this.btPlayOnline.UseVisualStyleBackColor = true;
            this.btPlayOnline.Click += new System.EventHandler(this.btPlayOnline_Click);
            // 
            // btPlayCPU
            // 
            this.btPlayCPU.Location = new System.Drawing.Point(298, 195);
            this.btPlayCPU.Name = "btPlayCPU";
            this.btPlayCPU.Size = new System.Drawing.Size(110, 23);
            this.btPlayCPU.TabIndex = 0;
            this.btPlayCPU.Text = "Play CPU";
            this.btPlayCPU.UseVisualStyleBackColor = true;
            this.btPlayCPU.Click += new System.EventHandler(this.btPlayOnline_Click);
            // 
            // FrmGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPlayCPU);
            this.Controls.Add(this.btPlayOnline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlayOnline;
        private System.Windows.Forms.Button btPlayCPU;
    }
}