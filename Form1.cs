using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using C__Coderhouse_MAIN.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
namespace C__Coderhouse_MAIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnLoadProducts_Click(object sender, EventArgs e)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                List<Products> products = ProductService.GetProducts();
                this.dataGridProducts.DataSource = products;
            }
        }
        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            List<Users> users = UserService.GetUsers();
            this.dataGridProducts.DataSource = users;
        }

        private void btnLoadSales_Click(object sender, EventArgs e)
        {
            List<Sales> sales = SaleService.GetSales();
            this.dataGridProducts.DataSource = sales;
            this.UpdateDataGridView(sales);
        }

        private void UpdateDataGridView(object obj)
        {
            this.dataGridProducts.DataSource = null;
            this.dataGridProducts.DataSource = obj;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindById_click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;

            if (!string.IsNullOrWhiteSpace(idString))
            {

                int id = Convert.ToInt32(idString);

                Users foundUsers = UserService.GetUserById(id);

                List<Users> list = new List<Users>() { foundUsers };
                this.UpdateDataGridView(list);

            }
            else
            {
                MessageBox.Show("Please enter valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }
        private int GetId()
        {
            string idString = this.txtId.Text;

            if (!string.IsNullOrWhiteSpace(idString))
            {

                int id = Convert.ToInt32(idString);
                return id;

            }
            else
            {
                MessageBox.Show("Please enter valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
            return -1;
        }

        private void btnCreateUser_click(object sender, EventArgs e)
        {
            UserFormView userForm = new UserFormView();
            userForm.ShowDialog();
            this.Hide();

            Users user = userForm.CreatedUser;
            if (UserService.AddUser(user))
            {
                MessageBox.Show("User created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Show();
        }
    }
}
