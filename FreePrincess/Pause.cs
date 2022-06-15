using System;
using System.Windows.Forms;

namespace FreePrincess
{
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
