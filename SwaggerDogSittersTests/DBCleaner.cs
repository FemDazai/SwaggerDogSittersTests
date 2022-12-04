﻿using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace SwaggerDogSittersTests
{
    public class DBCleaner
    {
        public void Clear()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog = ArmenianChairDogsitting.DB; User Id =student; Password=qwe!23";
            IDbConnection dbconnection = new SqlConnection(connectionString);
            dbconnection.Open();
            dbconnection.Query("delete from Animal");
            dbconnection.Query("delete from Client");
            dbconnection.Query("delete from PriceCatalog");
            dbconnection.Query("delete from Sitter");
            dbconnection.Close();
            //добавление класса по очистике бд
        }
    }
}

