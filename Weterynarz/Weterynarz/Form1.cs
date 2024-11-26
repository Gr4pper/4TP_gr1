namespace Weterynarz
{
    public partial class Form1 : Form
    {
        public String gatunekZ = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void gatunek_SelectedIndexChanged(object sender, EventArgs e)
        {
            gatunekZ = gatunek.Text;

        }

        private void wiek_Scroll(object sender, EventArgs e)
        {
            wiekLiczba.Text = "Ile ma lat?  " + wiek.Value;

            if (gatunekZ == "Pies")
            {
                wiek.Maximum = 18;
            }
            else if (gatunekZ == "Kot")
            {
                wiek.Maximum = 20;
            }
            else if (gatunekZ == "Œwinka morska")
            {
                wiek.Maximum = 9;
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iin.Text + ", " + gatunek.Text + ", " + wiek.Value.ToString() + ", " + cel.Text + ", " + godzina.Text);
        }
    }
}
