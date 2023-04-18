using System.Diagnostics;

namespace Dice_Roller
{
    public partial class Form1 : Form{
        public Random random = new Random();
        public int maxRange, minRange;

        public Form1(){
            InitializeComponent();
            Number.Visible = false;
            ReRoll.Visible = false;
        }

        private void Button_Click(object sender, EventArgs e){
            

            if(maxRange > minRange){
                Number.Text = "Your Number Is " +
                    random.Next(minRange,maxRange).ToString();

                Button.Visible = false;
                Number.Visible = true;
                ReRoll.Visible = true;
            }
            else { MessageBox.Show("The Max Range Needs To Be Higher Than The Min Range"); }
            
        }

        private void MaxRange_TextChanged(object sender, EventArgs e){
            if (!MaxRange.Text.All(char.IsNumber)) { return;}
            
            int.TryParse(MaxRange.Text, out maxRange);
        }

        private void ReRoll_Click(object sender, EventArgs e){
            if (maxRange > minRange)
            {
                Number.Text = "Your Number Is " +
                    random.Next(minRange, maxRange).ToString();

                Button.Visible = false;
                Number.Visible = true;
                ReRoll.Visible = true;
            }
            else { MessageBox.Show("The Max Range Needs To Be Higher Than The Min Range"); }
        }

        private void MinRange_TextChanged(object sender, EventArgs e) {
            if (!MinRange.Text.All(char.IsNumber)) { return;}

            int.TryParse(MinRange.Text, out minRange);
        }
    }
}