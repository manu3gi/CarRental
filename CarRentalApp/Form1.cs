using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtDateRented.Value;
                var dateIn = dtDateReturned.Value;
                var carType = cbTypeOfCar.Text;
                double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                var ErrorMessage = "";
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                   ErrorMessage+="Error: Please enter the missing data";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                   ErrorMessage+="\nError: Illegal date selection";
                }

                if (isValid == true)
                {
                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                        $"Date Rented: {dateOut}\n\r" +
                        $"Date Returned: {dateIn}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Car Type: {carType}\n\r" +
                        "THANK YOU FOR YOUR BUSINESS!");
                }
                else
                    MessageBox.Show(ErrorMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
    }
}
