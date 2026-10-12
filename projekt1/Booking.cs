using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    internal class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public int GuestCount { get; set; }
        public string Status { get; set; } = "Aktív";
        public decimal TotalPrice { get; set; }

        public void Validate()
        {
            if (Id <= 0)
                throw new ArgumentException(
                    "A foglalási azonosítónak pozitívnak kell lennie!");

            if (GuestId <= 0)
                throw new ArgumentException(
                    "Érvénytelen vendégazonosító!");

            if (RoomNumber <= 0)
                throw new ArgumentException(
                    "Érvénytelen szobaszám!");

            if (CheckIn.Date >= CheckOut.Date)
                throw new ArgumentException(
                    "A távozásnak az érkezés után kell lennie!");

            if (GuestCount <= 0)
                throw new ArgumentException(
                    "Legalább egy vendégnek kell lennie!");

            if (TotalPrice < 0)
                throw new ArgumentException(
                    "A teljes ár nem lehet negatív!");

            if (string.IsNullOrWhiteSpace(Status))
                throw new ArgumentException(
                    "A foglalás állapota nem lehet üres!");
        }
    }
}
