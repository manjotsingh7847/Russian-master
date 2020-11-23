using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russianroulletegun
{
    public partial class Russian_Roullete : Form
    {
        public Russian_Roullete()
        {
            InitializeComponent();
        }
        Roullete Rolleteobj = new Roullete();
        Random Rand = new Random();
        int totalshot =6;
        int guntry=2;
        private void loadbutt_Click(object sender, EventArgs e)
        {
            gigimg.Image = Image.FromFile(@"C:\Users\Manpreet Singh\Desktop\Russian\media\load.gif");



            spinbutt .Enabled = true; 
            loadbutt .Enabled = false;
            Rolleteobj.load = 1;
        }

        private void spinbutt_Click(object sender, EventArgs e)
        {

            gigimg.Image = Image.FromFile(@" C:\Users\Manpreet Singh\Desktop\Russian\media\spin.gif");

            Rolleteobj.bulleteloadspin = Rand.Next(1, 6);

            shootbutt .Enabled = true; 
           spinbutt .Enabled = false;
        }

        private void shootbutt_Click(object sender, EventArgs e)
        {
            gigimg.Image = Image.FromFile(@"C:\Users\Manpreet Singh\Desktop\Russian\media\shoot.gif");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@" C:\Users\Manpreet Singh\Desktop\Russian\media\shoot.wav");
            player.Play();
            if(totalshot>0&& Rolleteobj.bulleteloadspin == 1)
            {
                
                MessageBox.Show("Shoot You loose");
                shootawaybutt.Enabled = false;
                shootbutt.Enabled = false;


            }
            else if(totalshot > 0 && Rolleteobj.bulleteloadspin != 1)
            {
                MessageBox.Show("Blank Fire");
                totalshot = totalshot - 1;
                Rolleteobj.bulleteloadspin = Rolleteobj.Bulleteloop(Rolleteobj.bulleteloadspin);

            }

        }

        private void shootawaybutt_Click(object sender, EventArgs e)
        {
            if (totalshot > 0 && Rolleteobj.bulleteloadspin == 1&&guntry ==2)
            {

                MessageBox.Show("you win you score is 200");
                shootawaybutt.Enabled = false;
                shootbutt.Enabled = false;


            }
            if (totalshot > 0 && Rolleteobj.bulleteloadspin == 1 && guntry == 1)
            {

                MessageBox.Show("you win and your score is 100");
                shootbutt.Enabled = false;
                shootawaybutt .Enabled = false;

            }

            else if(totalshot > 0 && Rolleteobj.bulleteloadspin !=1 )
            {
                MessageBox.Show("Blank Fire");
                totalshot = totalshot - 1;
                Rolleteobj.bulleteloadspin = Rolleteobj.Bulleteloop(Rolleteobj.bulleteloadspin);

            }
        }

        private void Playagbutt_Click(object sender, EventArgs e)
        {
            (new Russian_Roullete()).Show();
            this.Hide();
        }
    }
}
