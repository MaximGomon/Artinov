using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StartWithAdo.net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

                //Create Database command
                //string commandText = @"CREATE DATABASE [AdoNetExample]
                //                       COLLATE Latin1_General_CI_AS";

                //Create table command
                //string commandText = @"
                //use [AdoNetExample]
                //create table UserInfo 
                //(
                //    Id int identity,
                //    Name nvarchar(150) not null
                //)";

                //Ctrl+K+C => Ctrl+K+U
                //Data insert command
                //string commandText = @"
                //use [AdoNetExample]
                //insert into UserInfo ('Name')
                //values
                //(N'Anton')";

                string commandText = @"use [AdoNetExample] select Id, Name from UserInfo";
                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(commandText, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                Console.WriteLine(dt.Rows[0].ItemArray[1]);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                //    //DataSet ds = new DataSet();
                //    var r = ds.CreateDataReader();
                //    while (reader.Read())
                //    {
                //        Console.WriteLine($"Id: {reader["Id"]}, " +
                //                          $"Name: {reader["Name"]}");
                //    }
                //}

                //DataTable dt = new DataTable();
                //int updatedRows = command.ExecuteNonQuery();
                //if (updatedRows == 0)
                //{
                //    throw new DataException("Zero rows are affected");
                //}
                connection.Close();

                Console.WriteLine("Command completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
