using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void ClearBet()
        {
            MyBet = null;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            MyRadioButton.Text = string.Format("{0} has {1} bucks", this.Name, this.Cash);
            if (MyBet == null)
            {
                MyLabel.Text = string.Format("{0} hasn't placed a bet", this.Name);
            }
            //else
            //{
            //    MyLabel.Text = string.Format("{0} has placed a bet", this.Name);
            //}
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (this.Cash >= BetAmount && MyBet == null)
            {
                //nowy zaklad i przypisanie zmiennych 
                MyBet = new Bet();
                MyBet.Amount = BetAmount;
                MyBet.Dog = DogToWin;
                MyBet.Bettor = this;

                //zmienjszenie gotowki wydanej na zaklad u gracza
                //this.Cash -= BetAmount;

                //zmiana opisu label (gracz postawil na konkretnego psa)
                MyLabel.Text = MyBet.GetDescription();
                //MessageBox.Show(MyBet.GetDescription());

                //UpdateLabels();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            //if (MyBet.Dog == Winner)
            //{
            //    Cash += 2 * MyBet.PayOut(Winner);
            //}
            //else
            //{
            //    Cash += MyBet.PayOut(Winner);
            //}

            ClearBet();
        }

    }
}
