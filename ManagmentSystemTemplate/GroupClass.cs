using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystemTemplate
{
    public class GroupClass
    {
        DBconnect connect = new DBconnect();    
        public bool insertGroup(string gName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `groupp` (`GroupName`,`GroupHour`,`Description`) VALUES (@gn,@gh,@desc)", connect.getConnection);

            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@gh", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;
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
        public DataTable getGroup(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable searchGroupList(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groupp` WHERE CONCAT(`GroupName`) LIKE '%" + searchdata + "%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateGroup(int id, string gName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `groupp` SET `GroupName` = @gn,`GroupHour` = @gh,`Description` = @desc WHERE `GroupId` = @id", connect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@gh", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;
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

        public bool deleteGroup(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `groupp` WHERE `GroupId` = @id", connect.getConnection);

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
    }
}
