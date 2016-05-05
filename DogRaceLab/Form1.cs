using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dog[] dogArray = new Dog[4];

        private void btnRace_Click(object sender, EventArgs e)
        {
            PlaceDogOnStart();
            timer1.Start();
        }

       

        private void PlaceDogOnStart()
        {

            Dog piesek = new Dog();
            piesek.Name = "Poppers";
            textBox1.Text = piesek.Name;


            Dog piesek2 = new Dog();
            piesek2.Name = "Azor";
            textBox1.Text +=  ", "  + piesek2.Name;

            piesek.ZarabianieKasy(500);
            textBox1.Text += ", " + piesek.kaska;


            if (dogArray[0] == null)
            {
                dogArray[0] = new Dog()
                {
                    Name = "1",
                    MyPictureBox = pictureBox1,
                    StartingPosition = pictureBox1.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width
                };
            }

            if (dogArray[1] == null)
            {
                dogArray[1] = new Dog()
                {
                    Name = "2",
                    MyPictureBox = pictureBox2,
                    StartingPosition = pictureBox2.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width
                };
            }

            if (dogArray[2] == null)
            {
                dogArray[2] = new Dog()
                {
                    Name = "3",
                    MyPictureBox = pictureBox3,
                    StartingPosition = pictureBox3.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width
                };
            }

            if (dogArray[3] == null)
            {
                dogArray[3] = new Dog()
                {
                    Name = "4",
                    MyPictureBox = pictureBox4,
                    StartingPosition = pictureBox4.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width
                };
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //bool stillRunning = false;
            //int whoWon = 0;
            //  int distance = 0;
            for (int i = 0; i < dogArray.Length; i++)
            {
                //  textBox1.Text += "_" + i + ":" + dogArray[i].Location + ", ";
                //stillRunning = dogArray[i].Run();
                if (dogArray[i].Run())
                {
                    timer1.Stop();
                    //  var distance = dogArray.Max(x => x.Location);
                    // var doggy = dogArray.FirstOrDefault(x => x.Location == distance);
                    // MessageBox.Show(string.Format("Dog {0} won! Distance {1}", doggy.Name, distance)); //dogArray.Max().Location
                    MessageBox.Show(string.Format("Dog {0} won! Distance {1}", dogArray[i].Name, dogArray[i].Location)); //dogArray.Max().Location

                    foreach (Dog dog in dogArray)
                    {
                        dog.TakeStartingPosition();
                    }
                    break;
                }

            }



        }
    }
}
