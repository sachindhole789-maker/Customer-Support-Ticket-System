namespace TicketSystem.Desktop
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            label1 = new Label();
            btnView = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightBlue;
            btnCreate.Location = new Point(193, 178);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(277, 69);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Ticket";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 47);
            label1.Name = "label1";
            label1.Size = new Size(211, 50);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(255, 192, 192);
            btnView.Location = new Point(193, 299);
            btnView.Name = "btnView";
            btnView.Size = new Size(277, 69);
            btnView.TabIndex = 2;
            btnView.Text = "View Tickets";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnView);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label label1;
        private Button btnView;
    }
}