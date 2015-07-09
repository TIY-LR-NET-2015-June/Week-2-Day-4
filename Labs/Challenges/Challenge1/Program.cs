using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var changeFactory = new ChangeFactory();
            var change = changeFactory.MakeChange(39);

            var coinsAsString = new StringBuilder();
            coinsAsString.Append("{ ");
            foreach (var coin in change)
            {
                coinsAsString.Append(string.Format("{0}, ", coin));
            }
            coinsAsString.Remove((coinsAsString.Length - 2), 2);
            coinsAsString.Append(" }");
            Console.WriteLine(coinsAsString.ToString());
        }
    }
}
