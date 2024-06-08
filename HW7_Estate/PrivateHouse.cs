using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Estate
{
    public struct PrivateHouse : IRealEstate
    {
        public static string TypeRealEstate { get; } = "Частный дом";
        public double Area { get; set; } // общая площадь
        public int NumberOfRooms { get; set; } // кол-во комнат
        public string Address { get; set; }
        public int NumberOfFloors {  get; set; }  // кол-во этажей
        public double LandArea {  get; set; }  // площадь участка
        public PrivateHouse(double area, int numberOfRooms, string address,int numberOfFloors,double landArea) 
        {   
            Area = area;
            NumberOfRooms = numberOfRooms;
            Address = address;
            NumberOfFloors = numberOfFloors;
            LandArea = landArea;
        }
    }
}
