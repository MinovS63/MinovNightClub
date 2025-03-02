using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinovNightClub
{
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            lblDrinksBalance.Text = $"BALANCE: {Main.depositSum}lv";
        }

        private void absolut_Click(object sender, EventArgs e) => Order(80);
        private void baileys_Click(object sender, EventArgs e) => Order(130);
        private void finland_Click(object sender, EventArgs e) => Order(80);
        private void perignon_Click(object sender, EventArgs e) => Order(650);
        private void smirnoff_Click(object sender, EventArgs e) => Order(90);
        private void jimbeam_Click(object sender, EventArgs e) => Order(90);

        private void Order(int price)
        {
            int depositSumBackUp = Main.depositSum;
            Main.depositSum -= price;
            if (Main.depositSum < 0)
            {
                MessageBox.Show("Not enough money");
                Main.depositSum = depositSumBackUp;
            }
            else
            {
                lblDrinksBalance.Text = $"BALANCE: {Main.depositSum}lv";
                MessageBox.Show("Succesful order!");
            }
        }
        private void return2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
