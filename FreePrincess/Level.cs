using System;
using System.Windows.Forms;

namespace FreePrincess
{
    public partial class Level : Form
    {

        Game game;
        public int level;
        public Level(int i = 1)
        {
            InitializeComponent();
            game = new Game(this);
            level = i;

        }

        private void Level_Load(object sender, EventArgs e)
        {
 
            game.game_load(level);

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            Pause pause = new Pause();
            pause.ShowDialog();

            switch (pause.DialogResult)
            {
                case DialogResult.OK: break;
                case DialogResult.Cancel: this.Close(); Application.OpenForms[0].Show(); break;
                case DialogResult.No: this.Close(); Level level1 = new Level(level); level1.Show(); break;
            }

        }

        private void princes_Click(object sender, EventArgs e)
        {
            if (Pers.Tag.ToString() == princes.Tag.ToString())
            {
                this.Close();
                FormChanged.EndGame(true, level);
            }
        }

        private void boss1_Click(object sender, EventArgs e)
        {
            game.chek(sender);
        }
    }    
}
