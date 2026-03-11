using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CcharpWinFormsTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMonthIncrease_Click(object sender, EventArgs e)
        {
            double initialDeposit;
            double limitIncomeDeposit;
            double limitDeposit;

            double monthIncrease;
            double monthsExceed;

            try
            {
                initialDeposit = double.Parse(this.textBoxInitialDeposit.Text);
                limitIncomeDeposit = double.Parse(this.textBoxLimitIncomeDeposit.Text);
                limitDeposit = double.Parse(this.textBoxLimitDeposit.Text);
            }
            catch (FormatException)
            {
                return;
            }
            MessageBox.Show("(╯°□°）╯︵ ┻━┻");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double initialDeposit;
            double limitIncomeDeposit;
            double limitDeposit;

            double monthIncrease;
            double monthsExceed;

            try
            {
                initialDeposit = double.Parse(this.textBoxInitialDeposit.Text);
                limitIncomeDeposit = double.Parse(this.textBoxLimitIncomeDeposit.Text);
                limitDeposit = double.Parse(this.textBoxLimitDeposit.Text);
            }
            catch (FormatException)
            {
                return;
            }
            MessageBox.Show("(╯°□°）╯︵ ┻━┻");
        }
    }


    public class Logic
    {
        public static int CompareMonthWhenIncreaseExceeds(double initialDeposit, double limitIncomeDeposit)
        {
            int mount = 1;
            double currentDeposit = initialDeposit;

            while (true)
            {
                double incomeDeposit = currentDeposit * 0.02;
                if (incomeDeposit > limitIncomeDeposit)
                {
                    return mount;
                }
                else
                {
                    currentDeposit = currentDeposit + incomeDeposit;
                    mount += 1;
                }
                //Console.WriteLine(currentDeposit);
                //Console.WriteLine(IncomeDeposit);
                //Console.WriteLine(mount);
            }

        }

        public static int CompareMonthsExceedSum(double InitialDeposit, double LimitDeposit)
        {
            int mount = 0;
            double currentDeposit = InitialDeposit;

            while (currentDeposit <= LimitDeposit)
            {
                currentDeposit = currentDeposit + (currentDeposit * 0.02);
                mount += 1;
                //Console.WriteLine(currentDeposit);
                //Console.WriteLine(mount);
            }
            return mount;

        }

    }
}
