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
        Dog[] dogArray = new Dog[4];
        Guy[] guyArray = new Guy[3];

        public Form1()
        {
            InitializeComponent();
            InitializeGuys();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            PlaceDogOnStart();
            timer1.Start();
        }

        private void InitializeGuys()
        {
            guyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                Cash = 50,
                MyLabel = lbJoe,
                MyRadioButton = rbJoe
            };
            guyArray[0].UpdateLabels();

            guyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyLabel = lbBob,
                MyRadioButton = rbBob
            };
            guyArray[1].UpdateLabels();

            guyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyLabel = lbAl,
                MyRadioButton = rbAl
            };
            guyArray[2].UpdateLabels();
        }

        private void PlaceDogOnStart()
        {
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
            for (int i = 0; i < dogArray.Length; i++)
            {
                if (dogArray[i].Run())
                {
                    timer1.Stop();
                    //  var distance = dogArray.Max(x => x.Location);
                    // var doggy = dogArray.FirstOrDefault(x => x.Location == distance);
                    // MessageBox.Show(string.Format("Dog {0} won! Distance {1}", doggy.Name, distance)); //dogArray.Max().Location
                    MessageBox.Show(string.Format("Dog {0} won!", dogArray[i].Name)); //dogArray.Max().Location

                    for (int j = 0; j < guyArray.Length; j++)
                    {
                        if (guyArray[j].MyBet != null)
                        {
                            guyArray[j].Collect(i + 1);
                        }
                    }

                    foreach (Dog dog in dogArray)
                    {
                        dog.TakeStartingPosition();
                    }
                    break;
                }
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (rbJoe.Checked)
            {
                if (!CanCurrentGuyPlaceBet(0))
                {
                    MessageBox.Show("There are insufficient funds");
                }
            }
            else if (rbBob.Checked)
            {
                if (!CanCurrentGuyPlaceBet(1))
                {
                    MessageBox.Show("There are insufficient funds");
                }
            }
            else if (rbAl.Checked)
            {
                if (!CanCurrentGuyPlaceBet(2))
                {
                    MessageBox.Show("There are insufficient funds");
                }
            }
        }

        private bool CanCurrentGuyPlaceBet(int guyNr)
        {
            return guyArray[guyNr].PlaceBet((int)nrDolar.Value, (int)nrDog.Value);
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            lbName.Text = "Joe";
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            lbName.Text = "Bob";
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            lbName.Text = "Al";
        }
    }
}
