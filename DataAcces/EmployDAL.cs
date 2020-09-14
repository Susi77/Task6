using Connected.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Connected.DataAcces
{
    public class EmployDAL
    {

        private int rowsAffected { get; set; }

        public string ResultText { get; set; }

        public void InsertEmploy(Employ employ)
        {
            rowsAffected = 0;

            string sql = "INSERT INTO Employ (ID,Name,Age,Salary)";
            sql += $"VALUES ({employ.ID},'{employ.Name}',{employ.Age},{employ.Salary})";


            try
            {
                using (SqlConnection con = new SqlConnection("Server=DESKTOP-GNPRQ15\\SUSI;Database=HR;Trusted_Connection=True;"))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();

                        rowsAffected = cmd.ExecuteNonQuery();

                        ResultText = "Rows Affected: " + rowsAffected.ToString();
                    }

                }
            }

            catch (Exception ex)
            {

                ResultText = ex.ToString();
            }
        }



    }
}
