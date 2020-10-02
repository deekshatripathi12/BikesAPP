using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    interface IFileHandler
    {
        void SaveToXmlMountain(List<Mountain> listBikeMountain);
        void SaveToXmlRoad(List<Road> listBikeRoad);
        void SaveToXmlBike(List<Bike> listBike);
        List<Mountain> ReadFromXmlMountain(List<Mountain> listBikeMountain);
        List<Road> ReadFromXmlRoad(List<Road> listBikeRoad);
        List<Bike> ReadFromXmlBike(List<Bike> listBikeMountain);

        //void SaveToTxtMountain(List<Mountain> listBikeMountain);
        //void SaveToTxtRoad(List<Road> listBikeRoad);
        //void SaveToTxtBike(List<Bike> listBike);

        //void SaveToBinMountain(List<Mountain> listBikeMountain);
        //void SaveToBinRoad(List<Road> listBikeRoad);
        //void SaveToBinBike(List<Bike> listBike);
    }
}
