using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class ChangeItem
    {
        public int CoinValue { get; set; }
        public int CoinCount { get; set; }
        public int Value
        {
            get
            {
                return this.CoinValue * this.CoinCount;
            }
        }

        public IList<int> ToCoinList()
        {
            var coins = new List<int>();

            for (int i = 0; i < this.CoinCount; ++i)
            {
                coins.Add(this.CoinValue);
            }

            return coins;
        }
    }
}
