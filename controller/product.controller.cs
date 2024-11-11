using Dapper;
using Microsoft.Data.SqlClient;

namespace N_tier.controller
{
    public static class Product
    {
        public static models.Product? GetProduct(SqlConnection conn, int id)
        {
            try
            {
                var product = conn.Query<models.Product>("SELECT * FROM products WHERE id = @Id", new { Id = id });
                return product.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get product: " + ex.Message);
                return null;
            }
        }

        public static void DeleteProduct(SqlConnection conn, int productId)
        {
            try
            {
                conn.Execute("DELETE FROM products WHERE id = @Id", new { Id = productId });
                MessageBox.Show("Product deleted successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete product: " + e.Message);
            }
        }

        public static void AddProduct(SqlConnection conn, string name, string description, double price)
        {
            try
            {
                conn.Execute("INSERT INTO products (name, description, price) VALUES (@Name, @Description, @Price)", new { Name = name, Description = description, Price = price });
                MessageBox.Show("Product added successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add product: " + e.Message);
            }
        }

        public static void UpdateProduct(SqlConnection conn, int productId, string name, string description, double price)
        {
            try
            {
                conn.Execute("UPDATE products SET name = @Name, description = @Description, price = @Price WHERE id = @Id", new { Id = productId, Name = name, Description = description, Price = price });
                MessageBox.Show("Product updated successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to update product: " + e.Message);
            }
        }

        public static List<models.Product> GetProducts(SqlConnection conn)
        {
            try
            {
                var products = conn.Query<models.Product>("SELECT * FROM products");
                return products.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to get products: " + e.Message);
                return new List<models.Product>();
            }
        }
    }
}
