using ConnectToDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConnectToDB.DataAcces
{
    public class Employdal

    {

        private int rowsaffected { get; set; }

        public string ResultText { get; set; }


        public void InsertEmploy(Employ employ) 
        {
            rowsaffected = 0;

            string sql = "INSERT INTO Employ(ID,Name,Age,Salary)";

            sql += $"Values({employ.ID},'{employ.Name}','{employ.Age}','{employ.Salary}')";


            try
            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    // Create command object in using block for automatic disposal
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Set CommandType
                        cmd.CommandType = CommandType.Text;
                        // Open the connection
                        cnn.Open();
                        // Execute the INSERT statement
                        rowsaffected = cmd.ExecuteNonQuery();

                        ResultText = "Rows Affected: " + rowsaffected.ToString();
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
