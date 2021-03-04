using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Timers;

namespace towerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.start();
            Thread.Sleep(10000);
            game.stop();
        }

        
    }

   
}
