using Shinkarev_Dmitriy_Task19.Data.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Shinkarev_Dmitriy_Task19.Data.Repository
{
    public class RewardDAO
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["Task17Connection"].ConnectionString;

        public void AddRewardAndSetID(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertReward")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@Name", reward.Name);
                command.Parameters.AddWithValue("@Description", reward.Description);
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
                reward.Id = id;
            }
        }

        public void ChangeReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("ChangeReward")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@id", reward.Id);
                command.Parameters.AddWithValue("@Name", reward.Name);
                command.Parameters.AddWithValue("@Description", reward.Description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveReward(int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveReward")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@Id", rewardId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Reward> AllRewards
        {
            get
            {
                var allRewards = new List<Reward>();
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("GetRewards")
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
                            var reward = new Reward()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2)
                            };
                            allRewards.Add(reward);
                        }
                    }
                    reader.Close();
                }
                return allRewards;
            }
        }
    }
}
