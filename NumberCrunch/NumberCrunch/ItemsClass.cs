using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunch
{
    class ItemsClass
    {
        private double currentPrice = 0;
        private string itemName = "Error!";

        public void SetCurrentPrice(double price)
        {
            currentPrice = price;
        }

        public void SetItemName(string name)
        {
            itemName = name;
        }

        public double GetCurrentPrice(int amount = 1)
        {
            currentPrice = currentPrice * amount;
            return currentPrice;
        }

        public string GetItemName()
        {
            return itemName;
        }


    }
}
