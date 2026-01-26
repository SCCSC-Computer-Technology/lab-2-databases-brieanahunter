/*
 * Brieana Hunter
 * CPT 206 A01H
 * Lab 2
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BHunter_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = 0;

            total = cityDBDataSet.City.Sum(row => row.Population);
            txtTotal.Text = total.ToString();
            txtTotal.Visible = true;
            lblTotal.Visible = true;
            btnTotal.Visible = false;
            btnHideTotal.Visible = true;

        }


        private void btnAverage_Click(object sender, EventArgs e)
        {
            double average = 0;

            average = cityDBDataSet.City.Average(row => row.Population);
            txtAverage.Text = average.ToString();
            btnHideAverage.Visible = true;
            btnAverage.Visible = false;
            txtAverage.Visible = true;
            lblAverage.Visible = true;
        }



        private void btnLowest_Click(object sender, EventArgs e)
        {
            double lowest = 0;

            lowest = cityDBDataSet.City.Min(row => row.Population);
            txtLowest.Text = lowest.ToString();
            btnLowest.Visible = false;
            btnHideLowest.Visible = true;
            txtLowest.Visible = true;
            lblLowest.Visible = true;
        }


        private void btnHighest_Click(object sender, EventArgs e)
        {
            double highest = 0;
            highest = cityDBDataSet.City.Max(row => row.Population);
            txtHighest.Text = highest.ToString();
            txtHighest.Visible = true;
            lblHighest.Visible = true;
            btnHighest.Visible = false;
            btnHideHighest.Visible = true;
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex == 0)
            {
                cityBindingSource.Sort = "Population ASC";
            }
            else if (cbxSort.SelectedIndex == 1)
            {
                cityBindingSource.Sort = "Population DESC";
            }
            else
            {
                cityBindingSource.Sort = "City ASC";
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHideAverage_Click_1(object sender, EventArgs e)
        {
            btnHideAverage.Visible = false;
            btnAverage.Visible = true;
            txtAverage.Visible = false;
            lblAverage.Visible = false;
        }

        private void btnHideTotal_Click_1(object sender, EventArgs e)
        {
            btnHideTotal.Visible = false;
            btnTotal.Visible = true;
            txtTotal.Visible = false;
            lblTotal.Visible = false;
        }

        private void btnHideLowest_Click_1(object sender, EventArgs e)
        {
            btnHideLowest.Visible = false;
            btnLowest.Visible = true;
            txtLowest.Visible = false;
            lblLowest.Visible = false;
        }

        private void btnHideHighest_Click_1(object sender, EventArgs e)
        {
            btnHideHighest.Visible = false;
            btnHighest.Visible = true;
            txtHighest.Visible = false;
            lblHighest.Visible = false;
        }
    }
}




