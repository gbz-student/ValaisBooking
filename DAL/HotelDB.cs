using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class HotelDB
    {
        public static List<Hotel> getAllHotel()
        {
            List<Hotel> listAllHotel = null;

            string connectionString = ConfigurationManager.ConnectionStrings["ProjectDBConnect"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Hotel";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (listAllHotel == null)
                                listAllHotel = new List<Hotel>();

                            Hotel member = new Hotel();

                            member.IdMember = (int)dr["idMember"];

                            if (dr["Lastname"] != null)
                                member.Lastname = (string)dr["Lastname"];

                            if (dr["Firstname"] != null)
                                member.Firstname = (string)dr["Firstname"];

                            if (dr["Gender"] != DBNull.Value)
                                member.Gender = (short)dr["Gender"];

                            member.Email = (string)dr["Email"];

                            member.Password = (string)dr["Password"];

                            results.Add(member);

                        }
                    }
                }
            }

            return listAllHotel;
        }
    }
}
