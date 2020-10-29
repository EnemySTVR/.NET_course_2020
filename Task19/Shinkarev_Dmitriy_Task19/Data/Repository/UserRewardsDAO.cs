using Shinkarev_Dmitriy_Task19.Data.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Shinkarev_Dmitriy_Task19.Data.Repository
{
    public class UserRewardsDAO
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["Task17Connection"].ConnectionString;

        public void AddUserReward(int userId, int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("InsertUserPrize")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PrizeId", rewardId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveUserReward(int userId, int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("RemoveUserPrize")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PrizeId", rewardId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Reward> GetRewardsForConcretUser(int userId)
        {
            var userRewards = new List<Reward>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetUserPrizes")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@UserId", userId);

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
                        userRewards.Add(reward);
                    }
                }
                reader.Close();
            }
            return userRewards;
        }

        public List<User> GetUsersForConcretReward(int rewardId)
        {
            var rewardUsers = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetRewardUsers")
                {
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };
                command.Parameters.AddWithValue("@RewardId", rewardId);

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
                        rewardUsers.Add(user);
                    }
                }
                reader.Close();
            }
            return rewardUsers;
        }
    }
}
