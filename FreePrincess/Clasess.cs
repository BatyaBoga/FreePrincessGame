using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreePrincess
{
    public static class FormChanged
    {


        public static int Level = 1;
        //StartState переделать
        public static void StartState(Start startForm, bool state)
        {
            if (state)
            {
                startForm.StartButton.Visible = false;
                startForm.LogoGame.Visible = false;

                startForm.Level1Btn.Visible = true;
                //
                startForm.Level2Btn.Visible = true;
                startForm.Level3Btn.Visible = true;
                startForm.Level4Btn.Visible = true;
                //

                startForm.BackBtn.Visible = true;
            }
            else
            {
                startForm.StartButton.Visible = true;
                startForm.LogoGame.Visible = true;

                startForm.Level1Btn.Visible = false;
                //
                startForm.Level2Btn.Visible = false;
                startForm.Level3Btn.Visible = false;
                startForm.Level4Btn.Visible = false;
                //

                startForm.BackBtn.Visible = false;
            }

        }

       public static void LevelCheck(this Start startForm)
        {
            switch (Level)
            {
                case 2: startForm.Level2Btn.Enabled = true; break;
                case 3: startForm.Level3Btn.Enabled = true; break;
                case 4: startForm.Level4Btn.Enabled = true; break;
            }
        }

        public static void Home( )
        {
           
        }

        public static void EndGame(bool state)
        {
            EndGame endGame = new EndGame();
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
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }


    }
    
}
