using System;
using System.Windows.Forms;

namespace FreePrincess
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void StartBox_Click(object sender, EventArgs e)
        {
            FormChanged.StartState(this, true);
        }


        private void Level1Btn_Click(object sender, EventArgs e)
        {
            Level level = new Level(Convert.ToInt32((sender as PictureBox).Tag));
            level.Show();
            Hide();

        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormChanged.StartState(this, false);
        }

        private void Start_Activated(object sender, EventArgs e)
        {
            this.LevelCheck();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            FormChanged.Exit();
        }
    }
}
