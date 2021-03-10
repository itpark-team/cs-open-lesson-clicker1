using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кликер
{
    public partial class Form1 : Form
    {
        int score = 0;
        int click = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = score + click; //score += 1; //score++;
            label1.Text = "Очки: " + score;
            if (score > 1000)
            {
                MessageBox.Show("ВЫ ПОБЕДИЛИ!!!!!");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = score - 50;
            label1.Text = "Очки: " + score;
            click = click + 1;
        }
    }
}
