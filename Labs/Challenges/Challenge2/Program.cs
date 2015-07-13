using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write code to test the credit card Validator
            var creditCard = new CreditCard()
            {
                Value = "4408 0412 3456 7893 ABC"
            };

            if (creditCard.Length == 16)
            {
                Console.WriteLine("Credit card is 16 digits!");
            }
        }
    }
}
