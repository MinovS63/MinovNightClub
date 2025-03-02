using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinovNightClub
{
    public partial class Dates : Form
    {
        public Dates(int depositSum)
        {
            InitializeComponent();
        }
        private void Dates_Load(object sender, EventArgs e)
        {
            friday1pic.SizeMode = PictureBoxSizeMode.StretchImage;
            friday2pic.SizeMode = PictureBoxSizeMode.StretchImage;
            saturday1pic.SizeMode = PictureBoxSizeMode.StretchImage;
            saturday2pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnFriday1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks drinks = new Drinks();
            drinks.Show();
        }
        private void btnFriday2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks drinks = new Drinks();
            drinks.Show();
        }

        private void btnSaturday1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks drinks = new Drinks();
            drinks.Show();
        }

        private void btnSaturday2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks drinks = new Drinks();
            drinks.Show();
        }

        private void return1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        
    }
}
