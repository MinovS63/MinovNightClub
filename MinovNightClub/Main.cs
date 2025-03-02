namespace MinovNightClub
{
    public partial class Main : Form
    {
        public static int depositSum = 0;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Activated(object sender, EventArgs e)
        {
            UpdateBalanceLabel();
        }
        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"BALANCE: {depositSum}lv";
        }
        private void btnReserv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dates dates = new Dates(depositSum);
            dates.Show();
        }

        //Vuzmojno nai chistiq kod ot moq strana (shefche) / The cleanest code from my side (the chef)
        private void btn1_Click(object sender, EventArgs e) => depositCalculation(1);
        private void btn2_Click(object sender, EventArgs e) => depositCalculation(2);
        private void btn3_Click(object sender, EventArgs e) => depositCalculation(3);
        private void btn4_Click(object sender, EventArgs e) => depositCalculation(4);
        private void btn5_Click(object sender, EventArgs e) => depositCalculation(5);
        private void btn6_Click(object sender, EventArgs e) => depositCalculation(6);
        private void btn7_Click(object sender, EventArgs e) => depositCalculation(7);
        private void btn8_Click(object sender, EventArgs e) => depositCalculation(8);
        private void btn9_Click(object sender, EventArgs e) => depositCalculation(9);
        private void btn0_Click(object sender, EventArgs e) => depositCalculation(0);
        private void btnClear_Click(object sender, EventArgs e) => txtDeposit.Clear();
        private void depositCalculation(int num)
        {
            txtDeposit.Text += num;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int deposit = int.Parse(txtDeposit.Text);
                depositSum += deposit;
                if (depositSum > 999)
                {
                    depositSum -= deposit;
                    MessageBox.Show("The maximum amount you can deposit is 999lv");
                    txtDeposit.Clear();
                }
                else
                {
                    UpdateBalanceLabel();
                    txtDeposit.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }

        }

        
    }
}
