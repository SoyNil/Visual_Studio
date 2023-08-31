namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.ClsDiv obj1 = new Clases.ClsDiv();
        Clases.ClsMulti obj2 = new Clases.ClsMulti();
        Clases.ClsResta obj3 = new Clases.ClsResta();
        Clases.ClsSuma obj4 = new Clases.ClsSuma();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "0";
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

        private void btndel_Click(object sender, EventArgs e)
        {
            Caja.Clear();
        }
        private void btnel_Click(object sender, EventArgs e)
        {
            if (Caja.Text.Length == 1)
                Caja.Text = "";
            else
                Caja.Text = Caja.Text.Substring(0, Caja.Text.Length - 1);
        }
        private void btnmen_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Caja.Text);
            Caja.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = "X";
            primero = double.Parse(Caja.Text);
            Caja.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Caja.Text);
            Caja.Clear();
        }
        private void btnig_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Caja.Text);
            double Sum;
            double Rest;
            double Mul;
            double Di;
            switch (operador)
            {
                case "+":
                    Sum = obj4.Suma((primero), (segundo));
                    Caja.Text = Sum.ToString();
                    break;
                case "-":
                    Rest = obj3.Resta((primero), (segundo));
                    Caja.Text = Rest.ToString();
                    break;
                case "X":
                    Mul = obj2.Multi((primero), (segundo));
                    Caja.Text = Mul.ToString();
                    break;
                case "/":
                    Di = obj1.Div((primero), (segundo));
                    Caja.Text = Di.ToString();
                    break;
            }
        }
        private void btnpt_Click(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + ".";
        }
        private void btnsum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Caja.Text);
            Caja.Clear();
        }
    }
}