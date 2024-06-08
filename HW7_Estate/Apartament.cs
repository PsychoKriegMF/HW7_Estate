using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Estate
{
    public struct Apartament : IRealEstate
    {
        public static string TypeRealEstate { get; } = "Квартира";
        public double Area { get;set; } // общая площадь
        public int NumberOfRooms {  get; set; } // кол-во комнат
        public string Address { get; set; }
        public bool Balcony {  get; set; } // наличие балкона
        public bool Gas {  get; set; }  // наличие газа
        public int FloorNumber {  get; set; } // номер этажа

        public Apartament(double area, int numberOfRooms, string address, bool balcony, bool gas, int floorNumber) 
        {    
            Area = area;
            NumberOfRooms = numberOfRooms;
            Address = address;
            Balcony = balcony;
            Gas = gas;
            FloorNumber = floorNumber;
        }
    }
}
