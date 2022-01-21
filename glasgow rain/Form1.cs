using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glasgow_rain
{
    public partial class Form1 : Form
    {
        double[] glasgowRain = { 5.6, 4.0, 4.9, 4.3, 4.5, 2.3, 5.3, 5.6, 4.6, 4.6, 3.6, 4.2, 3.9, 3.8, 4.6, 3.6, 3.8, 5.3 };
        double[] liverpoolRain = { 4.1, 2.7, 3.9, 2.4, 4.0, 2.4, 3.8, 4.5, 2.7, 3.0, 2.4, 4.3, 3.2, 2.4, 4.0, 3.6, 2.8, 3.9 };
        double[] aylesburyRain = { 3.2, 1.9, 2.6, 2.4, 2.3, 2.9, 1.3, 2.5, 2.5, 2.0, 1.9, 2.5, 1.3, 1.0, 2.8, 1.2, 2.1, 2.1 };


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            listBoxRain.Items.Clear();

            if (cmbLocation.Text == "Glasgow")
            { 
                listBoxRain.Items.Add(Math.Round(glasgowRain.Min(), 2) + " " + "mm"); 
            }

            if (cmbLocation.Text == "Liverpool")
            {
                listBoxRain.Items.Add(Math.Round(liverpoolRain.Min(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Aylesbury")
            {
                listBoxRain.Items.Add(Math.Round(aylesburyRain.Min(), 2) + "" + "mm");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            listBoxRain.Items.Clear();

            if (cmbLocation.Text == "Glasgow")
            {
                listBoxRain.Items.Add(Math.Round(glasgowRain.Max(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Liverpool")
            {
                listBoxRain.Items.Add(Math.Round(liverpoolRain.Max(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Aylesbury")
            {
                listBoxRain.Items.Add(Math.Round(aylesburyRain.Max(), 2) + "" + "mm");
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            listBoxRain.Items.Clear();
            
            if (cmbLocation.Text == "Glasgow")
            {
                listBoxRain.Items.Add(Math.Round(glasgowRain.Average(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Liverpool")
            {
                listBoxRain.Items.Add(Math.Round(liverpoolRain.Average(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Aylesbury")
            {
                listBoxRain.Items.Add(Math.Round(aylesburyRain.Average(), 2) + "" + "mm");
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            listBoxRain.Items.Clear();

            if (cmbLocation.Text == "Glasgow")
            {
                listBoxRain.Items.Add(Math.Round(glasgowRain.Sum(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Liverpool")
            {
                listBoxRain.Items.Add(Math.Round(liverpoolRain.Sum(), 2) + "" + "mm");
            }

            if (cmbLocation.Text == "Aylesbury")
            {
                listBoxRain.Items.Add(Math.Round(aylesburyRain.Sum(), 2) + "" + "mm");
            }
        }
    }
}
