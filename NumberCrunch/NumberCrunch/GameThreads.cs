using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumberCrunch
{
    class GameThreads
    {
        public static void StartGameThreads()
        {
            Thread updateScreenThread = new Thread(new ThreadStart(UpdateScreenThread));
            Thread updatePriceThread = new Thread(new ThreadStart(UpdatePriceThread));


            //    updateScreenThread.Start();
            //   updatePriceThread.Start();
        }

        public static void UpdatePriceThread()
        {
            Form1 form1 = new Form1();
            while (true)
            {
                form1.PriceUpdating();
                Thread.Sleep(2000);
            }
        }

        public static void UpdateScreenThread()
        {
            Form1 form1 = new Form1();
            while (true)
            {
             //   form1.UpdateScreen(currentItemID, currentAmount);
                Thread.Sleep(1000);
            }
        }
    }
}
