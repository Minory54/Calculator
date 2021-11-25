using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        double creditАmount, interestRate, paymentMonth, totalPayment, overpayment, ptm; // переменны для Задания 1
        double loanRepayment, interestPayment, totalPaymentDet, RemainingPay, ppmt, ipmt; // переменны для Задания 2
        int month;

		private void Clear_btn_Click(object sender, EventArgs e)
		{
            Clear_btn.Visible = false;
            Details_table.Rows.Clear();

        }

        private void CreditАmount_txt_KeyPress(object sender, KeyPressEventArgs e)
		{
            //Цифры
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (CreditАmount_txt.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;

        }

		private void InterestRate_txt_KeyPress(object sender, KeyPressEventArgs e)
		{
            //Цифры
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (InterestRate_txt.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

		private void Years_txt_KeyPress(object sender, KeyPressEventArgs e)
		{
            //Цифры
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

		private void button1_Click(object sender, EventArgs e)
		{

            if (CreditАmount_txt.Text != "" && InterestRate_txt.Text != "" && Years_txt.Text != "")
            {
                creditАmount = Convert.ToDouble(CreditАmount_txt.Text); // сумма кредита
                interestRate = Convert.ToDouble(InterestRate_txt.Text)/100/12; // процентная ставка
                month = Convert.ToInt32(Years_txt.Text)*12; // количество платежей (месяцев)

                ptm = - interestRate * (creditАmount * Math.Pow(1 + interestRate, month))/(Math.Pow(1 + interestRate, month)- 1); // выплата в месяц
                paymentMonth = Math.Round(ptm, 2);
                totalPayment = paymentMonth * month; // общая сумма выплат
                overpayment = totalPayment - creditАmount; // сумма переплат


                Month_txt.Text = Convert.ToString(month);
                PaymentMonth_txt.Text = Convert.ToString(paymentMonth);
                TotalPayment_txt.Text = Convert.ToString(totalPayment);
                Overpayment_txt.Text = Convert.ToString(overpayment);

                int rowIndex = Details_table.Rows.Add(month);

                // выплата кредита
                for (int i = 0; i < month; i++)
                {
                    Details_table.Rows[i].Cells[0].Value = i + 1;

                    // выплата кредита
                    ppmt = Math.Pow(1 + interestRate, i - month) * paymentMonth;
                    loanRepayment = Math.Round(ppmt, 2);
                    Details_table.Rows[i].Cells[1].Value = loanRepayment;

                    // выплата процентов 
                    ipmt = -(((creditАmount * Math.Pow(1 + interestRate, (i + 1) - 1)) + (paymentMonth * ((Math.Pow(1 + interestRate, (i + 1) - 1) - 1)) / interestRate)) * interestRate);
                    interestPayment = Math.Round(ipmt, 2);
                    Details_table.Rows[i].Cells[2].Value = interestPayment;

                    // общая выплата
                    totalPaymentDet = loanRepayment + interestPayment;
                    Details_table.Rows[i].Cells[3].Value = totalPaymentDet;

                    // осталось выплатить
                    double ressum = 0;
                    double sum = 0;
                    double[,] array = new double[i, 1];

                    foreach (DataGridViewRow row in this.Details_table.Rows)
                    {
                        sum += Convert.ToDouble(row.Cells[1].Value);
                        ressum = Math.Round(sum);
                    }
                    RemainingPay = creditАmount + ressum;
                    Details_table.Rows[i].Cells[4].Value = RemainingPay;

                    Clear_btn.Visible = true;
                }

            }
            else 
            {
                MessageBox.Show("Не все поля ввода заполнены", "Предупреждение");
            }

		}






	}
}
