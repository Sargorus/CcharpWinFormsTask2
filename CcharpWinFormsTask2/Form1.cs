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

            textBoxInitialDeposit.Text = Properties.Settings.Default.initialDeposit.ToString();
            textBoxLimitDeposit.Text = Properties.Settings.Default.limitDeposit.ToString();
            textBoxLimitIncomeDeposit.Text = Properties.Settings.Default.limitIncomeDeposit.ToString();
        }

        private void buttonMonthIncrease_Click(object sender, EventArgs e)
        {
            double initialDeposit;
            double limitIncomeDeposit;

            double monthIncrease;

            try
            {
                initialDeposit = double.Parse(this.textBoxInitialDeposit.Text);
                limitIncomeDeposit = double.Parse(this.textBoxLimitIncomeDeposit.Text);

            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.initialDeposit = initialDeposit;
            Properties.Settings.Default.limitIncomeDeposit = limitIncomeDeposit;
            Properties.Settings.Default.Save();
            monthIncrease = Logic.CompareMonthWhenIncreaseExceeds(initialDeposit, limitIncomeDeposit);
            MessageBox.Show($"Ежемесячный процент дохода превысит {limitIncomeDeposit}  через {monthIncrease} мес.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double initialDeposit;
            double limitDeposit;

            double monthsExceed;

            try
            {
                initialDeposit = double.Parse(this.textBoxInitialDeposit.Text);
                limitDeposit = double.Parse(this.textBoxLimitDeposit.Text);
            }
            catch (FormatException)
            {
                return;
            }
            Properties.Settings.Default.initialDeposit = initialDeposit;
            Properties.Settings.Default.limitDeposit = limitDeposit;
            Properties.Settings.Default.Save();
            monthsExceed = Logic.CompareMonthsExceedSum(initialDeposit, limitDeposit);
            MessageBox.Show($"Размер вклада превысит {limitDeposit}  через {monthsExceed} мес.");
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
