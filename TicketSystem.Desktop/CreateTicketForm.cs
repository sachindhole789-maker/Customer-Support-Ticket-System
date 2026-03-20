using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class CreateTicketForm : Form
    {
        public CreateTicketForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All fields required");
                return;
            }

            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Select Priority");
                return;
            }

            if (Session.UserId == 0)
            {
                MessageBox.Show("User not logged in");
                return;
            }

            var client = new HttpClient();

            var ticket = new
            {
                Subject = txtSubject.Text,
                Description = txtDescription.Text,
                Priority = cmbPriority.Text,
                CreatedBy = Session.UserId,
                Status = "Open",
            TicketNumber = "TCK-" + DateTime.Now.ToString("yyyyMMddHHmmss")
        };

            var json = JsonConvert.SerializeObject(ticket);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7103/api/Ticket/create", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket Created");
                this.Close();
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show(error);
            }
        }

        private void CreateTicketForm_Load(object sender, EventArgs e)
        {
            if (Session.Role == "Admin")
            {
                btnSubmit.Enabled = false;
            }

            cmbPriority.Items.Clear();
            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("High");

            cmbPriority.SelectedIndex = 0;
        }
    }
}
