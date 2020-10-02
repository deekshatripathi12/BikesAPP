using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{

    [Serializable]
    public class Mountain : Bike
    {
        private EnumSuspension suspension;
        private double heightFromGround;
        public EnumSuspension Suspension { get => suspension; set => suspension = value; }
        public double HeightFromGround { get => heightFromGround; set => heightFromGround = value; }

        public Mountain() : base()
        {
            this.Suspension = EnumSuspension.Undefined;
            this.HeightFromGround = 0.0;
        }

        public Mountain(string serialNumber, string brand, string model, double speed, EnumColor color, Date madeDate, EnumSuspension suspension, double heightFromGround) : base(serialNumber, brand, model, speed, color, madeDate)
        {
            this.Suspension = suspension;
            this.HeightFromGround = heightFromGround;
        }

        public override string ToString()
        {
            return SerialNumber + " \t \t " + Brand + " \t\t " + Model + " \t " + Speed
                    + " \t " + Color + " \t " + Suspension + " \t " + HeightFromGround 
                    + " \t " + MadeDate;
        }
    }
}
