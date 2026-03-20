using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var data = new
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            };

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7103/api/Auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<dynamic>(responseData);

                // STORE SESSION
                Session.UserId = user.id;
                Session.Username = user.username;
                Session.Role = user.role;

             


                MessageBox.Show("Login Success");


                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
                MessageBox.Show(json);
            }
        }
    }
}
