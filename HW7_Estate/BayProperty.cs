using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Estate
{
     public class BayProperty<T> where T : IRealEstate
    {
        public string FIOBayer {  get; set; }
        public string FIOSeller {  get; set; }
        public T RealEstates { get; set; }
        public double Price {  get; set; }
        public BayProperty(string bayer, string seller, T realEstate,double price) 
        {
            FIOBayer = bayer;
            FIOSeller = seller;
            RealEstates = realEstate;
            Price = price;
        }
        
        public string Information()
        {
            return $"Покупатель: {FIOBayer}\n" +
                $"Продавец: {FIOSeller}\n" +
                $"Вид недвижимости: {T.TypeRealEstate}\n" +
                $"Площадь: {RealEstates.Area}кв.м.\n" +
                $"Количество комнат: {RealEstates.NumberOfRooms}\n" +
                $"Адрес: {RealEstates.Address}\nСтоимость покупки: {Price} руб.";
        }
        public double PriceOneMeter()
        {
            return Math.Round(Price / RealEstates.Area, 2);
        }

    }
}
