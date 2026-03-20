using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem.Desktop
{
    public partial class TicketDetailsForm : Form
    {
        int ticketId;

        public TicketDetailsForm(int id)
        {
            InitializeComponent();
            ticketId = id;
        }
        public TicketDetailsForm()
        {
            InitializeComponent();
        }

        private async void TicketDetailsForm_Load(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                cmbAssign.Visible = false;
                cmbStatus.Visible = false;
                txtComment.Visible = false;
                btnSave.Visible = false;
            }

            var client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7103/api/Ticket/details/{ticketId}");

            var data = await response.Content.ReadAsStringAsync();
            dynamic ticket = JsonConvert.DeserializeObject(data);

            lblTicketNo.Text = ticket.ticketNumber;
            lblSubject.Text = ticket.subject;
            txtDescription.Text = ticket.description;
            lblPriority.Text = ticket.priority;
            lblStatus.Text = ticket.status;
            lblCreatedDate.Text = ticket.createdDate;
            lblAssignedTo.Text = ticket.assignedTo;

        }
        private async Task LoadAdmins()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7103/api/user/admins");

            var data = await response.Content.ReadAsStringAsync();
            var admins = JsonConvert.DeserializeObject<List<dynamic>>(data);

            cmbAssign.DataSource = admins;
            cmbAssign.DisplayMember = "username";
            cmbAssign.ValueMember = "id";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            // Assign
            await client.PostAsync($"https://localhost:7103/api/ticket/assign?ticketId={ticketId}&adminId={cmbAssign.SelectedValue}", null);

            // Update Status
            await client.PostAsync($"https://localhost:7103/api/ticket/update-status?ticketId={ticketId}&status={cmbStatus.Text}&userId={Session.UserId}", null);

            // Add Comment
            var comment = new
            {
                TicketId = ticketId,
                Comment = txtComment.Text,
                CreatedBy = Session.UserId
            };

            var json = JsonConvert.SerializeObject(comment);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await client.PostAsync("https://localhost:7103/api/Ticket/comment", content);

            MessageBox.Show("Updated Successfully");
        }
    }
}
