using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            // Display a message about me
            MessageBox.Show("My name is Cori, I'm 23 years old." +
                " I love being outside with nature." +
                " And in my free time I like to draw and design");
        }

        private void familyButton_Click(object sender, EventArgs e)
        {
            // Display a message about family
            MessageBox.Show("Meet my Dad Corey, Mom Dannielle, and Little Sister Gemma" +
                " We love to travel" +
                " As a family we have been to over 10 states thus far.");
        }

        private void myPictureBox_Click(object sender, EventArgs e)
        {
            //Display the picture of my family
            familyPictureBox.Visible = true;
            myPictureBox.Visible = false;
        }

        private void familyPictureBox_Click(object sender, EventArgs e)
        {
            //Display the picture of me
            myPictureBox.Visible = true;
            familyPictureBox.Visible=false;

        }
    }
}
