    
using System.Windows.Forms;

namespace FreePrincess
{

   
    public static class FormChanged
    {


        public static int Level = 1;
     
        public static void StartState(Start startForm, bool state)
        {
            if (state)
            {
                startForm.StartButton.Visible = false;
                startForm.LogoGame.Visible = false;
                startForm.Level1Btn.Visible = true;
                startForm.Level2Btn.Visible = true;
                startForm.Level3Btn.Visible = true;
                startForm.Level4Btn.Visible = true;
                startForm.BackBtn.Visible = true;
            }
            else
            {
                startForm.StartButton.Visible = true;
                startForm.LogoGame.Visible = true;
                startForm.Level1Btn.Visible = false;
                startForm.Level2Btn.Visible = false;
                startForm.Level3Btn.Visible = false;
                startForm.Level4Btn.Visible = false;
                startForm.BackBtn.Visible = false;
            }

        }

       public static void LevelCheck(this Start startForm)
        {
            switch (Level)
            {
                case 2: startForm.Level2Btn.Enabled = true; startForm.Level2Btn.Image = FreePrincess.Properties.Resources.Level_2;  break;
                case 3: startForm.Level3Btn.Enabled = true; startForm.Level3Btn.Image = FreePrincess.Properties.Resources.Level_3; break;
                case 4: startForm.Level4Btn.Enabled = true; startForm.Level4Btn.Image = FreePrincess.Properties.Resources.Level_4; break;
            }
        }

        public static void EndGame(bool state, int level)
        {
            EndGame endGame = new EndGame(level);

            if (state)
            {
                endGame.BackgroundImage = FreePrincess.Properties.Resources.WinGame;
                endGame.Tag = 1;
            }
            else
            endGame.BackgroundImage = FreePrincess.Properties.Resources.LoseGame;
            endGame.ShowDialog();
        }
        public static void Exit()
        {
            const string message = "Ви впевнені, що бажаєте завершити гру?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }


    }
    
}
