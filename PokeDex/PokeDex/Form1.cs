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

namespace PokeDex
{
    enum attack
    {
        Special_Attack, Special_Defence, Attack, Defence
    }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public attack AttackType;
        public int Hp;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Generation;
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string S = inFile.ReadToEnd();
                ReadPokemon(S);
                inFile.Close();
            }


        }
        private void ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.AttackType =(attack)Enum.Parse(typeof(attack),fields[3]);
            p.Hp = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
                p.Legendary=false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Generation = int.Parse(fields[8]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebugtextBox.Clear();
            DebugtextBox.Text += NametextBox.Text;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += TypetextBox.Text;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += LevelnumericUpDown.Value;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += AttackTypenumericUpDown.Value;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += HpnumericUpDown.Value;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += ExpnumericUpDown.Value;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += LegendarycheckBox.Checked;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += ShinycheckBox.Checked;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += GenerationnumericUpDown.Value;

            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            outFile.Write(DebugtextBox.Text);
            outFile.Close();
        }
        private void DebugtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
