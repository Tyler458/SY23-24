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
    struct Pokimon
    {
        string Name;
        string Type;
        int Level;
        attack AttackType;
        int Hp;
        int Exp;
        bool Legendary;
        bool Shiny;
        int Generation;
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
                inFile.Close();
            }
            

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
