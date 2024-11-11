using Dapper;
using Microsoft.Data.SqlClient;

namespace N_tier.controller
{
   public static class User
    {
        public static models.User? GetUser(SqlConnection conn, int id)
        {
            try
            {
                var user = conn.Query<models.User>("SELECT * FROM users WHERE id = @Id", new { Id = id });
                return user.FirstOrDefault();
            } catch (Exception ex) {
                MessageBox.Show("Failed to get user: " + ex.Message);
                return null;
            }
        }

        public static void DeleteUser(SqlConnection conn, int userId)
        {
            try
            {
                conn.Execute("DELETE FROM users WHERE id = @Id", new { Id = userId });
                MessageBox.Show("User deleted successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete user: " + e.Message);
            }
        }

        public static void AddUser(SqlConnection conn, string name, string email, string password)
        {
            try
            {
                conn.Execute("INSERT INTO users (name, email, password) VALUES (@Name, @Email, @Password)", new { Name = name, Email = email, Password = password });
                MessageBox.Show("User added successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add user: " + e.Message);
            }
        }

        public static void UpdateUser(SqlConnection conn, int userId, string name, string email, string password)
        {
            try
            {
                conn.Execute("UPDATE users SET name = @Name, email = @Email, password = @Password WHERE id = @Id", new { Id = userId, Name = name, Email = email, Password = password });
                MessageBox.Show("User updated successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to update user: " + e.Message);
            }
        }

        public static List<models.User> GetUsers(SqlConnection conn)
        {
            try
            {
                var users = conn.Query<models.User>("SELECT * FROM users");
                return users.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to get users: " + e.Message);
                return new List<models.User>();
            }
        }
    }
}
