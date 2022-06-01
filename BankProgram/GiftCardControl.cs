using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bankLibrary;

namespace BankProgram
{
    public partial class GiftCardControl : Form
    {
        GiftCardAccount Card;
        public GiftCardControl(GiftCardAccount card)
        {
            Card = card;
            InitializeComponent();
            lblName.Text = Card.Name;
            lblBalance.Text = Card.Balance.ToString();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(tbMakeDeposit.Text) > 0)
            {
                Card.MakeDeposit(Convert.ToDecimal(tbMakeDeposit.Text), DateTime.Now, "MadeFromApplication");
                lblBalance.Text = Card.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Невозможно совершить данную операцию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void GiftCardControl_Load(object sender, EventArgs e)
        {

        }

        private void btnMakeWithdrawal_Click(object sender, EventArgs e)
        {
            if (Card.Balance - Convert.ToDecimal(tbMakeWithdrawal.Text) > 0)
            {
                Card.MakeWithdrawal(Convert.ToDecimal(tbMakeWithdrawal.Text), DateTime.Now, "MadeFromApplication");
                lblBalance.Text = Card.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Невозможно совершить данную операцию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void tbMakeDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMakeDeposit_Click(sender, e);
            }
        }

        private void tbMakeWithdrawal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMakeWithdrawal_Click(sender, e);
            }
        }
    }
}
