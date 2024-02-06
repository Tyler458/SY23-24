using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesDex
{
    enum genre
    {
        RPG, Action_Adventure, FPS, Horror, Platformer
    }
    enum rating
    {
        everyone, teen, mature 
    }
    struct Game
    {
        public string Name;
        public string Character;
        public genre GenreType;
        public rating RatingType;
        public string Release;
        public int CriticScores;
        public string Revenue;
        public string Developer;
        public string image;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Game[] games;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            Currentlabel.Text = current.ToString();
            games = new Game[50];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Game.txt"))
            {
                StreamReader inFile = new StreamReader("Game.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Game p = ReadGame(S);
                    games[count] = p;
                    count++;
                }
                inFile.Close();
                ShowGame(games[0]);

            }
        }
        private Game ReadGame(string s)
        {
            Game p = new Game();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Character = fields[1];
            p.GenreType = (genre)Enum.Parse(typeof(genre), fields[2]);
            p.RatingType = (rating)Enum.Parse(typeof(rating), fields[3]);
            p.Release = fields[4];
            p.CriticScores = int.Parse(fields[5]);
            p.Revenue = fields[6];
            p.Developer = fields[7];
            p.image = fields[8];
            return p;
        }

        public void save()
        {
            string tmp = " ";
            tmp += NametextBox.Text;
            tmp += "|";
            tmp += CharactertextBox.Text;
            tmp += "|";
            tmp += GenrecomboBox.Text;
            tmp += "|";
            tmp += RatingcomboBox.Text;
            tmp += "|";
            tmp += ReleasetextBox.Text;
            tmp += "|";
            tmp += CriticScoresnumericUpDown.Value;
            tmp += "|";
            tmp += RevenuetextBox.Text;
            tmp += "|";
            tmp += DevelopertextBox.Text;
            tmp += "|";
            tmp += pictureBox1.ImageLocation;

            games[current] = ReadGame(tmp);

            StreamWriter outFile = new StreamWriter("Game.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(GameToString(games[i]));
            }
            outFile.Close();
            //outFile.Write(DebugtextBox.Text);
            //outFile.Close();
        }
        private string GameToString(Game p)
        {
            string retVal = "";
            retVal += p.Name;
            retVal += "|";
            retVal += p.Character.ToString();
            retVal += "|";
            retVal += p.GenreType.ToString();
            retVal += "|";
            retVal += p.RatingType.ToString();
            retVal += "|";
            retVal += p.Release.ToString();
            retVal += "|";
            retVal += p.CriticScores.ToString();
            retVal += "|";
            retVal += p.Revenue.ToString();
            retVal += "|";
            retVal += p.Developer.ToString();
            retVal += "|";
            retVal += p.image.ToString();
            return retVal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void ShowGame(Game p)
        {
            NametextBox.Text = p.Name;
            CharactertextBox.Text = p.Character;
            GenrecomboBox.Text = p.GenreType.ToString();
            RatingcomboBox.Text = p.RatingType.ToString();
            ReleasetextBox.Text = p.Release;
            CriticScoresnumericUpDown.Value = p.CriticScores;
            RevenuetextBox.Text = p.Revenue;
            DevelopertextBox.Text = p.Developer;
            
        }
        private void clear()
        {
            NametextBox.Text = " ";
            CharactertextBox.Text = " ";
            GenrecomboBox.Text = " ";
            RatingcomboBox.Text = " ";
            ReleasetextBox.Text = " ";
            CriticScoresnumericUpDown.Value = 0;
            RevenuetextBox.Text = " ";
            DevelopertextBox.Text = " ";

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void DebugtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Newbutton_Click_1(object sender, EventArgs e)
        {
            current = count;
            count++;
            clear();
        }

        private void Firstbutton_Click_1(object sender, EventArgs e)
        {
            save();
            current = 0;
            Currentlabel.Text = current.ToString();
            ShowGame(games[current]);
        }

        private void Previousbutton_Click_1(object sender, EventArgs e)
        {
            if (current > 0)
            {
                save();
                current--;
                Currentlabel.Text = current.ToString();
                ShowGame(games[current]);

            }
        }

        private void Nextbutton_Click_1(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                save();
                current++;
                Currentlabel.Text = current.ToString();
                ShowGame(games[current]);

            }
        }

        private void Lastbutton_Click_1(object sender, EventArgs e)
        {
            save();
            current = count - 1;
            Currentlabel.Text = current.ToString();
            ShowGame(games[current]);
        }
    }
}
