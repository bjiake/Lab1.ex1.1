using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(UserLength.Text);
            double radius = Convert.ToDouble(UserRadius.Text);
            double radiusInternal = Convert.ToDouble(UserInternalRadius.Text);
            double density = Convert.ToDouble(UserDensity.Text);
            double volume, weigth;
            if(length == 0 || radiusInternal == 0 || radiusInternal == 0 || density == 0 || radius < radiusInternal )
            {
                UserLength.Text = "";
                UserDensity.Text = "";
                UserRadius.Text = "";
                UserInternalRadius.Text = "";
                UserDensity.Text = "";
                MessageBox.Show("Введены некорректные данные");
                return;
            }

            volume = length * Math.PI * (Math.Pow(radius, 2) * Math.Pow(radiusInternal, 2));
            weigth = volume * density;

            MessageBox.Show($"Масса трубы:{Convert.ToString(Math.Round(weigth, 6)}\n Объем трубы равен: {Convert.ToString(Math.Round(volume, 6))}");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number == 45 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void UserRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number == 45 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void UserInternalRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number == 45 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Density_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number == 45 && number != 44) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
