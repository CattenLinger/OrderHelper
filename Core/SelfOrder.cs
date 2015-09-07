using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerHelper.Core
{
    class SelfOrder : Order
    {
        private bool isVIP;
        public bool IsVIP
        {
            get
            {
                return isVIP;
            }
            set
            {
                isVIP = value;
            }
        }

        private bool isWaterServe;
        public bool IsWaterServe
        {
            get
            {
                return isWaterServe;
            }
            set
            {
                if (value)
                    personCost = 40M;
                else
                    personCost = 20M;
                isWaterServe = value;
            }
        }

        public override decimal computeBudget()
        {
            decimal temp = numberOfPeople * personCost;
            if (isVIP) temp *= 0.85M;
            return temp;
        }
    }
}
