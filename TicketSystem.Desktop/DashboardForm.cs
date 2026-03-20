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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTicketForm form = new CreateTicketForm();
            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TicketListForm form = new TicketListForm();
            form.Show();
        }
    }
}
