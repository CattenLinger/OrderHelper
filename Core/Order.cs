using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerHelper.Core
{
    abstract class  Order
    {
        protected string orderTitle;
        protected string phoneNumber;
        protected int numberOfPeople;
        protected DateTime orderDate;
        protected decimal personCost;

        public string OrderTitle
        {
            get
            {
                return orderTitle;
            }
            set
            {
                orderTitle = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public abstract decimal computeBudget();
    }
}
