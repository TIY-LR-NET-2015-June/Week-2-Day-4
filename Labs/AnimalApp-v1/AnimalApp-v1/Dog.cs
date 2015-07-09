using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp_v1
{
    public class Dog
    {
        public IList<string> Bark(int numberOfTreats)
        {
            var barks = new List<string>();

            if (numberOfTreats > 0)
            {
                for (int i = 0; i < numberOfTreats; ++i)
                {
                    barks.Add("Woof");
                }
            }

            return barks;
        }
    }
}
