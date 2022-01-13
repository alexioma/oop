namespace lab2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.BankComboBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.HousePrice = new System.Windows.Forms.NumericUpDown();
			this.Deposit = new System.Windows.Forms.NumericUpDown();
			this.Period = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HousePrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Deposit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Period)).BeginInit();
			this.SuspendLayout();
			// 
			// BankComboBox
			// 
			this.BankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BankComboBox.FormattingEnabled = true;
			this.BankComboBox.Location = new System.Drawing.Point(12, 49);
			this.BankComboBox.Name = "BankComboBox";
			this.BankComboBox.Size = new System.Drawing.Size(219, 30);
			this.BankComboBox.TabIndex = 0;
			this.BankComboBox.SelectedIndexChanged += new System.EventHandler(this.BankComboBox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(408, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 348);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(113, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 32);
			this.button1.TabIndex = 16;
			this.button1.Text = "Рассчитать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(222, 205);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 19);
			this.label10.TabIndex = 15;
			this.label10.Text = "label10";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12.25F);
			this.label9.Location = new System.Drawing.Point(3, 205);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 21);
			this.label9.TabIndex = 14;
			this.label9.Text = "Сумма кредита";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(222, 142);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 19);
			this.label8.TabIndex = 13;
			this.label8.Text = "label8";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12.25F);
			this.label7.Location = new System.Drawing.Point(3, 142);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 21);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ставка";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 32);
			this.label6.TabIndex = 11;
			this.label6.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(214, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "Ежемесячный платеж";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Банк";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(241, 53);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(129, 26);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Семейная";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// HousePrice
			// 
			this.HousePrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.HousePrice.Location = new System.Drawing.Point(12, 133);
			this.HousePrice.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
			this.HousePrice.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.HousePrice.Name = "HousePrice";
			this.HousePrice.Size = new System.Drawing.Size(219, 31);
			this.HousePrice.TabIndex = 4;
			this.HousePrice.ThousandsSeparator = true;
			this.HousePrice.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.HousePrice.ValueChanged += new System.EventHandler(this.HousePrice_ValueChanged);
			// 
			// Deposit
			// 
			this.Deposit.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.Deposit.Location = new System.Drawing.Point(12, 216);
			this.Deposit.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
			this.Deposit.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.Deposit.Name = "Deposit";
			this.Deposit.Size = new System.Drawing.Size(219, 31);
			this.Deposit.TabIndex = 5;
			this.Deposit.ThousandsSeparator = true;
			this.Deposit.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.Deposit.ValueChanged += new System.EventHandler(this.Deposit_ValueChanged);
			// 
			// Period
			// 
			this.Period.Location = new System.Drawing.Point(12, 291);
			this.Period.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.Period.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Period.Name = "Period";
			this.Period.Size = new System.Drawing.Size(219, 31);
			this.Period.TabIndex = 6;
			this.Period.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Period.ValueChanged += new System.EventHandler(this.Period_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(313, 22);
			this.label2.TabIndex = 7;
			this.label2.Text = "Стоимость недвижимости, руб.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(389, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "Первоначальный взнос, руб. (min = 10%)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "Срок";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(237, 225);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 22);
			this.label11.TabIndex = 10;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(237, 298);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 22);
			this.label12.TabIndex = 11;
			this.label12.Text = "label12";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 348);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Period);
			this.Controls.Add(this.Deposit);
			this.Controls.Add(this.HousePrice);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BankComboBox);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Form1";
			this.Text = "Калькулятор кредита";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.HousePrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Deposit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Period)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox BankComboBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown HousePrice;
		private System.Windows.Forms.NumericUpDown Deposit;
		private System.Windows.Forms.NumericUpDown Period;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}

