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
        private int current;
        private int count;
        private Pokemon[] pokemons;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            Currentlabel.Text = current.ToString();
            pokemons = new Pokemon[50];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Pokemon p = ReadPokemon(S);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                ShowPokemon(pokemons[0]);

            }


        }
        private Pokemon ReadPokemon(string s)
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
          
            return p;
        }
        public void save()
        {
            string tmp = " ";
            tmp += NametextBox.Text;
            tmp += "|";
            tmp += TypetextBox.Text;
            tmp += "|";
            tmp += LevelnumericUpDown.Value;
            tmp += "|";
            tmp += AttackTypecomboBox.Text;
            tmp += "|";
            tmp += HpnumericUpDown.Value;
            tmp += "|";
            tmp += ExpnumericUpDown.Value;
            tmp += "|";
            tmp += LegendarycheckBox.Checked;
            tmp += "|";
            tmp += ShinycheckBox.Checked;
            tmp += "|";
            tmp += GenerationnumericUpDown.Value;
            pokemons[current] = ReadPokemon(tmp);
            
            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(PokemonToString(pokemons[i]));
            }
            outFile.Close();
            //outFile.Write(DebugtextBox.Text);
            //outFile.Close();
        }

        private string PokemonToString(Pokemon p)
        {
            string retVal = "";
            retVal += p.Name;
            retVal += "|";
            retVal += p.Type.ToString();
            retVal += "|";
            retVal += p.Level.ToString();
            retVal += "|";
            retVal += p.AttackType.ToString();
            retVal += "|";
            retVal += p.Hp.ToString();
            retVal += "|";
            retVal += p.Exp.ToString();
            retVal += "|";
            retVal += p.Legendary.ToString();
            retVal += "|";
            retVal += p.Shiny.ToString();
            retVal += "|";
            retVal += p.Generation.ToString();
            return retVal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save();
            
        }
        private void ShowPokemon(Pokemon p)
        {
            NametextBox.Text = p.Name;
            TypetextBox.Text = p.Type;
            LevelnumericUpDown.Value = p.Level;
            AttackTypecomboBox.Text = p.AttackType.ToString();
            HpnumericUpDown.Value = p.Hp;
            ExpnumericUpDown.Value = p.Exp;
            LegendarycheckBox.Checked = p.Legendary;
            ShinycheckBox.Checked = p.Shiny;
            GenerationnumericUpDown.Value = p.Generation;



        }

        private void Firstbutton_Click(object sender, EventArgs e)
        {
            save();
            current = 0;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            save();
            current = count -1;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                save();
                current--;
                Currentlabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);

            }

        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if (current < count -1)
            {
                save();
                current++;
                Currentlabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);

            }
        }
        private void clear()
        {
            NametextBox.Text = " ";
            TypetextBox.Text = " ";
            LevelnumericUpDown.Value = 0;
            AttackTypecomboBox.Text = " ";
            HpnumericUpDown.Value = 0;
            ExpnumericUpDown.Value = 0;
            LegendarycheckBox.Checked = false;
            ShinycheckBox.Checked = false;
            GenerationnumericUpDown.Value = 0;

        }
        private void Newbutton_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
            clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }
    }
}
