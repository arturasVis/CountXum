﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


    internal class DBManager
    {
        SqlConnection _connection;
        readonly string sql = ConfigurationManager.ConnectionStrings["BuildQtyTracker.Properties.Settings.xumlocalConnectionString"].ConnectionString;


        /// <summary>
        /// Insert update delete querries
        /// </summary>
        /// <param name="querry">Querry to execute</param>
        public bool InsertQuerry(string querry)
        {
            try
            {
                using (_connection = new SqlConnection(sql))
                using (var command = _connection.CreateCommand())
                {
                    _connection.Open();
                    command.CommandText = querry;
                    Console.WriteLine("Rows affected " + command.ExecuteNonQuery());
                    _connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        /// <summary>
        /// Select the whole table
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataTable Select(string table)
        {
            try
            {
                DataTable dt = new DataTable();
                string querry = $"SELECT * FROM {table}";
                using (_connection = new SqlConnection(sql))
                using (SqlDataAdapter adapter = new SqlDataAdapter(querry, _connection))
                {
                    _connection.Open();
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// Select the table that fits the condition
        /// </summary>
        /// <param name="table">Table to select from</param>
        /// <param name="collum">Collum to apply the condition to</param>
        /// <param name="condition">Condition</param>
        /// <returns></returns>
        public DataTable SelectSpecific(string table, string collum, string condition)
        {
            try
            {
                DataTable dt = new DataTable();
                string querry = $"SELECT * FROM {table} WHERE {collum}='{condition}'";
                using (_connection = new SqlConnection(sql))
                using (SqlDataAdapter adapter = new SqlDataAdapter(querry, _connection))
                {
                    _connection.Open();
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public DataTable SelectWild(string table, string collum, string condition)
        {
            try
            {
                DataTable dt = new DataTable();
                string querry = $"SELECT * FROM {table} WHERE {collum} LIKE '{condition}'";
                using (_connection = new SqlConnection(sql))
                using (SqlDataAdapter adapter = new SqlDataAdapter(querry, _connection))
                {
                    _connection.Open();
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// Deletes the collum on the condition
        /// </summary>
        /// <param name="table">Table to delete from</param>
        /// <param name="columnName">Name of the column to apply the condition on</param>
        /// <param name="condition">Condition</param>
        public void DeleteRow(string table, string columnName, string condition)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sql))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand($"DELETE FROM {table} WHERE {columnName}={condition}", con))
                    {
                        Console.WriteLine("Rows affected " + command.ExecuteNonQuery());
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }

