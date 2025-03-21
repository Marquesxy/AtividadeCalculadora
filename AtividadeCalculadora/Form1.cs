namespace AtividadeCalculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Sum,
            Sub,
            Mult,
            Div
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Sum;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblResult.Text = "+";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Sub;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblResult.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Mult;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblResult.Text = "X";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Div;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblResult.Text = "/";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Sum:
                    Resultado = Valor + Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Sub:
                    Resultado = Valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Mult:
                    Resultado = Valor * Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Div:
                    Resultado = Valor / Convert.ToDecimal(txtResult.Text);
                    break;
            }
            txtResult.Text = Convert.ToString(Resultado);
            lblResult.Text = "=";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblResult.Text = "";
        }
    }

}
