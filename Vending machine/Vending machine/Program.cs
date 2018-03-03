using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_Vending
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine V1 = new VendingMachine();
            V1.DepositCoin(75);
            V1.GetDrink();
            V1.GetRefund();
        }
    }

    class VendingMachine
    {
        private int _DepositedAmount;
        const int _CostOfDrink = 75;

        public VendingMachine()
        {

            _DepositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            _DepositedAmount += coinAmount;
        }

        public void GetDrink()
        {
            if(_DepositedAmount >= 75)
            {
                Console.WriteLine("Your change is {0} cents", _DepositedAmount - _CostOfDrink );
                DepositCoin(0);
            }

            else if(_DepositedAmount < 75)
            {
                Console.WriteLine("Insert more coins");
            }
        }

        public void GetRefund()
        {
            Console.WriteLine("You were refunded {0}", _DepositedAmount);
            DepositCoin(0);
        }
    }
}
