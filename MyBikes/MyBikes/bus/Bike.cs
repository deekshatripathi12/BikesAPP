using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBikes.bus
{

    [XmlInclude(typeof(Mountain))]
    [XmlInclude(typeof(Road))]
    public abstract class Bike
    {
        private string serialNumber;
        private string brand;
        private string model;
        private double speed;
        private EnumColor color;
        private Date madeDate;

        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public double Speed { get => speed; set => speed = value; }
        public Date MadeDate { get => madeDate; set => madeDate = value; }
        public EnumColor Color { get => color; set => color = value; }

        public Bike()
        {
            this.SerialNumber = "undefined";
            this.Brand = "undefined";
            this.Model = "undefined";
            this.Speed = 0.0;
            this.Color = EnumColor.Undefined;
            //this.MadeDate.Day = 0;
            //this.MadeDate.Month = 0;
            //this.MadeDate.Year = 0;
        }
        public Bike(string serialNumber, string brand, string model, double speed,EnumColor color,Date madeDate)
        {
            this.SerialNumber = serialNumber;
            this.Brand = brand;
            this.Model = model;
            this.Speed = speed;
            this.Color = color;
            //this.MadeDate.Day = madeDate.Day;
            //this.MadeDate.Month = madeDate.Month;
            //this.MadeDate.Year = madeDate.Year;
        }

        public override string ToString()
        {
            return SerialNumber + " \t " + Brand + " \t " + Model + " \t " + Speed 
                    + " \t " +Color+" \t "+ MadeDate;
        }

    }
}
