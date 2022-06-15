namespace FreePrincess
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.PictureBox();
            this.LogoGame = new System.Windows.Forms.PictureBox();
            this.Level1Btn = new System.Windows.Forms.PictureBox();
            this.Level2Btn = new System.Windows.Forms.PictureBox();
            this.Level3Btn = new System.Windows.Forms.PictureBox();
            this.Level4Btn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level4Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Image = global::FreePrincess.Properties.Resources.StartButton;
            this.StartButton.Location = new System.Drawing.Point(348, 411);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(329, 123);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartButton.TabIndex = 0;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartBox_Click);
            // 
            // LogoGame
            // 
            this.LogoGame.BackColor = System.Drawing.Color.Transparent;
            this.LogoGame.Image = global::FreePrincess.Properties.Resources.Logo;
            this.LogoGame.Location = new System.Drawing.Point(157, 36);
            this.LogoGame.Name = "LogoGame";
            this.LogoGame.Size = new System.Drawing.Size(768, 282);
            this.LogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoGame.TabIndex = 2;
            this.LogoGame.TabStop = false;
            // 
            // Level1Btn
            // 
            this.Level1Btn.BackColor = System.Drawing.Color.Transparent;
            this.Level1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level1Btn.Image = global::FreePrincess.Properties.Resources.Level_1;
            this.Level1Btn.Location = new System.Drawing.Point(33, 282);
            this.Level1Btn.Name = "Level1Btn";
            this.Level1Btn.Size = new System.Drawing.Size(218, 82);
            this.Level1Btn.TabIndex = 3;
            this.Level1Btn.TabStop = false;
            this.Level1Btn.Tag = "1";
            this.Level1Btn.Visible = false;
            this.Level1Btn.Click += new System.EventHandler(this.Level1Btn_Click);
            // 
            // Level2Btn
            // 
            this.Level2Btn.BackColor = System.Drawing.Color.Transparent;
            this.Level2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level2Btn.Enabled = false;
            this.Level2Btn.Image = global::FreePrincess.Properties.Resources.Level_2_Off;
            this.Level2Btn.Location = new System.Drawing.Point(282, 282);
            this.Level2Btn.Name = "Level2Btn";
            this.Level2Btn.Size = new System.Drawing.Size(218, 82);
            this.Level2Btn.TabIndex = 4;
            this.Level2Btn.TabStop = false;
            this.Level2Btn.Tag = "2";
            this.Level2Btn.Visible = false;
            this.Level2Btn.Click += new System.EventHandler(this.Level1Btn_Click);
            // 
            // Level3Btn
            // 
            this.Level3Btn.BackColor = System.Drawing.Color.Transparent;
            this.Level3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level3Btn.Enabled = false;
            this.Level3Btn.Image = global::FreePrincess.Properties.Resources.Level_3off;
            this.Level3Btn.Location = new System.Drawing.Point(545, 282);
            this.Level3Btn.Name = "Level3Btn";
            this.Level3Btn.Size = new System.Drawing.Size(218, 82);
            this.Level3Btn.TabIndex = 5;
            this.Level3Btn.TabStop = false;
            this.Level3Btn.Tag = "3";
            this.Level3Btn.Visible = false;
            this.Level3Btn.Click += new System.EventHandler(this.Level1Btn_Click);
            // 
            // Level4Btn
            // 
            this.Level4Btn.BackColor = System.Drawing.Color.Transparent;
            this.Level4Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level4Btn.Enabled = false;
            this.Level4Btn.Image = global::FreePrincess.Properties.Resources.Level_4_off;
            this.Level4Btn.Location = new System.Drawing.Point(799, 282);
            this.Level4Btn.Name = "Level4Btn";
            this.Level4Btn.Size = new System.Drawing.Size(218, 82);
            this.Level4Btn.TabIndex = 6;
            this.Level4Btn.TabStop = false;
            this.Level4Btn.Tag = "4";
            this.Level4Btn.Visible = false;
            this.Level4Btn.Click += new System.EventHandler(this.Level1Btn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Image = global::FreePrincess.Properties.Resources.Exit;
            this.ExitBtn.Location = new System.Drawing.Point(958, 501);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 67);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::FreePrincess.Properties.Resources.Back;
            this.BackBtn.Location = new System.Drawing.Point(12, 501);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(73, 66);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.TabStop = false;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FreePrincess.Properties.Resources._46ac9e282d3c303934a72d941845785b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 604);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Level4Btn);
            this.Controls.Add(this.Level3Btn);
            this.Controls.Add(this.Level2Btn);
            this.Controls.Add(this.Level1Btn);
            this.Controls.Add(this.LogoGame);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "Free the princess";
            this.Activated += new System.EventHandler(this.Start_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level4Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox LogoGame;
        public System.Windows.Forms.PictureBox Level1Btn;
        public System.Windows.Forms.PictureBox Level2Btn;
        public System.Windows.Forms.PictureBox Level3Btn;
        public System.Windows.Forms.PictureBox Level4Btn;
        public System.Windows.Forms.PictureBox StartButton;
        public System.Windows.Forms.PictureBox BackBtn;
        public System.Windows.Forms.PictureBox ExitBtn;
    }
}

