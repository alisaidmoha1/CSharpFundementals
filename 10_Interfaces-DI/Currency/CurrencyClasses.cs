using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_DI.Currency
{
    public class Penny : ICurrency
    {
        public string Name => "Penny"; //Phat arrow or Lambda, => is a way to simplify bodies, in this context it makes those properties read only, no set.


        public decimal Value => 0.01m;
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";

        public decimal Value => 0.1m;
    }

    public class Dollar : ICurrency
    {
        //public string Name {get;} = "Dollar";
        //public string Name {
        //get {
        // return "Dollar";
        //}
        //
        //}

        public string Name => "Dollar";

        public decimal Value => 1.00m;

        /*private string _symbol = "USD";
        public string Symbol
        {
            get
            {
                return _symbol;
            }

            set
            {
                _symbol = value;
            }
        }*/
    }

    public class ElectronicPayment : ICurrency
    {
        public string Name => "Electronic Payment";
        public decimal Value { get;  }

        public ElectronicPayment(decimal paymentValue)
        {
            Value = paymentValue;
        }
    }
}
