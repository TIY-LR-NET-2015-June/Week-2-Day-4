using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.Extensions
{
    public static class CharExtensions
    {
        //char myValue = 'A';
        //myValue.IsInt();
        public static bool IsInt(this char value)
        {
            bool isInt = false;
            switch (value)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    isInt = true;
                    break;
            }
            return isInt;
        }
    }
}
