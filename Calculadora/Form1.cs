namespace Calculadora
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

        private void btn0_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "0";
        }

        private void btnpt_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + ".";
        }

        private void btnig_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "6";
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "+";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "9";
        }

        private void btnmen_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "X";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "/";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "3";
        }
    }
}