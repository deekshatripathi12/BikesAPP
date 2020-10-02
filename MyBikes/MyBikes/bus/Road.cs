using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class Road : Bike
    {
        private double seatHeight;

        public double SeatHeight { get => seatHeight; set => seatHeight = value; }

        public Road():base()
        {
            this.SeatHeight = 0.0;
        }
        public Road(string serialNumber, string brand, string model, double speed, EnumColor color, Date madeDate,double seatHeight) : base(serialNumber, brand, model, speed, color, madeDate)
        {
            this.SeatHeight = seatHeight;
        }

        public override string ToString()
        {
            return SerialNumber + " \t \t " + Brand + " \t\t " + Model + " \t\t " + Speed
                    + " \t\t " + Color + " \t\t " + SeatHeight + " \t\t " + MadeDate;
        }
    }
}
