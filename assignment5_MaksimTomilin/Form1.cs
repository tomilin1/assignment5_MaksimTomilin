using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5_MaksimTomilin
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();
            numberguess();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            guesses += 1;
            if (i == number)
            {
                textBox2.Text = "Congratulations, you guessed the number " + number + "!" + "\r" + "\n" + "You guessed " + guesses + " times";
                numberguess();
                textBox1.Text = "";
                guesses = 0;
            }
            else if (i < number)
            {
                textBox2.Text = "Too low, try again" + "\r" + "\n" + "You guessed " + guesses + " times";
            }
            else
            {
                textBox2.Text = "Too high, try again" + "\r" + "\n" + "You guessed " + guesses + " times";
            }

        }
       
        private void numberguess()
        {
            number = random.Next(1, 100);

        }
    }
}
