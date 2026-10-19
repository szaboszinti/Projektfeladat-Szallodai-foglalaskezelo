using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; } = "";
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public string Equipment { get; set; } = "";
        public bool IsActive { get; set; }

        public void Validate()
        {
            if (RoomNumber <= 0)
                throw new ArgumentException("A szobaszámnak pozitívnak kell lennie!");

            if (string.IsNullOrWhiteSpace(RoomType))
                throw new ArgumentException("A szobatípus nem lehet üres!");

            if (Capacity <= 0)
                throw new ArgumentException("A férőhely legalább 1 legyen!");

            if (PricePerNight < 0)
                throw new ArgumentException("Az ár nem lehet negatív!");
        }
    }
}
