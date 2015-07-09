using Challenge2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class CreditCard
    {
        public string Value { get; set; }
        public bool IsValid()
        {
            bool isValid = false;

            //TODO: Loop through each digit
            //        if the digit is an odd digit then 
            //              double it and split into single digits
            //        else just add it

            return isValid;
        }

        public int Length
        {
            get
            {
                int length = (from digit in this.Value.ToCharArray()
                              where !char.IsWhiteSpace(digit) &&
                                    digit.IsInt()
                              select digit).Count();

                int lengthWithMethodSyntax = this.Value.ToCharArray()
                                                        .Where(v => !char.IsWhiteSpace(v) && v.IsInt())
                                                        .Count();
                return length;
            }
        }
    }
}
