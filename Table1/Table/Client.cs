using System;


namespace Crypt.Tables
{
    class Client
    {
        private object connect;

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString() =>
            $"{Id} | {FirstName} | {LastName} | {Email}";

        public class InventoryDAL
        {
            private SqlConnection connect = null;

            public void OpenConnection(string connectionString)
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
            }

            public void CloseConnection()
            {
                connect.Close();
            }
        }
        public Client(string id, string firstName, string lastName,
            string individualIdentificationNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public void DeleteClient(int id)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            using (SqlConnection cmd = new SqlConnection(connectionString))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("К сожалению, эта машина заказана!", ex);
                    throw error;
                }
            }
        }
        public void UpdateCarPetName(int id, string firstName)
        {
            string sql = string.Format("Update Inventory Set FirstName = '{0}' Where ID = '{1}'",
                   firstName, id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}