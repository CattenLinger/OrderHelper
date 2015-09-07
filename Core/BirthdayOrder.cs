using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerHelper.Core
{
    class BirthdayOrder : SelfOrder
    {
        private string wordsOnCake;
        public string WordsOnCake
        {
            get
            {
                return wordsOnCake;
            }
            set
            {
                wordsOnCake = value;
            }
        }

        public override decimal computeBudget()
        {
            decimal temp = base.computeBudget();
            if(numberOfPeople < 4)
            {
                temp += 150M;
            }
            else
            {
                temp += 280M;
            }
            temp += wordsOnCake.Length * 0.25M;
            if (IsVIP) temp *= 0.85M;
            return temp;
        }

    }
}
