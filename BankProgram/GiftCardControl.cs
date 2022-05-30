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
        public GiftCardControl(GiftCardAccount card)
        {
            InitializeComponent();
            lblName.Text = card.Name;
        }
    }
}
