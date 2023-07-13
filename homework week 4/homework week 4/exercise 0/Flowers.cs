using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4
{
    public class Flowers
    {
        public Flowers() 
        {
            this.flowerName = flowerName;
            this.plantingMonth = plantingMonth;
            this.floweringSeason = floweringSeason;
            this.price = price;
        }
        public string flowerName;
        public string plantingMonth;
        public string floweringSeason;
        public string color;
        public int price;
        public int SetPrice(int price)
        { this.price = price; 
            return price; }
        public int GrowPrice(int price) 
        {
            this.price = price * 2;
            return price; }
        public string FlowerColor()
        { return flowerName+"-"+color; }
    }
}
