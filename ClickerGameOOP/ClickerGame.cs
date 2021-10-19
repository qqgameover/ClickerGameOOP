using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameOOP
{
    public class ClickerGame
    {
        public int Points { get; set; }
        public int PointsPerClick { get; set; }
        public int PointsClickLevel { get; set; }

        public ClickerGame()
        {
            Points = 0;
            PointsPerClick = 1;
            PointsClickLevel = 1;
        }
        public void Click()
        {
            Points += PointsPerClick;
        }
        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            PointsPerClick += PointsClickLevel;
        }
        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            PointsClickLevel++;
        }
    }
}
