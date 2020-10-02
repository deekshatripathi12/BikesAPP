using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Xml;
using System.Xml.Serialization;

namespace MyBikes.bus
{
    public class FileHandler : IFileHandler
    {
        private static String xmlBike = @"../../data/xml/bike.xml";
        private static String xmlBikeMountain = @"../../data/xml/mountain.xml";
        private static String xmlBikeRoad = @"../../data/xml/road.xml";

        //private static String txtBike = @"../../data/txt/bike.txt";
        //private static String txtBikeMountain = @"../../data/txt/mountain.txt";
        //private static String txtBikeRoad = @"../../data/txt/road.txt";

        //private static String binBike = @"../../data/bin/bike.bin";
        //private static String binBikeMountain = @"../../data/bin/mountain.bin";
        //private static String binBikeRoad = @"../../data/bin/road.bin";

        // *** XML FILE
        public void SaveToXmlMountain(List<Mountain> listBikeMountain)
        {
            XmlWriter writer = XmlWriter.Create(xmlBikeMountain);    
            XmlSerializer serializer = new XmlSerializer(typeof(List<Mountain>));
            serializer.Serialize(writer, listBikeMountain);
            writer.Close();
        }
        public void SaveToXmlRoad(List<Road> listBikeRoad)
        {
            XmlWriter writer = XmlWriter.Create(xmlBikeRoad);  
            XmlSerializer serializer = new XmlSerializer(typeof(List<Road>));
            serializer.Serialize(writer, listBikeRoad);
            writer.Close();
        }
        public void SaveToXmlBike(List<Bike> listBike)
        {
            XmlWriter writer = XmlWriter.Create(xmlBike); 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bike>));
            serializer.Serialize(writer, listBike);
            writer.Close();

            //XmlDocument xd = new XmlDocument();
            //xd.Load(xmlBike);
            //XmlNode nl = xd.SelectSingleNode("//Bike");
            //xd.AppendChild(listBike);
            //XmlDocument xd2 = new XmlDocument();
            //xd2.LoadXml("<Employee><ID>20</ID><FirstName>Clair</FirstName><LastName>Doner</LastName><Salary>13000</Salary></Employee>");
            
            //XmlNode n = xd.ImportNode(xd2.FirstChild, true);
            //nl.AppendChild(n);
            //xd.Save(Console.Out);


        }
        
        public List<Mountain> ReadFromXmlMountain(List<Mountain> listBikeMountain)
        {
            listBikeMountain.Clear();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Mountain>));
            StreamReader reader = new StreamReader(xmlBikeMountain);
            listBikeMountain = (List<Mountain>)xmlSerializer.Deserialize(reader);

            reader.Close();

            return listBikeMountain;
        }
         public List<Road> ReadFromXmlRoad(List<Road> listBikeRoad)
        {
            listBikeRoad.Clear();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Road>));
            StreamReader reader = new StreamReader(xmlBikeRoad);
            listBikeRoad = (List<Road>)xmlSerializer.Deserialize(reader);

            reader.Close();

            return listBikeRoad;
        }
         public List<Bike> ReadFromXmlBike(List<Bike> listBike)
        {
            listBike.Clear();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            StreamReader reader = new StreamReader(xmlBike);
            listBike = (List<Bike>)xmlSerializer.Deserialize(reader);

            reader.Close();

            return listBike;
        }

        //// *** TXT FILE
        //public void SaveToTxtMountain(List<Mountain> listBikeMountain)
        //{
        //    using (StreamWriter writer = File.CreateText(txtBikeMountain))
        //    {
        //        foreach (Mountain mountain in listBikeMountain)
        //        {

        //            writer.WriteLine(mountain.SerialNumber + "|" + mountain.Brand
        //                + "|" + mountain.Model + "|" + mountain.Speed
        //                + "|" + mountain.Color + "|" + mountain.Suspension
        //                + "|" + mountain.HeightFromGround + "|" + mountain.MadeDate);
        //        }
        //    }
        //}
        //public void SaveToTxtRoad(List<Road> listBikeRoad)
        //{
        //    using (StreamWriter writer = File.CreateText(txtBikeRoad))
        //    {
        //        foreach (Road road in listBikeRoad)
        //        {

        //            writer.WriteLine(road.SerialNumber + "|" + road.Brand
        //                + "|" + road.Model + "|" + road.Speed
        //                + "|" + road.Color + "|" + road.SeatHeight
        //                + "|" + road.MadeDate);
        //        }
        //    }
        //}
        //public void SaveToTxtBike(List<Bike> listBike)
        //{
        //    using (StreamWriter writer = File.CreateText(txtBike))
        //    {
        //        foreach (Bike bike in listBike)
        //        {

        //            writer.WriteLine(bike.SerialNumber + "|" + bike.Brand
        //                + "|" + bike.Model + "|" + bike.Speed
        //                + "|" + bike.Color + "|" + bike.MadeDate);
        //        }
        //    }
        //}
        //public List<Mountain> ReadFromTextFileMountain()
        //{
        //    List<Mountain> temporaryMountainList = new List<Mountain>();

        //    StreamReader reader = new StreamReader(txtBikeMountain);

        //    String line = null; line = reader.ReadLine();

        //    while (line != null)
        //    {
        //        Mountain mountain = new Mountain();

        //        String[] tokens = line.Split('|');

        //        mountain.SerialNumber = tokens[0];
        //        mountain.Brand = tokens[1];
        //        mountain.Model = tokens[2];
        //        mountain.Speed = Convert.ToDouble(tokens[3]);
        //        mountain.Color = (EnumColor)Enum.Parse(typeof(EnumColor), tokens[4]);
        //        mountain.Suspension = (EnumSuspension)Enum.Parse(typeof(EnumSuspension), tokens[5]);
        //        mountain.HeightFromGround = Convert.ToDouble(tokens[6]);

        //        string date = tokens[6];
        //        string[] d = line.Split('/');

        //        mountain.MadeDate.Day = Convert.ToInt32(d[0]);
        //        mountain.MadeDate.Month = Convert.ToInt32(d[1]);
        //        mountain.MadeDate.Year = Convert.ToInt32(d[2]);
        //        //return SerialNumber + " \t \t " + Brand + " \t\t " + Model + " \t " + Speed
        //        //    + " \t " + Color + " \t " + Suspension + " \t " + HeightFromGround
        //        //    + " \t " + MadeDate;

        //        temporaryMountainList.Add(mountain);

        //        line = reader.ReadLine();

        //    }
        //    reader.Close();

        //    return temporaryMountainList;
        //}

        //// *** BINARY FILE
        //public void SaveToBinMountain(List<Mountain> listBikeMountain)
        //{
        //    FileStream fs = new FileStream(binBikeMountain, FileMode.OpenOrCreate, FileAccess.Write);
        //    BinaryFormatter writer = new BinaryFormatter();
        //    writer.Serialize(fs, listBikeMountain);
        //    fs.Close();
        //}
        //public void SaveToBinRoad(List<Road> listBikeRoad)
        //{
        //    FileStream fs = new FileStream(binBikeRoad, FileMode.OpenOrCreate, FileAccess.Write);
        //    BinaryFormatter writer = new BinaryFormatter();
        //    writer.Serialize(fs, listBikeRoad);
        //    fs.Close();
        //}
        //public void SaveToBinBike(List<Bike> listBike)
        //{
        //    FileStream fs = new FileStream(binBike, FileMode.OpenOrCreate, FileAccess.Write);
        //    BinaryFormatter writer = new BinaryFormatter();
        //    writer.Serialize(fs, listBike);
        //    fs.Close();
        //}

    }
}