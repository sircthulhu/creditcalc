using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double percent = 0;
            int time = 0;
            //TODO: Выводить ошибки
            if (!double.TryParse(tbSum.Text, out sum) || 
                !double.TryParse(tbPercent.Text, out percent) ||
                !int.TryParse(tbTime.Text, out time))
            {
                return;
            }

            percent /= (12d * 100d); //Месячная процентная ставка

            var ratio = GetAnnuityRatio(percent, time);
            var payment = ratio * sum;
            lbSum.Text = Math.Round(payment * time, 2).ToString();
            lbOverpayment.Text = Math.Round(payment * time - sum, 2).ToString();
            lbPayment.Text = (Math.Round(payment, 2)).ToString();
        }



        public static double GetAnnuityRatio(double monthPercent, int payments)
        {
            return monthPercent * Math.Pow(1 + monthPercent, payments) / (Math.Pow(1 + monthPercent, payments) - 1);
        }

        private void btPaymentsGraph_Click(object sender, EventArgs e)
        {

        }
    }
}
