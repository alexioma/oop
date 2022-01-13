using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Form1 : Form
	{
		double rate = 0;
		string pct_lbl = " %";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BankComboBox.DisplayMember = "Text";
			BankComboBox.ValueMember = "Value";
			var items = new[] {
				new { Text = "Сбербанк", Value = 9.3},
				new { Text = "ВТБ", Value = 10.2},
				new { Text = "Райффайзенбанк", Value = 9.9},
				new { Text = "Открытие", Value = 9.7},
				new { Text = "Альфа банк", Value = 10.19}
			};
			BankComboBox.DataSource = items;
			label6.Text = CalculatePayment().ToString() + " руб.";
			label8.Text = IsCheckBox1Checked().ToString() + pct_lbl;
			label10.Text = CalculateCredit().ToString() + " руб.";
			label11.Text = CalculateDepositPerHousePrice().ToString() + pct_lbl;
			label12.Text = GetYearLabel();
		}

		private void BankComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			label8.Text = IsCheckBox1Checked().ToString() + pct_lbl;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			label8.Text = IsCheckBox1Checked().ToString() + pct_lbl;
		}

		private double IsCheckBox1Checked()
		{
			if (checkBox1.Checked)
			{
				rate = Convert.ToDouble(BankComboBox.SelectedValue) - 5.2;
			}
			else
			{
				rate = Convert.ToDouble(BankComboBox.SelectedValue);
			}
			return rate;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label6.Text = CalculatePayment().ToString() + " руб.";
		}

		private decimal CalculatePayment()
		{
			decimal monthRate = Convert.ToDecimal(rate / 100 / 12);
			int periodInMonths = (int)Period.Value * 12;
			decimal totalRate = Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + monthRate), periodInMonths));
			decimal creditSum = CalculateCredit();
			return Math.Round(creditSum * monthRate * totalRate / (totalRate - 1));
		}

		private void HousePrice_ValueChanged(object sender, EventArgs e)
		{
			ChangeDepositMinMaxValue();
			CalculateCredit();
		}

		private void ChangeDepositMinMaxValue()
		{
			Deposit.Minimum = Convert.ToDecimal((double)HousePrice.Value * 0.1);
			Deposit.Maximum = Convert.ToDecimal((double)HousePrice.Value * 0.9);
		}

		private void Deposit_ValueChanged(object sender, EventArgs e)
		{
			label10.Text = CalculateCredit().ToString() + " руб.";
			label11.Text = CalculateDepositPerHousePrice().ToString() + pct_lbl;
		}

		private double CalculateDepositPerHousePrice()
		{
			return Math.Round(Convert.ToDouble(Deposit.Value / HousePrice.Value) * 100, 1);
		}

		private decimal CalculateCredit()
		{
			return HousePrice.Value - Deposit.Value;
		}

		private void Period_ValueChanged(object sender, EventArgs e)
		{
			label12.Text = GetYearLabel();
		}

		private string GetYearLabel()
		{
			string[] years = { "год", "года", "лет" };
			int period = (int)Period.Value;
			return years[(period % 10 > 1 && period % 10 < 5 && period / 10 != 1) ? 1 : (period % 10 == 1 && period / 10 != 1) ? 0 : 2];
		}
	}
}
