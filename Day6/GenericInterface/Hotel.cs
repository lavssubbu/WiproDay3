using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericINterface
{
    internal class Hotel : IRoom<RoomAC> , IRoom<RoomNonAC>
    {
        List<RoomAC> lstrooms = new List<RoomAC>()
        {
            new RoomAC(){RoomNo=111,RoomType="Single",Price=5000},
            new RoomAC(){RoomNo=113,RoomType="Single",Price=5000},
            new RoomAC(){RoomNo=112,RoomType="Double",Price=8000},
            new RoomAC(){RoomNo=114,RoomType="Single",Price=5000},

        };

        List<RoomNonAC> lstnonacrooms = new List<RoomNonAC>()
        {
            new RoomNonAC(){RoomNo=111,RoomType="Single",Price=3000},
            new RoomNonAC(){RoomNo=113,RoomType="Single",Price=2000},
            new RoomNonAC(){RoomNo=112,RoomType="Double",Price=4000},
            new RoomNonAC(){RoomNo=114,RoomType="Single",Price=3000},

        };
        public void AddRoom(RoomAC item)
        {
            lstrooms.Add(item);
            Console.WriteLine("Room added successfully"+item.RoomNo + " " + item.RoomType + " " + item.Price);
        }

        public void AddRoom(RoomNonAC item)
        {
           lstnonacrooms.Add(item);
            Console.WriteLine("Room added successfully" + item.RoomNo + " " + item.RoomType + " " + item.Price);
        }

        public IEnumerable<RoomAC> GetAll()
        {
            return lstrooms;
        }

        IEnumerable<RoomNonAC> IRoom<RoomNonAC>.GetAll()
        {
            return lstnonacrooms;
        }
    }
}
