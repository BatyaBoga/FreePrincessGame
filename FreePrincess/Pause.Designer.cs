namespace FreePrincess
{
    partial class Pause
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
            this.PlayBtn = new System.Windows.Forms.PictureBox();
            this.RestartBtn = new System.Windows.Forms.PictureBox();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Image = global::FreePrincess.Properties.Resources.Pause;
            this.PlayBtn.Location = new System.Drawing.Point(51, 188);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(80, 63);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Image = global::FreePrincess.Properties.Resources.Restart;
            this.RestartBtn.Location = new System.Drawing.Point(213, 188);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(80, 63);
            this.RestartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestartBtn.TabIndex = 1;
            this.RestartBtn.TabStop = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = global::FreePrincess.Properties.Resources.Home;
            this.HomeBtn.Location = new System.Drawing.Point(370, 188);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(80, 63);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::FreePrincess.Properties.Resources.PauseFon;
            this.ClientSize = new System.Drawing.Size(487, 263);
            this.ControlBox = false;
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.PlayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pause";
            this.Text = "Pause";
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayBtn;
        private System.Windows.Forms.PictureBox RestartBtn;
        private System.Windows.Forms.PictureBox HomeBtn;
    }
}