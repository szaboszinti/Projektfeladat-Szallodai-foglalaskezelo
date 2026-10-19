using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    internal class Hotel
    {
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Guest> Guests { get; set; } = new List<Guest>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public void AddRoom(Room room)
        {
            room.Validate();

            if (Rooms.Any(r => r.RoomNumber == room.RoomNumber))
                throw new ArgumentException(
                    "Ez a szobaszám már létezik!");

            Rooms.Add(room);
        }

        public void AddGuest(Guest guest)
        {
            guest.Validate();

            if (Guests.Any(g => g.Id == guest.Id))
                throw new ArgumentException(
                    "Ez a vendégazonosító már létezik!");

            Guests.Add(guest);
        }

        public void AddBooking(Booking booking)
        {
            booking.Validate();

            if (Bookings.Any(b => b.Id == booking.Id))
                throw new ArgumentException(
                    "Ez a foglalási azonosító már létezik!");

            Guest guest = Guests.FirstOrDefault(
                g => g.Id == booking.GuestId);

            if (guest == null)
                throw new ArgumentException(
                    "A megadott vendég nem létezik!");

            Room room = Rooms.FirstOrDefault(
                r => r.RoomNumber == booking.RoomNumber);

            if (room == null || !room.IsActive)
                throw new ArgumentException(
                    "A szoba nem létezik vagy nem aktív!");

            if (booking.GuestCount > room.Capacity)
                throw new ArgumentException(
                    "Túl sok vendég van a szoba férőhelyéhez képest!");

            booking.TotalPrice =
                (decimal)(booking.CheckOut.Date -
                          booking.CheckIn.Date).TotalDays
                * room.PricePerNight;

            booking.Validate();
            Bookings.Add(booking);
        }
    }
}
