using QC = Microsoft.Data.SqlClient;

namespace N_tier
{
    public partial class Form1 : Form
    {
        QC.SqlConnection conn;
        string connString = "Server=localhost; Database=store; User ID=sa; Password=@Fish123;Trust Server Certificate=True;";
        public Form1()
        {
            InitializeComponent();
            usersPanel.Location = welcomePanel.Location;
            productsPanel.Location = welcomePanel.Location;
            addUserPanel.Location = listUserPanel.Location;
            addProductPanel.Location = productListPanel.Location;

            try
            {
                conn = new QC.SqlConnection(connString);
                conn.Open();
                dbConnectionStatus.BackColor = Color.Green;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to connect to database: " + e.Message);
                Environment.Exit(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            welcomePanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hidePanels();
            welcomePanel.Visible = true;
        }

        public void hidePanels()
        {
            welcomePanel.Visible = false;
            usersPanel.Visible = false;
            productsPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidePanels();
            usersPanel.Visible = true;
            RenderUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidePanels();
            productsPanel.Visible = true;
            RenderProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listUserPanel.Visible = true;
            addUserPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addUserPanel.Visible = true;
            listUserPanel.Visible = false;
        }

        private void addUserSubmitButton_Click(object sender, EventArgs e)
        {
            var email = emailInput.Text;
            var name = nameInput.Text;
            var password = passwordInput.Text;

            controller.User.AddUser(conn, name, email, password);
        }

        private void RenderUsers()
        {
            var users = controller.User.GetUsers(conn);
            userList.Items.Clear();
            foreach (var user in users)
            {
                userList.Items.Add(user.Name);
            }
        }

        private void RenderProducts()
        {
            var products = controller.Product.GetProducts(conn);
            productList.Items.Clear();
            foreach (var product in products)
            {
                productList.Items.Add(product.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productListPanel.Visible = true;
            addProductPanel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addProductPanel.Visible = true;
            productListPanel.Visible = false;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var name = productNameInput.Text;
            var description = productDescriptionInput.Text;
            var price = double.Parse(productPriceInput.Text);

            controller.Product.AddProduct(conn, name, description, price);
        }
    }
}
