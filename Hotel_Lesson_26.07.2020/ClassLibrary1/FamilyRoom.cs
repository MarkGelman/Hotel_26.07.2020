using Clientss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class FamilyRoom:Room
    {
        
        protected override void SetPrice()
        {
            _price = base._price + 100;
        }

        protected override void SetFeatures()
        {
            _features = "1.One room\n 2.Balcony\n 3.jacuzzi\n 4.TV\n 5.WiFi\n 6.Refrigerator\n 7.One 8.Double bed\n 9.Half board";
        }

        public FamilyRoom (int roomNumber, float price, Guest guest) : base(roomNumber, price, guest)
        {
            _typeOFRoom = 2;
        }

    }
}
