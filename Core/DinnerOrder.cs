using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerHelper.Core
{
    class DinnerOrder : SelfOrder
    {
        private bool isDirect;
        public bool IsDirect
        {
            get
            {
                return isDirect;
            }
            set
            {
                isDirect = value;
            }
        }

        public override decimal computeBudget()
        {
            decimal costWitiDirect = personCost + (isDirect? 40:20);
            decimal temp = numberOfPeople * costWitiDirect;
            if (IsVIP) temp *= 0.85M;
            return temp;
        }
    }
}
