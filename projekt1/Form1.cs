using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt1
{
    public partial class Form1 : Form
    {
        private Hotel hotel = new Hotel();

        public Form1()
        {
            InitializeComponent();
            Hotel hotel = new Hotel();

            Room room = new Room
            {
                RoomNumber = 101,
                RoomType = "Kétágyas",
                Capacity = 2,
                PricePerNight = 35000,
                Equipment = "TV, Wi-Fi",
                IsActive = true
            };
            Guest guest = new Guest
            {
                Id = 1,
                Name = "Kiss Péter",
                Phone = "06301234567",
                Email = "peter.kiss@example.com"
            };

            Booking booking = new Booking
            {
                Id = 1,
                GuestId = 1,
                RoomNumber = 101,
                CheckIn = DateTime.Today,
                CheckOut = DateTime.Today.AddDays(2),
                GuestCount = 2,
                Status = "Aktív"
            };

            hotel.AddRoom(room);
            hotel.AddGuest(guest);
            hotel.AddBooking(booking);

            /* MessageBox.Show(
                $"Szobák száma: {hotel.Rooms.Count}\n" +
                $"Vendégek száma: {hotel.Guests.Count}\n" +
                $"Foglalások száma: {hotel.Bookings.Count}\n" +
                $"Foglalás teljes ára: {booking.TotalPrice:N0} Ft"
            );*/
        }


        #region gomb

        private void btnTeszt_Click(object sender, EventArgs e)
        {
            dgvAdatok.Columns.Clear();
            dgvAdatok.Rows.Clear();

            dgvAdatok.Columns.Add("Tipus", "Típus");
            dgvAdatok.Columns.Add("Azonosito", "Azonosító");
            dgvAdatok.Columns.Add("Adat", "Adatok");

            foreach (Room room in hotel.Rooms)
            {
                dgvAdatok.Rows.Add(
                    "Szoba",
                    room.RoomNumber,
                    room.RoomType + ", " +
                    room.Capacity + " férőhely, " +
                    room.PricePerNight + " Ft/éj"
                );
            }

            foreach (Guest guest in hotel.Guests)
            {
                dgvAdatok.Rows.Add(
                    "Vendég",
                    guest.Id,
                    guest.Name + ", " +
                    guest.Phone + ", " +
                    guest.Email
                );
            }

            foreach (Booking booking in hotel.Bookings)
            {
                dgvAdatok.Rows.Add(
                    "Foglalás",
                    booking.Id,
                    "Szoba: " + booking.RoomNumber +
                    ", vendég: " + booking.GuestId +
                    ", ár: " + booking.TotalPrice + " Ft"
                );
            }

            dgvAdatok.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
    }
}
