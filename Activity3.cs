using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_3
{
    public partial class YTD : Form
    {
        public YTD()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Hold value to the checks TextBox
            double Check1;
            double Check2;
            double Check3;
            double projected;

            // Get the 3 checks input
            Check1 = double.Parse(check1TextBox.Text);
            Check2 = double.Parse(check2TextBox.Text);
            Check3 = double.Parse(check3TextBox.Text);

            try
            {
                if (weeklyRadioButton.Checked)
                {
                    // Calculation per weekly
                    projected = (Check1 + Check2 + Check3) / 3;
                    projected = (projected * 56);
                    projected = (projected / 12);

                    // display the projected 
                    outputLabel.Text = projected.ToString("n1");
                }
                else if (biweeklyRadioButton.Checked)
                {
                    // Calculation per Biweekly
                    projected = (Check1 + Check2 + Check3) / 3;
                    projected = (projected * 26);
                    projected = (projected / 12);

                    // display the projected 
                    outputLabel.Text = projected.ToString("n1");
                }
                else if (semiRadioButton.Checked)
                {
                    // Calculation per semi monthly
                    projected = (Check1 + Check2 + Check3) / 3;
                    projected = (projected * 24);
                    projected = (projected/ 12);

                    // display the projected 
                    outputLabel.Text = projected.ToString("n1");
                }
                else if (monthlyRadioButton.Checked)
                {
                    // Calculation per monthly
                    projected = (Check1 + Check2 + Check3) / 3;
                    projected = (projected * 12);
                    projected = (projected / 12);
                    // display the projected
                    outputLabel.Text = projected.ToString("n1");
                }
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clearing textboxes 
            check1TextBox.Text = "";
            check2TextBox.Text = "";
            check3TextBox.Text = "";
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the form 
            this.Close();
        }
    }
}

