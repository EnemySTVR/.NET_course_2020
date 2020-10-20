using Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class Repository
    {
        
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["Task17Connection"].ConnectionString;
        
        public static void AddUserAndSetID(UserVO user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
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
                user.SetId(id);

                if (user.Prizes.Count > 0)
                {
                    foreach (var prize in user.Prizes)
                    {
                        AddUserPrize(user, prize);
                    }
                }
            }
        }

        public static void RemoveUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@Id", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ChangeUser(UserVO user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("ChangeUser");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@BirthDate", user.BirthDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void AddPrizeAndSetID(PrizeVO prize)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertPrize");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@Name", prize.Name);
                command.Parameters.AddWithValue("@Description", prize.Description);
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
                prize.SetId(id);
            }
        }

        public static void RemovePrize(int prizeId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemovePrize");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@Id", prizeId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ChangePrize(PrizeVO prize)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("ChangePrize");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", prize.Id);
                command.Parameters.AddWithValue("@Name", prize.Name);
                command.Parameters.AddWithValue("@Description", prize.Description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void AddUserPrize(UserVO user, PrizeVO prize)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertUserPrize");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@PrizeId", prize.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void RemoveUserPrize(UserVO user, PrizeVO prize)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUserPrize");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@PrizeId", prize.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<UserVO> GetAllUsers()
        {
            #region Add connection string
            // Кусок кода добавляет строку подключения в App.settings (где бы он не был).
            // Достаточно единожды запустить приложение с ним.
            //var setting = new ConnectionStringSettings()
            //{
            //    Name = "Task17Connection",
            //    ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Task17; Integrated Security=True; Pooling=true;"
            //};

            //Configuration config;
            //config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings.Add(setting);
            //config.Save();
            #endregion
            var allUsers = new List<UserVO>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetUsers");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new UserVO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), GetUserPrizes(reader.GetInt32(0)));
                        allUsers.Add(user);
                    }
                }
                reader.Close();
            }
            return allUsers;
        }

        public static List<PrizeVO> GetAllPrizes()
        {
            var allPrizes = new List<PrizeVO>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetPrizes");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var prize = new PrizeVO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        allPrizes.Add(prize);
                    }
                }
                reader.Close();
            }
            return allPrizes;
        }

        public static List<PrizeVO> GetUserPrizes(int userId)
        {
            var userPrizes = new List<PrizeVO>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetUserPrizes");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var prize = new PrizeVO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        userPrizes.Add(prize);
                    }
                }
                reader.Close();
            }
            return userPrizes;
        }
    }
}
