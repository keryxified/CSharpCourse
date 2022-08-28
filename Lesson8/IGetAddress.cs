using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public interface IGetAddress
    {
        void GetIndex();
        void GetCountry();
        void GetRegion();
        void GetCity();
        void GetStreet();
        void GetHouse();
        void GetApartments();
        UserAddress GetAddress();
    }
}
