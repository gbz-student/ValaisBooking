using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hotel
    {
        public int idHotel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Category { get; set; }
        public Boolean HasWifi { get; set; }
        public Boolean HasParking { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public override string ToString()
        {
            return "IdUser: " + IdMember +
                " LastName: " + Lastname +
                " Firsname: " + Firstname +
                " Gender: " + Gender +
                " Email: " + Email +
                "Password: " + Password;
        }
    }
}
