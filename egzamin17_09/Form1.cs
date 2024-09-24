using System.Net;

namespace egzamin17_09
{
    public partial class Apk : Form
    {
        public int y = 1;

        public int[] downloads = [11000102, 304666444, 4000230, 300120222, 22000000, 400345042, 253453, 1506404300, 243085, 4586200, 130000560, 24332190, 24300453, 55384200];
        public Apk()
        {
            InitializeComponent();
        }

        private void Apk_Load(object sender, EventArgs e)
        {
           
            try
            {
                using StreamReader reader = new("C:\\Users\\4TP_gr_1\\source\\repos\\egzamin17_09\\egzamin17_09\\Properties\\Data.txt");
                string line = null;
                for (int i = 0; i < 1; ++i)
                {
                    line = reader.ReadLine();
                    author.Text = line;
                    line = reader.ReadLine();
                    album.Text = line;
                    line = reader.ReadLine();
                    songAmount.Text = line + " Utworów";
                    line = reader.ReadLine();
                    year.Text = line;
                    line = reader.ReadLine();
                    installsAmount.Text = line;
                }
            }
            catch (IOException i)
            {
                Console.WriteLine("Nie uda³o siê odczytaæ");
                Console.WriteLine(i.Message);
            }
        }

        private void rightSkip_Click(object sender, EventArgs e)
        {
            y += 1;
            int x = y;
            if (y >= 14)
            {
                y = 0;
            }
            try
            {
                using StreamReader reader = new("C:\\Users\\4TP_gr_1\\source\\repos\\egzamin17_09\\egzamin17_09\\Properties\\Data.txt");
                string line = null;
                for (int i = 0; i < x; i++)
                {
                    line = reader.ReadLine();
                    author.Text = line;
                    line = reader.ReadLine();
                    album.Text = line;
                    line = reader.ReadLine();
                    songAmount.Text = line +  " Utworów";
                    line = reader.ReadLine();
                    year.Text = line;
                    line = reader.ReadLine();
                    installsAmount.Text = line;
                }
              
            }
            catch (IOException i)
            {
                Console.WriteLine("Nie uda³o siê odczytaæ");
                Console.WriteLine(i.Message);
            }


        }

        private void leftSkip_Click(object sender, EventArgs e)
        {
            y -= 1;
            if (y == 0)
            {
                y = 14;
            }
            int x = y;
            try
            {
                using StreamReader reader = new("C:\\Users\\4TP_gr_1\\source\\repos\\egzamin17_09\\egzamin17_09\\Properties\\Data.txt");
                string line = null;
                for (int i = 0; i < x; i++)
                {
                    line = reader.ReadLine();
                    author.Text = line;
                    line = reader.ReadLine();
                    album.Text = line;
                    line = reader.ReadLine();
                    songAmount.Text = line + " Utworów";
                    line = reader.ReadLine();
                    year.Text = line;
                    line = reader.ReadLine();
                    installsAmount.Text = line;
                }
            }
            catch (IOException i)
            {
                Console.WriteLine("Nie uda³o siê odczytaæ");
                Console.WriteLine(i.Message);
            }
        }

        private void install_Click(object sender, EventArgs e)
        {
            downloads[y - 1] = int.Parse(installsAmount.Text);
            downloads[y - 1] += 1;
            installsAmount.Text = downloads[y - 1].ToString();

        }
    }
}
