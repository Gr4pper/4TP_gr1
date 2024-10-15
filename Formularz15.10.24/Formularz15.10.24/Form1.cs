using System.Text;

namespace Formularz15._10._24
{
    public partial class Form1 : Form
    {
        public string password = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string name = firstName.Text;
            string surname = lastName.Text;
            string workStatus = job.Text;
            if (name != null && surname != null && workStatus != null && password != null)
            {
                MessageBox.Show("Dane pracownika: " + name + " " + surname + " " + workStatus + " " + "Has³o: " + password);
            }
            else
            {
                MessageBox.Show("Proszê wprowadziæ wszystkie dane");
            }
        }

        private void passwordGenerate_Click(object sender, EventArgs e)
        {

            string valid = "abcdefghijklmnopqrstuvwxyz";
            string capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "1234567890";
            string special = "!@#$%^&*?";
            int num = Int32.Parse(letterNumber.Text);
            password = null;
            if (letterNumber != null)
            {
                if (letterSize.Checked)
                {
                    StringBuilder res = new StringBuilder();
                    Random rnd = new Random();
                    res.Append(capital[rnd.Next(capital.Length)]);
                    password += res.ToString();
                    num -= 1;
                }
                if (numbers.Checked)
                {
                    StringBuilder res = new StringBuilder();
                    Random rnd = new Random();
                    res.Append(number[rnd.Next(number.Length)]);
                    password += res.ToString();
                    num -= 1;
                }
                if (specialSigns.Checked)
                {
                    StringBuilder res = new StringBuilder();
                    Random rnd = new Random();
                    res.Append(special[rnd.Next(special.Length)]);
                    password += res.ToString();
                    num -= 1;
                }
                for(int i = 0; i < num; i++)
                {
                    StringBuilder res = new StringBuilder();
                    Random rnd = new Random();
                    res.Append(valid[rnd.Next(valid.Length)]);
                    password += res.ToString();
                }
                MessageBox.Show(password);
            }
        }
    }
}
