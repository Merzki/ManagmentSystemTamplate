using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ManagmentSystemTemplate
{
    public class UserClass
    {
        DBconnect connect = new DBconnect();

        public bool insertUser(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`FirstName`, `LastName`, `BirthDate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.getConnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connect.closeConnection();
            }
        }
        public DataTable getUserList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user`", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getConnection);
            connect.openConnection();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnection();
            return count;
        }
        public string totalUser()
        {
            return exeCount("SELECT COUNT(*) FROM user");
        }

        public string maleUser()
        {
            return exeCount("SELECT COUNT(*) FROM user WHERE `Gender`='Male'");
        }

        public string femaleUser()
        {
            return exeCount("SELECT COUNT(*) FROM user WHERE `Gender`='Female'");
        }

        public DataTable searchUserList(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE CONCAT(`FirstName`, `LastName`, `Address`) LIKE '%"+ searchdata +"%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateUser(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `FirstName` = @fn,`LastName` =@ln,`BirthDate` = @bd,`Gender` = @gd,`Phone` = @ph,`Address` =@adr,`Photo` =@img WHERE `Id` = @id", connect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connect.closeConnection();
            }
        }

        public bool deleteUser(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `Id` = @id", connect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                connect.closeConnection();
            }
        }

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
