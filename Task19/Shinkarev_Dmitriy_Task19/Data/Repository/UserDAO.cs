using Shinkarev_Dmitriy_Task19.Data.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Shinkarev_Dmitriy_Task19.Data.Repository
{
    public class UserDAO
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["Task17Connection"].ConnectionString;

        public void AddUserAndSetID(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertUser")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                var idParam = new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int
                };
                idParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParam);

                connection.Open();
                command.ExecuteNonQuery();
                int id = (int)command.Parameters["@Id"].Value;
                user.Id = id;
            }
        }

        public void ChangeUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("ChangeUser")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@BirthDate", user.BirthDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUser")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@Id", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetUsers")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            BirthDate = reader.GetDateTime(3)
                        };
                        yield return user;
                    }
                }
                reader.Close();
            }
        }
    }
}
// 