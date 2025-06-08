using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(txtX1.Text, CultureInfo.InvariantCulture);
                double x2 = double.Parse(txtX2.Text, CultureInfo.InvariantCulture);
                int variant = int.Parse(txtVariant.Text);
                int lastDigit = variant % 10;

                double result = x1 * x2;
                string formattedResult = FormatValue(result, lastDigit);
                lblResult.Text = $"f(x1, x2) = {formattedResult}";

                double extraResult = 0;
                string extraText = "";

                if (lastDigit >= 0 && lastDigit <= 3)
                {
                    extraResult = (x1 + x2) / 2.0;
                    extraText = $"Середнє: {FormatValue(extraResult, lastDigit)}";
                }
                else if (lastDigit >= 4 && lastDigit <= 6)
                {
                    extraResult = Math.Min(x1, x2);
                    extraText = $"Мінімальне: {FormatValue(extraResult, lastDigit)}";
                }
                else if (lastDigit >= 7 && lastDigit <= 9)
                {
                    extraResult = Math.Max(x1, x2);
                    extraText = $"Максимальне: {FormatValue(extraResult, lastDigit)}";
                }

                lblExtra.Text = extraText;
            }
            catch
            {
                MessageBox.Show("Перевірте правильність введених даних.");
            }
        }

        private string FormatValue(double value, int lastDigit)
        {
            if (lastDigit >= 0 && lastDigit <= 3)
                return value.ToString("F4");
            else if (lastDigit >= 4 && lastDigit <= 6)
                return value.ToString("F3");
            else
                return value.ToString("E2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            txtVariant.Clear();
            lblResult.Text = "";
            lblExtra.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
