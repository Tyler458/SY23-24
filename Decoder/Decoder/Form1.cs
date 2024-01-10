using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    label1.Text += "1";
                    break;
                case 'b':
                    label1.Text += "-";
                    break;
                case 'c':
                    label1.Text += "+";
                    break;
                case 'd':
                    label1.Text += "p";
                    break;
                case 'e':
                    label1.Text += "]";
                    break;
                case 'f':
                    label1.Text += "_";
                    break;
                case 'g':
                    label1.Text += "7";
                    break;
                case 'h':
                    label1.Text += "<";
                    break;
                case 'i':
                    label1.Text += "5";
                    break;
                case 'j':
                    label1.Text += "c";
                    break;
                case 'k':
                    label1.Text += "#";
                    break;
                case 'l':
                    label1.Text += "^";
                    break;
                case 'm':
                    label1.Text += "|";
                    break;
                case 'n':
                    label1.Text += "~";
                    break;
                case 'o':
                    label1.Text += "?";
                    break;
                case 'p':
                    label1.Text += "$";
                    break;
                case 'q':
                    label1.Text += "0";
                    break;
                case 'r':
                    label1.Text += "j";
                    break;
                case 's':
                    label1.Text += "%";
                    break;
                case 't':
                    label1.Text += "!";
                    break;
                case 'u':
                    label1.Text += "g";
                    break;
                case 'v':
                    label1.Text += "/";
                    break;
                case 'w':
                    label1.Text += "8";
                    break;
                case 'x':
                    label1.Text += "{";
                    break;
                case 'y':
                    label1.Text += "6";
                    break;
                case 'z':
                    label1.Text += "*";
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    label2.Text += "a";
                    break;
                case '-':
                    label2.Text += "b";
                    break;
                case '+':
                    label2.Text += "c";
                    break;
                case 'p':
                    label2.Text += "d";
                    break;
                case ']':
                    label2.Text += "e";
                    break;
                case '_':
                    label2.Text += "f";
                    break;
                case '7':
                    label2.Text += "g";
                    break;
                case '<':
                    label2.Text += "h";
                    break;
                case '5':
                    label2.Text += "i";
                    break;
                case 'c':
                    label2.Text += "j";
                    break;
                case '#':
                    label2.Text += "k";
                    break;
                case '^':
                    label2.Text += "l";
                    break;
                case '|':
                    label2.Text += "m";
                    break;
                case '~':
                    label2.Text += "n";
                    break;
                case '?':
                    label2.Text += "o";
                    break;
                case '$':
                    label2.Text += "p";
                    break;
                case '0':
                    label2.Text += "q";
                    break;
                case 'j':
                    label2.Text += "r";
                    break;
                case '%':
                    label2.Text += "s";
                    break;
                case '!':
                    label2.Text += "t";
                    break;
                case 'g':
                    label2.Text += "u";
                    break;
                case '/':
                    label2.Text += "v";
                    break;
                case '8':
                    label2.Text += "w";
                    break;
                case '{':
                    label2.Text += "x";
                    break;
                case '6':
                    label2.Text += "y";
                    break;
                case '*':
                    label2.Text += "z";
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
        }
    }
}
