
namespace Сalculator
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.Years_txt = new System.Windows.Forms.TextBox();
			this.InterestRate_txt = new System.Windows.Forms.TextBox();
			this.CreditАmount_txt = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Overpayment_txt = new System.Windows.Forms.TextBox();
			this.TotalPayment_txt = new System.Windows.Forms.TextBox();
			this.PaymentMonth_txt = new System.Windows.Forms.TextBox();
			this.Month_txt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Details_table = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label11 = new System.Windows.Forms.Label();
			this.Clear_btn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(19, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма кредита";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(19, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Процентная ставка (без знака %)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(19, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Срок (в годах)";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panel1.Controls.Add(this.Clear_btn);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.Years_txt);
			this.panel1.Controls.Add(this.InterestRate_txt);
			this.panel1.Controls.Add(this.CreditАmount_txt);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 44);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(16);
			this.panel1.Size = new System.Drawing.Size(360, 295);
			this.panel1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Window;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(123, 241);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Рассчитать";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Years_txt
			// 
			this.Years_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Years_txt.Location = new System.Drawing.Point(23, 186);
			this.Years_txt.Name = "Years_txt";
			this.Years_txt.Size = new System.Drawing.Size(318, 25);
			this.Years_txt.TabIndex = 3;
			this.Years_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Years_txt_KeyPress);
			// 
			// InterestRate_txt
			// 
			this.InterestRate_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.InterestRate_txt.Location = new System.Drawing.Point(23, 113);
			this.InterestRate_txt.Name = "InterestRate_txt";
			this.InterestRate_txt.Size = new System.Drawing.Size(318, 25);
			this.InterestRate_txt.TabIndex = 2;
			this.InterestRate_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InterestRate_txt_KeyPress);
			// 
			// CreditАmount_txt
			// 
			this.CreditАmount_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CreditАmount_txt.Location = new System.Drawing.Point(23, 40);
			this.CreditАmount_txt.Name = "CreditАmount_txt";
			this.CreditАmount_txt.Size = new System.Drawing.Size(318, 25);
			this.CreditАmount_txt.TabIndex = 1;
			this.CreditАmount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditАmount_txt_KeyPress);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.Overpayment_txt);
			this.panel2.Controls.Add(this.TotalPayment_txt);
			this.panel2.Controls.Add(this.PaymentMonth_txt);
			this.panel2.Controls.Add(this.Month_txt);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Location = new System.Drawing.Point(428, 44);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(16);
			this.panel2.Size = new System.Drawing.Size(360, 237);
			this.panel2.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(19, 199);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(131, 21);
			this.label10.TabIndex = 0;
			this.label10.Text = "Сумма переплат:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(19, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(167, 21);
			this.label9.TabIndex = 0;
			this.label9.Text = "Общая сумма выплат:";
			// 
			// Overpayment_txt
			// 
			this.Overpayment_txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.Overpayment_txt.Cursor = System.Windows.Forms.Cursors.Default;
			this.Overpayment_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Overpayment_txt.Location = new System.Drawing.Point(156, 199);
			this.Overpayment_txt.Name = "Overpayment_txt";
			this.Overpayment_txt.ReadOnly = true;
			this.Overpayment_txt.Size = new System.Drawing.Size(185, 25);
			this.Overpayment_txt.TabIndex = 1;
			// 
			// TotalPayment_txt
			// 
			this.TotalPayment_txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.TotalPayment_txt.Cursor = System.Windows.Forms.Cursors.Default;
			this.TotalPayment_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TotalPayment_txt.Location = new System.Drawing.Point(192, 134);
			this.TotalPayment_txt.Name = "TotalPayment_txt";
			this.TotalPayment_txt.ReadOnly = true;
			this.TotalPayment_txt.Size = new System.Drawing.Size(149, 25);
			this.TotalPayment_txt.TabIndex = 1;
			// 
			// PaymentMonth_txt
			// 
			this.PaymentMonth_txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.PaymentMonth_txt.Cursor = System.Windows.Forms.Cursors.Default;
			this.PaymentMonth_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PaymentMonth_txt.Location = new System.Drawing.Point(158, 77);
			this.PaymentMonth_txt.Name = "PaymentMonth_txt";
			this.PaymentMonth_txt.ReadOnly = true;
			this.PaymentMonth_txt.Size = new System.Drawing.Size(183, 25);
			this.PaymentMonth_txt.TabIndex = 1;
			// 
			// Month_txt
			// 
			this.Month_txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.Month_txt.Cursor = System.Windows.Forms.Cursors.Default;
			this.Month_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Month_txt.Location = new System.Drawing.Point(149, 16);
			this.Month_txt.Name = "Month_txt";
			this.Month_txt.ReadOnly = true;
			this.Month_txt.Size = new System.Drawing.Size(192, 25);
			this.Month_txt.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(19, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 21);
			this.label8.TabIndex = 0;
			this.label8.Text = "Выплата в месяц:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(19, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "Срок в месяцах:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(110, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 30);
			this.label4.TabIndex = 4;
			this.label4.Text = "Введите данные";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Window;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(555, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 30);
			this.label5.TabIndex = 4;
			this.label5.Text = "Результат";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Location = new System.Drawing.Point(378, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 40);
			this.label6.TabIndex = 5;
			this.label6.Text = "➔";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panel3.Controls.Add(this.Details_table);
			this.panel3.Location = new System.Drawing.Point(12, 389);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(776, 246);
			this.panel3.TabIndex = 3;
			// 
			// Details_table
			// 
			this.Details_table.AllowUserToAddRows = false;
			this.Details_table.AllowUserToDeleteRows = false;
			this.Details_table.AllowUserToResizeColumns = false;
			this.Details_table.AllowUserToResizeRows = false;
			this.Details_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Details_table.BackgroundColor = System.Drawing.SystemColors.Window;
			this.Details_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Details_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.Details_table.Location = new System.Drawing.Point(23, 20);
			this.Details_table.MultiSelect = false;
			this.Details_table.Name = "Details_table";
			this.Details_table.ReadOnly = true;
			this.Details_table.RowHeadersVisible = false;
			this.Details_table.Size = new System.Drawing.Size(734, 205);
			this.Details_table.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Период";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Выплата кредита";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Выплата процентов";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Общая выплата";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Осталось выплатить";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(329, 351);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(142, 30);
			this.label11.TabIndex = 4;
			this.label11.Text = "Детализация";
			// 
			// Clear_btn
			// 
			this.Clear_btn.BackColor = System.Drawing.SystemColors.Window;
			this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clear_btn.Location = new System.Drawing.Point(123, 241);
			this.Clear_btn.Name = "Clear_btn";
			this.Clear_btn.Size = new System.Drawing.Size(119, 35);
			this.Clear_btn.TabIndex = 2;
			this.Clear_btn.Text = "Очистка";
			this.Clear_btn.UseVisualStyleBackColor = false;
			this.Clear_btn.Visible = false;
			this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 647);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Кредитный калькулятор";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox CreditАmount_txt;
		private System.Windows.Forms.TextBox InterestRate_txt;
		private System.Windows.Forms.TextBox Years_txt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Overpayment_txt;
		private System.Windows.Forms.TextBox TotalPayment_txt;
		private System.Windows.Forms.TextBox PaymentMonth_txt;
		private System.Windows.Forms.TextBox Month_txt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView Details_table;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button Clear_btn;
	}
}

