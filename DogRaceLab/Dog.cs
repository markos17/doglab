using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab
{
    public class Dog
    {
        public string Name;
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer; // = new Random();


        public Dog()
        {
            Randomizer = new Random();
        }

        public bool Run()
        {
            bool win = false;
            Location += Randomizer.Next(20);
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RacetrackLength)
            {
                win = true;
                //TakeStartingPosition();
            }
            return win;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition; //sprawdzic
        }

    }
}
