using System;
using System.Windows.Forms;

namespace FreePrincess
{
    public partial class EndGame : Form
    {
        int level;
        public EndGame(int level =1)
        {
            InitializeComponent();
            this.level = level;
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.Tag) == 1)
            {
              FormChanged.Level = FormChanged.Level == level ? FormChanged.Level+1 : level;

            }

        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); Application.OpenForms[0].Show();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            this.Close(); new Level(level).Show();
        }
    }
}
