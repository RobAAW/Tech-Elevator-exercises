using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using VendingMachine.Classes;

namespace VendingMachine.DAO
{
    public class DBDAO : IDAO
    {
        private readonly string connectionString;
        public DBDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Dictionary<string, Queue<VendingMachineItem>> LoadMachine(string filePath)
        {
            // let's get the inventory from the database
            Dictionary<string, Queue<VendingMachineItem>> inventory = new Dictionary<string, Queue<VendingMachineItem>>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sql = new SqlCommand("select * from VM_Items where isActive=1 order by SlotID;", conn);
                    SqlDataReader sqlDataReader = sql.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        string slot = Convert.ToString(sqlDataReader["SlotID"]);
                        inventory[slot] = CreateVMItemQueueFromReader(sqlDataReader);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return inventory;
        }

        private Queue<VendingMachineItem> CreateVMItemQueueFromReader(SqlDataReader reader)
        {
            Queue<VendingMachineItem> queue = new Queue<VendingMachineItem>();
            string itemDesc = Convert.ToString(reader["Description"]);
            decimal price = Convert.ToDecimal(reader["Price"]);
            string snackType = Convert.ToString(reader["SnackType"]);

            switch (Convert.ToString(reader["SnackType"]))
            {
                case "Chip":
                    //instantiate the Queue
                    queue = new Queue<VendingMachineItem>();
                    // Add 5 objects to the queue
                    for (int i = 0; i < 5; i++)
                    {
                        // declare an instantiate the product item
                        ChipItem chipItem = new ChipItem(itemDesc, price);
                        // Add it to the queue
                        queue.Enqueue(chipItem);
                    }
                    break;
                case "Drink":
                    //instantiate the Queue
                    queue = new Queue<VendingMachineItem>();
                    // Add 5 objects to the queue
                    for (int i = 0; i < 5; i++)
                    {
                        // declare an instantiate the product item
                        BeverageItem chipItem = new BeverageItem(itemDesc, price);
                        // Add it to the queue
                        queue.Enqueue(chipItem);
                    }
                    break;
                case "Candy":
                    queue = new Queue<VendingMachineItem>();
                    for (int i = 0; i < 5; i++)
                    {
                        CandyItem chipItem = new CandyItem(itemDesc, price);
                        queue.Enqueue(chipItem);
                    }
                    break;
                case "Gum":
                    queue = new Queue<VendingMachineItem>();
                    for (int i = 0; i < 5; i++)
                    {
                        GumItem chipItem = new GumItem(itemDesc, price);
                        queue.Enqueue(chipItem);
                    }
                    break;
                default:
                    break;
            }
            return queue;
        }

        public void LogTransaction(string action, decimal txAmount, decimal currentBalance)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into VM_Log(Action,StartValue,EndValue) " +
                        "Values(@action,@startValue,@endValue)", conn);
                    sqlCommand.Parameters.AddWithValue("@action", action);
                    sqlCommand.Parameters.AddWithValue("@startValue", txAmount);
                    sqlCommand.Parameters.AddWithValue("@endValue", currentBalance);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ResetLog()
        {
            // Don't do anything, keep stuff in the db
        }
    }
}
