using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreePrincess
{
    public partial class Level_1 : Form
    {

        Game<Level_1> g;
        public Level_1()
        {
            InitializeComponent();
            g = new Game<Level_1>(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pause pause = new Pause();
            Form ifrm = Application.OpenForms[0];
            pause.ShowDialog();

            switch (pause.DialogResult)
            {
                case DialogResult.OK: break;
                case DialogResult.Cancel: this.Close(); ifrm.Show();  break;
                case DialogResult.No: break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChanged.EndGame(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChanged.EndGame(true);
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            g(Pers.Tag)
        }
    }
}
