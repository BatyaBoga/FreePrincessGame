using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace FreePrincess
{
    class Game
    {
        private int Health = 3;
        private Level form;
        private List<Label> lb;
        private List<PictureBox> bs;
        private int[] mass;
        private string[] value;



        public Game(Level form)
        {
            this.form = form;

            lb = new List<Label>()
            {
                form.equation1,
                form.equation2,
                form.equation3,
                form.equation4,
                form.equation5,
                form.equation6,
                form.equation7,
                form.equation8,
                form.equation9,
                form.equation10,
            };

            bs = new List<PictureBox>()
            {
                 form.boss1,
                 form.boss2,
                 form.boss3,
                 form.boss4,
                 form.boss5,
                 form.boss6,
                 form.boss7,
                 form.boss8,
                 form.boss9,
                 form.boss10,

            }; 
           
         
        }

        public void chek(object sender)
        {

            int boss = Convert.ToInt32((sender as PictureBox).Tag);
            int Pess = Convert.ToInt32(form.Pers.Tag);


            if (boss < Pess)
            {
                form.Pers.Location = (sender as PictureBox).Location;
                form.level_pers.Location = new Point(form.Pers.Location.X + 38, form.Pers.Location.Y - 41);
                (sender as PictureBox).Visible = false;
                form.Pers.Tag = Pess + 1;
                form.level_pers.Text = form.Pers.Tag.ToString();
                foreach (Label label in form.Controls.OfType<Label>())
                {

                    if (label.Tag.ToString() == boss.ToString())
                    {
                        label.Visible = false;
                    }

                }
            }
            else
            {
                Health--;
                Healthe();
            }
        }

        private void Healthe()
        {
            switch (Health)
            {
                case 2: form.hp3.Image = FreePrincess.Properties.Resources.HurtZero; break;
                case 1: form.hp2.Image = FreePrincess.Properties.Resources.HurtZero; break;
                case 0: form.Close(); FormChanged.EndGame(false, form.level); break;

            }
        }



        public void game_load(int lvl)
        {

            form.Text = $"Level {lvl}";

            switch (lvl)
            {
                case 2:
                    mass = new int[] { 2, 5, 3, 9, 8, 10, 4, 7, 6, 1 };
                    value = new string[] { "7-5", "3+2", "2+1", "8+1", "4+4", "5+5", "10-6", "10-3", "2+4", "5-4" };
                    break;
                case 3:
                    mass = new int[] { 4, 8, 7, 6, 1, 5, 2, 9, 10, 3 };
                    value = new string[] { "2*2", "12-4", "3+4", "2+4", "7/7", "59-54", "3-1", "81:9", "5*2", "3/1" };
                    break;
                case 4:
                    mass = new int[] { 5, 2, 3, 6, 7, 9, 1, 10, 4, 8 };
                    value = new string[] { "30/6", "16/8", "9/3", "51-45", "117-110", "143-134", "13*0+1", "100/10", "16/4", "500-492" };
                    break;
            }

            if(form.level != 1) changeTag();

        }


        private void changeTag()
        {
            for (int i = 0; i < bs.Count; i++)
            {
                bs[i].Tag = mass[i].ToString();
                lb[i].Tag = bs[i].Tag;
                lb[i].Text = value[i];
             
            }
        }

    }
}
