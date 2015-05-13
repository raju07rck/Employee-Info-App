using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class accountOperationUI : Form
    {
        public accountOperationUI()
        {
            InitializeComponent();
        }

        private Account nAccount = new Account();

        private void createButton_Click(object sender, EventArgs e)
        {
            nAccount.accountNbr = accountNumberTextBox.Text;
            nAccount.customerName = customerNameTextBox.Text;
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();

            MessageBox.Show("Account Created Successfully \n" + "customer Name = " + nAccount.customerName + "\n" +
                            "Account Number = " + nAccount.accountNbr);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);

            if (amount <= 0)
            {
                MessageBox.Show("This is not deposit amount");
            }
            else
            {
                nAccount.Deposit(amount);
                MessageBox.Show("Your Balance is " + nAccount.balance);
                amountTextBox.Clear();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double tk = Convert.ToDouble(amountTextBox.Text);
            if (tk < 0)
            {
                MessageBox.Show("Don't Use Negetive Value");
            }
            else if (nAccount.balance <tk)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                nAccount.Withdraw(tk);
                MessageBox.Show("Total Balance after Withdraw " + nAccount.balance);
                amountTextBox.Clear();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
            {
                MessageBox.Show(nAccount.customerName + " , your account number: " + nAccount.accountNbr +
                                " and it's balance: " + nAccount.balance + " taka.");
            }
        }
    }
