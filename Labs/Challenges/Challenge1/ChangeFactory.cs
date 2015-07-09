using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class ChangeFactory
    {
        public ChangeFactory()
        {
            //do nothing
        }

        public IList<ChangeItem> CreateUsChangeItems()
        {
            const int QUARTER_VALUE = 25;
            const int DIME_VALUE = 10;
            const int NICKLE_VALUE = 5;
            const int PENNY_VALUE = 1;

            var changeItems = new List<ChangeItem>()
            {
                new ChangeItem() { CoinValue = QUARTER_VALUE },
                new ChangeItem() { CoinValue = DIME_VALUE },
                new ChangeItem() { CoinValue = NICKLE_VALUE },
                new ChangeItem() { CoinValue = PENNY_VALUE }
            };

            return changeItems;
        }

        public IList<int> MakeChange(int value)
        {
            bool worked = false;
            var coins = new List<int>();

            var usChangeItems = this.CreateUsChangeItems();
            foreach (var changeItem in usChangeItems)
            {
                changeItem.CoinCount = value / changeItem.CoinValue;
                value = value - changeItem.Value;
                coins.AddRange(changeItem.ToCoinList());
            }

            if (value == 0)
            {
                //everything was good
                worked = true;
            }

            return coins;
        }
    }
}
