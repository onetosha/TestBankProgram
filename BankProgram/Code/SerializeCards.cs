using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankLibrary;

namespace BankProgram
{
    [Serializable]
    public class SerializeCards
    {
        public List<GiftCardAccount> GiftCardList { get; set; } = new List<GiftCardAccount>();
        public List<InterestEarningAccount> InterestEarningList { get; set; } = new List<InterestEarningAccount>();
        public List<LineOfCreditAccount> LineOfCreditList { get; set; } = new List<LineOfCreditAccount>();
        public SerializeCards()
        {
            
        }
    }
}
