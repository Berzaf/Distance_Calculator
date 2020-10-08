using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare variables 
            int speed;
            int hours;
            int distance;
            if (int.TryParse(txtSpeed.Text, out speed) && int.TryParse(txtHours.Text, out hours) && speed >= 1 && hours >= 1)
            {
                for (int i = 1; i <= hours; i++)
                {
                    distance = speed * i;          // Calculate the distance.
                    txtOutput.Items.Add("After hour " + i + " the vehicle traveled " + distance.ToString("n") + " miles.");

                }
            }

            else
            {
                MessageBox.Show("Please enter valid numbers", "Invalid Input");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all the input and output controls.

            txtSpeed.Text = "";
            txtHours.Text = "";
            txtSpeed.Focus();                // Set focus to TextBox.
            txtOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
