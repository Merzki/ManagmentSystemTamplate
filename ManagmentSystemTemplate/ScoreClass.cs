using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystemTemplate
{
    public class ScoreClass
    {
        DBconnect connect = new DBconnect();

        public bool insertScore(int id, string gName, double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score` (`Id`,`GroupName`,`Score`,`Description`) VALUES (@id,@gn,@scr,@desc)", connect.getConnection);

            command.Parameters.Add("@id" , MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@scr", MySqlDbType.Double).Value = score;
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

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool checkScore(int id, string gName)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `Id` = '"+ id +"' AND `GroupName` = '"+ gName +"'"));
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateScore(int id,string gName,double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score` =@scr, `Description` =@desc WHERE `Id` = @id AND `GroupName` =@gn", connect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@scr", MySqlDbType.Double).Value = score;
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

        public bool deleteScore(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `Id` = @id", connect.getConnection);

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
