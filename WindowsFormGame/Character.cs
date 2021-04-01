using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGame
{
    public partial class Character : Form
    {
        public static string karatkerNev;
        public static Color szinem;
        public Character()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                karakter.BackColor = Color.Brown;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                karakter.BackColor = Color.LightCoral;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                karakter.BackColor = Color.Coral;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                karakter.BackColor = Color.Sienna;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                karakter.BackColor = Color.DarkKhaki;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                karakter.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Select color");
            }

            szinem = karakter.BackColor;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(192, 255, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(192, 255, 192);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(karakterBox.Text == "")
            {
                MessageBox.Show("Please write character name!");
            }
            else
            {
                karatkerNev = karakterBox.Text;

                if(comboBox1.Text == "")
                {
                    MessageBox.Show("Please select character color!");
                }
                else
                {
                    this.Hide();
                    Playground p = new Playground();
                    p.Show();
                }
                
            }
           
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
       
    }
}
