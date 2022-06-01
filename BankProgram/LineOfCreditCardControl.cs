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
    public partial class LineOfCreditCardControl : Form
    {
        public LineOfCreditCardControl(LineOfCreditAccount card)
        {
            InitializeComponent();
            lblName.Text = card.Name;
            lblBalance.Text = card.Balance.ToString();
        }
    }
}
