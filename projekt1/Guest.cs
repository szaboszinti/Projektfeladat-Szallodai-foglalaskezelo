using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    internal class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        public void Validate()
        {
            if (Id <= 0)
                throw new ArgumentException(
                    "Az azonosítónak pozitívnak kell lennie!");

            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException(
                    "A vendég neve nem lehet üres!");

            if (string.IsNullOrWhiteSpace(Phone))
                throw new ArgumentException(
                    "A telefonszám nem lehet üres!");

            if (string.IsNullOrWhiteSpace(Email) ||
                !Email.Contains("@"))
                throw new ArgumentException(
                    "Adj meg egy érvényesebb e-mail-címet!");
        }
    }
}
