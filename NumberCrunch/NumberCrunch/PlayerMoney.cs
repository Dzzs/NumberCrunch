using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunch
{
    class PlayerMoney
    {
        private double currentBalance = 50.00;
        private Dictionary<int, int> itemsOwned = new Dictionary<int, int>();

        public void InitItemsOwned()
        {
            itemsOwned.Add(0, 55);
            itemsOwned.Add(1, 0);
            itemsOwned.Add(2, 0);
            itemsOwned.Add(3, 0);
            itemsOwned.Add(4, 0);
            itemsOwned.Add(5, 0);

        }

        public void SetItemesOwned(int itemID, int amount)
        {
            int lastAmount = itemsOwned[itemID];
            itemsOwned[itemID] = lastAmount + amount;
        }

        public void SubtractItemesOwned(int itemID, int amount)
        {
            int lastAmount = itemsOwned[itemID] - amount;
            itemsOwned[itemID] = lastAmount;

        }

        public int GetItemesOwned(int atIndex)
        {
            return itemsOwned[atIndex];
        }

        public void SubtractCurrentValue(double cost)
        {
            currentBalance = currentBalance - cost;
        }

        public void UpdateCurrentBalance(double value)
        {
            currentBalance = currentBalance + value;
        }

        public double GetCurrentBalance()
        {
            return Math.Round(currentBalance,2);
        }

    }
}
