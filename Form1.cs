using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string banlist;
        public string bbanlist;
        private void button1_Click(object sender, EventArgs e)
        {
            {
                banlist = Environment.CurrentDirectory + "\\banlist1.txt";
                File.Delete(banlist);
                File.Copy(Environment.CurrentDirectory + "\\banlist.txt",banlist);
                try {
                    bbanlist = File.ReadAllLines(banlist).Last();
                }
                catch { }

                if (!bbanlist.Contains("Juky"))
                {
                    if ("Juky".Contains("Vaessa") == true && textBox1.Text.Contains(".Ban ") == true || "Juky".Contains("SindreMA") == true && textBox1.Text.Contains(".Ban ") == true || "Juky".Contains("Tobíì") == true && textBox1.Text.Contains(".Ban ") == true || "Juky".Contains("gambinooooooo") == true && textBox1.Text.Contains(".Ban ") == true || "Juky".Contains("shabbus") == true && textBox1.Text.Contains(".Ban ") == true)
                    {
                        string potato = textBox1.Text.Replace(".Ban ", "");

                        File.AppendAllText(banlist, potato + ",");

                        MessageBox.Show(potato + " is banned!");
                    }
                    if (textBox1.Text.Contains(".gif link") == true)
                    {
                        MessageBox.Show("The current video link is :   ");
                    }
                }
            }

        }
    }
}
