using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountMoneySpending
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            var mainStr = rtb_money_spending.Text.Trim();
            var linesOld = mainStr.Split('\n');
            int sum = 0;

            foreach (var line in linesOld)
            {
                var items = line.Split('-');
                sum += int.Parse(items[0].Trim());
            }

            tb_sum.Text = sum.ToString();
        }
    }
}
