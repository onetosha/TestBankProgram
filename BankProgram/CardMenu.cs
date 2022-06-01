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
    public partial class CardMenu : Form
    {
        public CardMenu()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        GiftCardAccount giftCardAccount = new GiftCardAccount("User", textBox1.Text, 0, 5);

                        ListViewItem listViewItem = new ListViewItem(giftCardAccount.Name);
                        listViewItem.Tag = giftCardAccount;

                        listViewGiftCards.Items.Add(listViewItem);

                        break;
                    }
                case 1:
                    {
                        LineOfCreditAccount lineOfCreditAccount = new LineOfCreditAccount("User", textBox1.Text, 0, 5);

                        ListViewItem listViewItem = new ListViewItem(lineOfCreditAccount.Name);
                        listViewItem.Tag = lineOfCreditAccount;

                        listViewCreditCards.Items.Add(listViewItem);

                        break;
                    }
                case 2:
                    {
                        InterestEarningAccount interestEarningAccount = new InterestEarningAccount("User", textBox1.Text, 0);

                        ListViewItem listViewItem = new ListViewItem(interestEarningAccount.Name);
                        listViewItem.Tag = interestEarningAccount;

                        listViewInterestEarningCards.Items.Add(listViewItem);

                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            ClearInput();
        }
        private void ClearInput()
        {
            textBox1?.Clear();
            comboBox1.SelectedIndex = 0;
        }
        private void btnUpdateList_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardMenu_Load(object sender, EventArgs e)
        {

        }

        private void listViewGiftCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGiftCards.SelectedItems.Count == 1)
            {
                btnOpenCardControl.Enabled = true;
                GiftCardAccount giftCardAccount = (GiftCardAccount)listViewGiftCards.SelectedItems[0].Tag;
                if (giftCardAccount != null)
                {
                    textBox1.Text = giftCardAccount.Name;
                    comboBox1.SelectedIndex = 0;
                }
            }
            else
            {
                btnOpenCardControl.Enabled = false;
            }
        }

        private void listViewCreditCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCreditCards.SelectedItems.Count == 1)
            {
                btnOpenCardControl.Enabled = true;
                LineOfCreditAccount lineOfCreditAccount = (LineOfCreditAccount)listViewCreditCards.SelectedItems[0].Tag;
                if (lineOfCreditAccount != null)
                {
                    textBox1.Text = lineOfCreditAccount.Name;
                    comboBox1.SelectedIndex = 1;
                }
            }
            else
            {
                btnOpenCardControl.Enabled = false;
            }
        }

        private void listViewInterestEarningCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInterestEarningCards.SelectedItems.Count == 1)
            {
                btnOpenCardControl.Enabled = true;
                InterestEarningAccount interestEarningAccount = (InterestEarningAccount)listViewInterestEarningCards.SelectedItems[0].Tag;
                if (interestEarningAccount != null)
                {
                    textBox1.Text = interestEarningAccount.Name;
                    comboBox1.SelectedIndex = 2;
                }
            }
            else
            {
                btnOpenCardControl.Enabled = false;
            }
        }
        private void ListViewItem_MouseDoubleClick(object sender, EventArgs e)
        {

        }
        private void btnOpenCardControl_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        GiftCardAccount giftCardAccount = (GiftCardAccount)listViewGiftCards.SelectedItems[0].Tag;
                        if (giftCardAccount != null)
                        {
                            GiftCardControl giftCardControl = new GiftCardControl(giftCardAccount);
                            giftCardControl.Show();
                        }
                        break;
                    }
                case 1:
                    {
                        LineOfCreditAccount lineOfCreditAccount = (LineOfCreditAccount)listViewCreditCards.SelectedItems[0].Tag;
                        if (lineOfCreditAccount != null)
                        {
                            LineOfCreditCardControl lineOfCreditCardControl = new LineOfCreditCardControl(lineOfCreditAccount);
                            lineOfCreditCardControl.Show();
                        }
                        break;
                    }
                case 2:
                    {
                        InterestEarningAccount interestEarningAccount = (InterestEarningAccount)listViewInterestEarningCards.SelectedItems[0].Tag;
                        if (interestEarningAccount != null)
                        {
                            InterestEarningCardControl interestEarningCardControl = new InterestEarningCardControl(interestEarningAccount);
                            interestEarningCardControl.Show();
                        }
                        break;
                    }
            }
        }
    }
    
}
