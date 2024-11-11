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
                var user = conn.Query<models.User>(
                    "SELECT * FROM users WHERE id = @Id",
                    new { Id = id }
                );
                return user.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get user: " + ex.Message);
                return null;
            }
        }

        public static void DeleteUser(SqlConnection conn, int userId)
        {
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    conn.Execute(
                        "DELETE FROM users WHERE id = @Id",
                        new { Id = userId },
                        transaction: transaction
                    );
                    transaction.Commit();
                    MessageBox.Show("User deleted successfully");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to delete user: " + e.Message);
                }
            }
        }

        public static void AddUser(SqlConnection conn, string name, string email, string password)
        {
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    DateTimeOffset createdAt = DateTimeOffset.UtcNow;
                    conn.Execute(
                        "INSERT INTO users (name, email, password, created_at) VALUES (@Name, @Email, @Password, @CreatedAt)",
                        new { Name = name, Email = email, Password = password, CreatedAt = createdAt },
                        transaction: transaction
                    );
                    transaction.Commit();
                    MessageBox.Show("User added successfully");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to add user: " + e.Message);
                }
            }
        }

        public static void UpdateUser(SqlConnection conn, int userId, string name, string email, string password)
        {
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    DateTimeOffset updatedAt = DateTimeOffset.UtcNow;
                    conn.Execute(
                        "UPDATE users SET name = @Name, email = @Email, password = @Password, updated_at = @UpdatedAt WHERE id = @Id",
                        new { Id = userId, Name = name, Email = email, Password = password , updatedAt = updatedAt},
                        transaction: transaction
                    );
                    transaction.Commit();
                    MessageBox.Show("User updated successfully");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to update user: " + e.Message);
                }
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
