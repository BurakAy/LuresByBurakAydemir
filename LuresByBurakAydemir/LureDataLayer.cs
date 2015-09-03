//Burak Aydemir

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace burakAydemirFinalProject
{
    class LureDataLayer
    {
        //OLEDB objects
        OleDbConnection conn;
        OleDbCommand comm;
        OleDbDataReader reader;

        //ctor to open the connection to the database
        public LureDataLayer()
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=lures.accdb";
            conn = new OleDbConnection(connString);
            conn.Open();
        }

        //Retrieve values from database
        public List<Lure> getLuresFromDatabase()
        {
               //Declare list of Lures, Query database
               List<Lure> allLures = new List<Lure>();
               string select = "SELECT * FROM LURES";
               comm = new OleDbCommand(select, conn);
               reader = comm.ExecuteReader(CommandBehavior.CloseConnection);

               //Loop through database, read values
               while (reader.Read())
               {
                   string id = reader["LureID"].ToString();
                   string manufacturer = reader["Manufacturer"].ToString();
                   string name = reader["LureName"].ToString();
                   string type = reader["LureType"].ToString();
                   string length = reader["Length"].ToString();
                   string weight = reader["Weight"].ToString();
                   string color = reader["Color"].ToString();
                   string price = reader["Price"].ToString();
                   string description = reader["LureDescription"].ToString();
                   string picture = reader["PictureName"].ToString();

                   //Add properties of a lure, method called from Lure class
                   Lure aLure = new Lure(id, manufacturer, name, type, length, weight, color, price, description, picture);
                   allLures.Add(aLure);
               }

               //Close connection and return list of lures
               reader.Close();
               return allLures;                   
        }

        //Delete lure from database
        public void deleteLureFromDatabase(Lure aLure)
        {
            //Try Catch statement
            try
            {
                //Open connection to database, execute sql statement to delete lure with matching LureID value
                conn.Open();
                string del = "DELETE FROM LURES WHERE LureID = ?";

                comm = new OleDbCommand(del, conn);
                OleDbParameter paramID = new OleDbParameter("LureID", aLure.LureID);
                comm.Parameters.Add(paramID);

                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                //Error message when exception is caught
                MessageBox.Show(ex.Message);
            }          
        }

        //Edit lure
        public void editLure(Lure aLure)
        {
            //Try Catch statement
            try
            {
                //Open connection to database, execute command to delete lure with matching LureID
                conn.Open();
                string updateLure = "UPDATE LURES SET Manufacturer = ?, LureName = ?, LureType = ?, Length = ?, Weight = ?, Color = ?, Price = ?, LureDescription = ?, PictureName = ? WHERE LureID = ?";

                comm = new OleDbCommand(updateLure, conn);

                //Initialize new instance and pass in new parameter values
                OleDbParameter manufacturerParam = new OleDbParameter("Manufacturer", aLure.LureManufacturer);
                OleDbParameter nameParam = new OleDbParameter("LureName", aLure.LureName);
                OleDbParameter typeParam = new OleDbParameter("LureType", aLure.LureType);
                OleDbParameter lengthParam = new OleDbParameter("Length", aLure.LureLength);
                OleDbParameter weightParam = new OleDbParameter("Weight", aLure.LureWeight);
                OleDbParameter colorParam = new OleDbParameter("Color", aLure.LureColor);
                OleDbParameter priceParam = new OleDbParameter("Price", aLure.LurePrice);
                OleDbParameter descriptionParam = new OleDbParameter("LureDescription", aLure.LureDescription);
                OleDbParameter pictureParam = new OleDbParameter("PictureName", aLure.PictureName);
                OleDbParameter lureIDParam = new OleDbParameter("LureID", aLure.LureID);
                
                //Add new parameters for edited lure
                comm.Parameters.Add(manufacturerParam);
                comm.Parameters.Add(nameParam);
                comm.Parameters.Add(typeParam);
                comm.Parameters.Add(lengthParam);
                comm.Parameters.Add(weightParam);
                comm.Parameters.Add(colorParam);
                comm.Parameters.Add(priceParam);
                comm.Parameters.Add(descriptionParam);
                comm.Parameters.Add(pictureParam);
                comm.Parameters.Add(lureIDParam);

                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                //Error message when exception is caught
                MessageBox.Show(ex.Message);
            }
        }


        public void addNewLureToDatabase(Lure aLure)
        {
            //Try Catch statement
            try
            {
                //Open connection to database, execute command to insert new lure values
                conn.Open();
                string insertLure = "INSERT INTO LURES (Manufacturer, LureName, LureType, Length, Weight, Color, Price, LureDescription, PictureName) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                comm = new OleDbCommand(insertLure, conn);

                //Initialize new instance and pass in new parameter values
                OleDbParameter manufacturerParam = new OleDbParameter("Manufacturer", aLure.LureManufacturer);
                OleDbParameter nameParam = new OleDbParameter("LureName", aLure.LureName);
                OleDbParameter typeParam = new OleDbParameter("LureType", aLure.LureType);
                OleDbParameter lengthParam = new OleDbParameter("Length", aLure.LureLength);
                OleDbParameter weightParam = new OleDbParameter("Weight", aLure.LureWeight);
                OleDbParameter colorParam = new OleDbParameter("Color", aLure.LureColor);
                OleDbParameter priceParam = new OleDbParameter("Price", aLure.LurePrice);
                OleDbParameter descriptionParam = new OleDbParameter("LureDescription", aLure.LureDescription);
                OleDbParameter pictureParam = new OleDbParameter("PictureName", aLure.PictureName);

                //Add new parameters for lure
                comm.Parameters.Add(manufacturerParam);
                comm.Parameters.Add(nameParam);
                comm.Parameters.Add(typeParam);
                comm.Parameters.Add(lengthParam);
                comm.Parameters.Add(weightParam);
                comm.Parameters.Add(colorParam);
                comm.Parameters.Add(priceParam);
                comm.Parameters.Add(descriptionParam);
                comm.Parameters.Add(pictureParam);

                comm.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                //Error message when exception is caught
                MessageBox.Show(ex.Message);
            }         
        }

        //Generate an ID for new Lures
        public string getNewRecordID()
        {
            string newID = "";

            string selectNewID = "SELECT @@Identity FROM LURES";

            comm = new OleDbCommand(selectNewID, conn);

            reader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            reader.Read();

            newID = reader[0].ToString();

            reader.Close();

            return newID;
        }
    }
}
