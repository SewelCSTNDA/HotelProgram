using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class Hotel
    {
        public string HotelName {  get; set; }
        public string Location {  get; set; }
        private List<HotelRoom> _allRooms;

        public Hotel(string hotelName, string location, List<HotelRoom> rooms)
        {
            HotelName = hotelName;
            Location = location;
            _allRooms = rooms;
        }

        public Hotel()
        {
            _allRooms = new List<HotelRoom>();
        }

        public void addRoom(HotelRoom room)
        {
            _allRooms.Add(room);
        }
    }
}
