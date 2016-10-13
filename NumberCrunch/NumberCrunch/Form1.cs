using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NumberCrunch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startButton.BringToFront();

        }
        
        ItemsClass appleItemsClass = new ItemsClass();
        ItemsClass orangeItemClass = new ItemsClass();
        ItemsClass bananaItemClass = new ItemsClass();
        ItemsClass peachItemClass = new ItemsClass();
        ItemsClass strawberryItemClass = new ItemsClass();

        PriceGenerator priceGenerator = new PriceGenerator();



        PlayerMoney player = new PlayerMoney();

       public static int currentItemID = 1;
       public static int currentAmount = 1;

        #region fruit buttons

        private void appleButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.apple;
            currentItemID = 1;
            currentAmount = 1;
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void orangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.orange;
            currentItemID = 2;
            currentAmount = 1;
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void bananaButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.banana;
            currentItemID = 3;
            currentAmount = 1;
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void peachButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.peach;
            currentItemID = 4;
            currentAmount = 1;
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void strawberryButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentItemPicBox.BackgroundImage = global::NumberCrunch.Properties.Resources.strawberry;
            currentItemID = 5;
            currentAmount = 1;
            amountLabel.Text = "Amount: " + currentAmount;
        }
        #endregion 

        private void buyButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (player.GetCurrentBalance() >= (FindCurrentItemValue(currentItemID) * currentAmount)){
                player.SubtractCurrentValue(FindCurrentItemValue(currentItemID) * currentAmount);
                player.SetItemesOwned(currentItemID, currentAmount);
            }

        }

        private void sellButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (player.GetItemesOwned(currentItemID) > 0 && player.GetItemesOwned(currentItemID) >= currentAmount)
            {
                player.UpdateCurrentBalance(FindCurrentItemValue(currentItemID) * currentAmount);
                player.SubtractItemesOwned(currentItemID, currentAmount);
            }

        }


        #region amount buttons
        private void addToAmountButton_MouseUp(object sender, MouseEventArgs e)
        {
            FindCurrentAmount(1);
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void subtractFromAmountButton_MouseUp(object sender, MouseEventArgs e)
        {
            FindCurrentAmount(-1);
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void addTenButton_MouseUp(object sender, MouseEventArgs e)
        {
            FindCurrentAmount(10);
            amountLabel.Text = "Amount: " + currentAmount;
        }

        private void subtractTenButton_MouseUp(object sender, MouseEventArgs e)
        {
            FindCurrentAmount(-10);
            amountLabel.Text = "Amount: " + currentAmount;
        }

        #endregion

        public void InitializeGame()
        {
            appleItemsClass.SetItemName("Apple");
            orangeItemClass.SetItemName("Orange");
            bananaItemClass.SetItemName("Banana");
            peachItemClass.SetItemName("Peach");
            strawberryItemClass.SetItemName("Strawberry");
            player.InitItemsOwned();

        }

        public void FindCurrentAmount(int value = 0)
        {

            //add value
            if (value == 10 && currentAmount <= 90)
            {
                currentAmount = currentAmount + value;
            }
            if (value == 1 && currentAmount <= 99)
            {
                currentAmount = currentAmount + value;
            }
            //subtract value
            if (value == -10 && currentAmount >= 11)
            {
                currentAmount = currentAmount + value;
            }
            if ( value == -1 && currentAmount >= 2)
            {
                currentAmount = currentAmount + value;
            }
        }

        // Apple = 1, Orange = 2, Banana = 3, Peach = 4, Strawberry = 5,

        public double FindCurrentItemValue(int itemID)
        {
            switch (itemID)
            {
                case 1:
                    return appleItemsClass.GetCurrentPrice();
                case 2:
                    return orangeItemClass.GetCurrentPrice();
                case 3:
                    return bananaItemClass.GetCurrentPrice();
                case 4:
                    return peachItemClass.GetCurrentPrice();
                case 5:
                    return strawberryItemClass.GetCurrentPrice();
                default:
                    return 0.0;
            }
        }

        public string FindCurrentItem(int itemID)
        {
            switch (itemID)
            {
                case 1:
                    return appleItemsClass.GetItemName();
                case 2:
                    return orangeItemClass.GetItemName();
                case 3:
                    return bananaItemClass.GetItemName();
                case 4:
                    return peachItemClass.GetItemName();
                case 5:
                    return strawberryItemClass.GetItemName();
                default:
                    return "Error!";
            }
        }

        public void ThreadScreenUpdate(double currentPrice, double totalPrice, double balance, string itemName, int amountOwned)
        {
            this.Invoke((MethodInvoker)delegate
            {
                currentItemValueLabel.Text = "Current price: $" + currentPrice;
                currentTotalCostLabel.Text = "Total: $" + totalPrice;
                currentBalanceLabel.Text = "Balance: $" + balance;
                currentItemLabel.Text = itemName;
                itemsOwnedLabel.Text = "You have " + amountOwned + " " + itemName;

            });

        }

        public void UpdateScreen()
        {
            double currentPrice = FindCurrentItemValue(currentItemID);
            double totalPrice = (FindCurrentItemValue(currentItemID) * currentAmount);
            double balance = player.GetCurrentBalance();
            string itemName = FindCurrentItem(currentItemID);
            int amountOwned = player.GetItemesOwned(currentItemID);

            ThreadScreenUpdate(currentPrice, totalPrice, balance, itemName, amountOwned);
        }

        public void PriceUpdating()
        {
            appleItemsClass.SetCurrentPrice(Math.Round(priceGenerator.GetRandomDouble(0.75, 3.50), 2));
            orangeItemClass.SetCurrentPrice(Math.Round(priceGenerator.GetRandomDouble(0.75, 3.50), 2));
            bananaItemClass.SetCurrentPrice(Math.Round(priceGenerator.GetRandomDouble(0.75, 3.50), 2));
            peachItemClass.SetCurrentPrice(Math.Round(priceGenerator.GetRandomDouble(0.75, 3.50), 2));
            strawberryItemClass.SetCurrentPrice(Math.Round(priceGenerator.GetRandomDouble(0.75, 3.50), 2));
        }

        public void StartGameThreads()
        {
            Thread updateScreenThread = new Thread(new ThreadStart(UpdateScreenThread));
            Thread updatePriceThread = new Thread(new ThreadStart(UpdatePriceThread));

            updatePriceThread.IsBackground = true;
            updateScreenThread.IsBackground = true;

            updateScreenThread.Start();
            updatePriceThread.Start();
        }

        void UpdatePriceThread()
        {

            while (true)
            {
                PriceUpdating();
                Thread.Sleep(15000);
            }
        }

        void UpdateScreenThread()
        {

            while (true)
            {
                UpdateScreen();

                Thread.Sleep(100);
            }
        }



        private void startButton_MouseUp(object sender, MouseEventArgs e)
        {
            startButton.Hide();
            InitializeGame();
            StartGameThreads();
        }



    }
}
