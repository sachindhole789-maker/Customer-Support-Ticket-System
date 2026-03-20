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
    public partial class TicketListForm : Form
    {
        public TicketListForm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var response = await client.GetAsync($"https://localhost:7103/api/Ticket/list?userId={Session.UserId}&role={Session.Role}");

            var data = await response.Content.ReadAsStringAsync();

            var tickets = JsonConvert.DeserializeObject<dynamic>(data);

            dataGridView1.DataSource = tickets;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ticketId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                TicketDetailsForm form = new TicketDetailsForm(ticketId);
                form.Show();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ticketId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                TicketDetailsForm form = new TicketDetailsForm(ticketId);
                form.Show();
            }
        }
    }
}
