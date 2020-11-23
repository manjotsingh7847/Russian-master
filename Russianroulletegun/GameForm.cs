using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russianroulletegun
{
    public partial class Russian_Roullete : Form
    {
        Roullete Obj_Game = new Roullete();
        public Russian_Roullete()
        {
            InitializeComponent();
        }
       
        private void Russian_Roullete_Load(object sender, EventArgs e)
        {
            btn_Load.Enabled = true; //enable button
            btn_Spin.Enabled = false; //disable button
            btn_Shoot.Enabled = false; //disable button
            btn_ShootAway.Enabled = false; //disable button
        }

       
        private void btn_Load_Click(object sender, EventArgs e)
        {
            //below coide helps to show the image
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("Russianroulletegun.Resources.spin.gif");
            Bitmap bmpObj = new Bitmap(Str);
            PicBox_Shoot.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(Russianroulletegun.Properties.Resources.Loadsound);
            sndObj.Play();
            //enable spin button and disable other
            btn_Spin.Enabled = true;
            btn_Load.Enabled = false;

            //call load function to set bullet at first position
            Obj_Game.Load();
        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            //coding for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("Russianroulletegun.Resources.spin.gif");
            Bitmap bmpObj = new Bitmap(Str);
            PicBox_Shoot.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(Russianroulletegun.Properties.Resources.spin1);
            sndObj.Play();

            // call spin function to set the bullet at random place
            Obj_Game.spin(); 
           
            //enable shoot and shoot away buttons and disable other
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            btn_Spin.Enabled = false;
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            //below coide helps to show the image
            //coding for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("Russianroulletegun.Resources.shoot.gif");
            Bitmap bmpObj = new Bitmap(Str);
            PicBox_Shoot.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(Russianroulletegun.Properties.Resources.shootSound);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check bullet is under gun hammer
            {

                MessageBox.Show("Sorry! you loose the game");
                btn_ShootAway.Enabled = false;
                btn_Shoot.Enabled = false;


            }
            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check bullet is not under gun hammer
            {
                MessageBox.Show("Blank Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1;//minus one from total
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet method from Roullet class to set the bullet position
            }
        }

        private void btn_ShootAway_Click(object sender, EventArgs e)
        {
            //coding for image//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("Russianroulletegun.Resources.shootaway.gif");
            Bitmap bmpObj = new Bitmap(Str);
            PicBox_Shoot.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(Russianroulletegun.Properties.Resources.shootSound);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check bullet is under gun hammer
            {
                if (Obj_Game.Point_Away == 2) // condition to check bullet fired in first chance
                {
                    MessageBox.Show("You won and your score is 100");
                    btn_ShootAway.Enabled = false;
                    btn_Shoot.Enabled = false;
                }
                if (Obj_Game.Point_Away == 1) // condition to check bullet fired in second chance
                {
                    MessageBox.Show("You won and your score is 50");
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                }
            }

            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check bullet is not under gun hammer
            {
                MessageBox.Show("Blank Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1; //reducing the total fire
                Obj_Game.Point_Away = Obj_Game.Point_Away - 1; //reducing the total chances
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet method from Roullet class to set the bullet position
                if (Obj_Game.Point_Away == 0) // condition to check any chance left or not
                {
                    MessageBox.Show("You are Dead .....  sorryyyyyyyyyyy");
                    btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                }
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close the application
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

}

