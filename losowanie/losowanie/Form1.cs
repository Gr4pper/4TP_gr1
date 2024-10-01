using losowanie.Properties;
using System.Windows.Forms;

namespace losowanie
{
    public partial class Form1 : Form
    {
        public int wynikInt = 0;
        public int wynikCal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rzut_Click(object sender, EventArgs e)
        {
            wynikInt = 0;
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            int dice4 = rnd.Next(1, 7);
            int dice5 = rnd.Next(1, 7);

            switch (dice1)
            {
                case 1:
                    img1.Image = Properties.Resources.kosc1;
                    wynikInt += 1;
                    break;
                case 2:
                    img1.Image = Properties.Resources.kosc2;
                    wynikInt += 2;
                    break;
                case 3:
                    img1.Image = Properties.Resources.kosc3;
                    wynikInt += 3;
                    break;
                case 4:
                    img1.Image = Properties.Resources.kosc4;
                    wynikInt += 4;
                    break;
                case 5:
                    img1.Image = Properties.Resources.kosc5;
                    wynikInt += 5;
                    break;
                case 6:
                    img1.Image = Properties.Resources.kosc6;
                    wynikInt += 6;
                    break;
            }
            switch (dice2)
            {
                case 1:
                    img2.Image = Properties.Resources.kosc1;
                    wynikInt += 1;
                    break;
                case 2:
                    img2.Image = Properties.Resources.kosc2;
                    wynikInt += 2;
                    break;
                case 3:
                    img2.Image = Properties.Resources.kosc3;
                    wynikInt += 3;
                    break;
                case 4:
                    img2.Image = Properties.Resources.kosc4;
                    wynikInt += 4;
                    break;
                case 5:
                    img2.Image = Properties.Resources.kosc5;
                    wynikInt += 5;
                    break;
                case 6:
                    img2.Image = Properties.Resources.kosc6;
                    wynikInt += 6;
                    break;
            }
            switch (dice3)
            {
                case 1:
                    img3.Image = Properties.Resources.kosc1;
                    wynikInt += 1;
                    break;
                case 2:
                    img3.Image = Properties.Resources.kosc2;
                    wynikInt += 2;
                    break;
                case 3:
                    img3.Image = Properties.Resources.kosc3;
                    wynikInt += 3;
                    break;
                case 4:
                    img3.Image = Properties.Resources.kosc4;
                    wynikInt += 4;
                    break;
                case 5:
                    img3.Image = Properties.Resources.kosc5;
                    wynikInt += 5;
                    break;
                case 6:
                    img3.Image = Properties.Resources.kosc6;
                    wynikInt += 6;
                    break;
            }
            switch (dice4)
            {
                case 1:
                    img4.Image = Properties.Resources.kosc1;
                    wynikInt += 1;
                    break;
                case 2:
                    img4.Image = Properties.Resources.kosc2;
                    wynikInt += 2;
                    break;
                case 3:
                    img4.Image = Properties.Resources.kosc3;
                    wynikInt += 3;
                    break;
                case 4:
                    img4.Image = Properties.Resources.kosc4;
                    wynikInt += 4;
                    break;
                case 5:
                    img4.Image = Properties.Resources.kosc5;
                    wynikInt += 5;
                    break;
                case 6:
                    img4.Image = Properties.Resources.kosc6;
                    wynikInt += 6;
                    break;
            }
            switch (dice5)
            {
                case 1:
                    img5.Image = Properties.Resources.kosc1;
                    wynikInt += 1;
                    break;
                case 2:
                    img5.Image = Properties.Resources.kosc2;
                    wynikInt += 2;
                    break;
                case 3:
                    img5.Image = Properties.Resources.kosc3;
                    wynikInt += 3;
                    break;
                case 4:
                    img5.Image = Properties.Resources.kosc4;
                    wynikInt += 4;
                    break;
                case 5:
                    img5.Image = Properties.Resources.kosc5;
                    wynikInt += 5;
                    break;
                case 6:
                    img5.Image = Properties.Resources.kosc6;
                    wynikInt += 6;
                    break;
            }
            wynik.Text = "Wynik tego losowania to: " + wynikInt.ToString();
            wynikCal += wynikInt;
            wynikGry.Text = "Wynik gry to: " + wynikCal.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            wynikInt = 0;
            wynikCal = 0;
            img1.Image = Properties.Resources.kosc1;
            img2.Image = Properties.Resources.kosc1;
            img3.Image = Properties.Resources.kosc1;
            img4.Image = Properties.Resources.kosc1;
            img5.Image = Properties.Resources.kosc1;
            wynik.Text = "Wynik tego losowania to: " + wynikInt.ToString();
            wynikGry.Text = "Wynik gry to: " + wynikCal.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
