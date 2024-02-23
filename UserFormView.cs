using C__Coderhouse_MAIN.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Coderhouse_MAIN
{
    public partial class UserFormView : Form
    {
        public UserFormView()
        {
            InitializeComponent();
        }
        public UserFormView(Users user):this()
        {
            this.txtName.Text = user.Name;
            this.txtEmail.Text = user.Email;
            this.txtPassword.Text = user.Password;
            this.txtSurname.Text = user.LastName;
            this.txtUsername.Text = user.Username;
        }
        public Users CreatedUser { get; private set; }
        private void ConfirmUser_click(object sender, EventArgs e)
        {
            Users user = new Users() {
                Name = this.txtName.Text, 
                LastName = this.txtSurname.Text,
                Username = this.txtUsername.Text,
                Password = this.txtPassword.Text,
                Email = this.txtEmail.Text,
            };
            this.CreatedUser = user;
            this.Close();
        }
    }
}
