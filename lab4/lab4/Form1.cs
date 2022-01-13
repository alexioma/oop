using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.DisplayMember = "Text";
			comboBox1.ValueMember = "Value";
			var items = new[] { 
				new { Text = "Сбербанк", Value = 9.3},
				new { Text = "ВТБ", Value = 10.2},
				new { Text = "Райффайзенбанк", Value = 9.9},
				new { Text = "Открытие", Value = 9.7},
				new { Text = "Альфа банк", Value = 10.19}
			};
			comboBox1.DataSource = items;

			textBox3.Text = MultiplyDigits((int)numericUpDown1.Value).ToString();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = "Процентная ставка " + comboBox1.Text + " составляет " + comboBox1.SelectedValue + " %";
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			textBox3.Text = MultiplyDigits((int)numericUpDown1.Value).ToString();
		}

		private int MultiplyDigits(int n)
		{
			int product = 1;
			while (n > 0)
			{
				int digit = n % 10;
				product = digit > 0 ? product * digit : product;
				n /= 10;
			}
			return product;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				label2.Text = "Введите e-mail";
				textBox2.PasswordChar = '\0';
				label3.Visible = true;
			}
			else
			{
				label2.Text = "Введите пароль";
				textBox2.PasswordChar = '*';
				label3.Visible = false;
			}
		}
	}
}
