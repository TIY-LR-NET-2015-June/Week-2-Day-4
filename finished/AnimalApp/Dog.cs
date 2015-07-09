using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public IList<string> Bark(int numberofTreats)
        {
            var response = new List<string>();

            if (numberofTreats != 0)
            {
                response.Add("Woof");
            }

            return response;
        }
    }
}
