﻿using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Business.Data {
    public class SecurityDAO {

        public bool FindByUser(UserModel user) {

            
            // DB Connection
            
            SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlDataReader rdr = null;

            string queryString = "SELECT * FROM dbo.Users WHERE USERNAME ='"
                + user.Username + "' AND PASSWORD ='" + user.Password+"'";

            bool loginSuccess = false;

            try {
             
                conn.Open();

                // Query Statement
                SqlCommand cmd = new SqlCommand(queryString, conn);

                // Results
                rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    Console.WriteLine(rdr[0]);
                }

                if (rdr.HasRows) { loginSuccess = true; }

            } finally {

                // Close
                if (rdr != null) {
                    rdr.Close();
                }

                if (conn != null) {
                    conn.Close();
                }

            }

            return loginSuccess;
    
           // return true;
           // return false;
        }

    }
}