﻿using System.Data.SqlClient;

namespace DataLayerAPI
{
    public class mangaRebyuDataUser
    {
        private static SqlConnection conexion;

        static mangaRebyuDataUser()
        {
            conexion = new SqlConnection(@"Password=Contraseña123;Persist Security Info=True;User ID=sa;Initial Catalog=mangaRebyu;Data Source=DESKTOP-HTIGAP3\SQLEXPRESS");
        }
        public static bool crearRegistro(string username, string password)
        {
            conexion.Open();

            string insert = string.Format(
                "INSERT INTO Users VALUES ('{0}','{1}')",
                username,
                password);

            SqlCommand comando = new SqlCommand(insert, conexion);

            int rows = comando.ExecuteNonQuery();

            if (rows == 0)
            {
                conexion.Close();
                return false;
            }
            else
            {
                conexion.Close();
                return true;
            }
        }

        public static bool consultarIngreso(string username)
        {
            conexion.Open();

            string select = string.Format(
                "SELECT * FROM Users WHERE username = '{0}'",
                username
                );
            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            RegisterDTO ingreso = new RegisterDTO();

            while (dataReader.Read())
            {
                ingreso.username = username;
                ingreso.password = dataReader.GetValue(1).ToString();
            }
            conexion.Close();

            return true;
        }
    }
}