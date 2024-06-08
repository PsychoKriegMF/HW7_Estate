using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Estate
{
    public interface IRealEstate
    {
        virtual static string TypeRealEstate { get;}
        double Area { get;}
        int NumberOfRooms { get; }
        string Address { get;}
    }
}
