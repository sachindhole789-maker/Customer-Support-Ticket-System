namespace TicketSystem.Desktop
{
    partial class TicketDetailsForm
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
            lblTicketNo = new Label();
            lblSubject = new Label();
            lblPriority = new Label();
            lblStatus = new Label();
            lblCreatedDate = new Label();
            lblAssignedTo = new Label();
            txtDescription = new TextBox();
            cmbAssign = new ComboBox();
            cmbStatus = new ComboBox();
            txtComment = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTicketNo
            // 
            lblTicketNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketNo.AutoSize = true;
            lblTicketNo.Location = new Point(233, 170);
            lblTicketNo.Name = "lblTicketNo";
            lblTicketNo.Size = new Size(78, 32);
            lblTicketNo.TabIndex = 0;
            lblTicketNo.Text = "label1";
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(233, 240);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 32);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "label1";
            // 
            // lblPriority
            // 
            lblPriority.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(233, 462);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(78, 32);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(233, 528);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 32);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "label1";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(233, 594);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(78, 32);
            lblCreatedDate.TabIndex = 4;
            lblCreatedDate.Text = "label1";
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Location = new Point(233, 660);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(78, 32);
            lblAssignedTo.TabIndex = 5;
            lblAssignedTo.Text = "label1";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(233, 326);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(480, 78);
            txtDescription.TabIndex = 6;
            // 
            // cmbAssign
            // 
            cmbAssign.FormattingEnabled = true;
            cmbAssign.Location = new Point(583, 442);
            cmbAssign.Name = "cmbAssign";
            cmbAssign.Size = new Size(242, 40);
            cmbAssign.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(583, 520);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(242, 40);
            cmbStatus.TabIndex = 8;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(583, 594);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(242, 78);
            txtComment.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(366, 766);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TicketDetailsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 843);
            Controls.Add(btnSave);
            Controls.Add(txtComment);
            Controls.Add(cmbStatus);
            Controls.Add(cmbAssign);
            Controls.Add(txtDescription);
            Controls.Add(lblAssignedTo);
            Controls.Add(lblCreatedDate);
            Controls.Add(lblStatus);
            Controls.Add(lblPriority);
            Controls.Add(lblSubject);
            Controls.Add(lblTicketNo);
            Name = "TicketDetailsForm";
            Text = "TicketDetails";
            Load += TicketDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketNo;
        private Label lblSubject;
        private Label lblPriority;
        private Label lblStatus;
        private Label lblCreatedDate;
        private Label lblAssignedTo;
        private TextBox txtDescription;
        private ComboBox cmbAssign;
        private ComboBox cmbStatus;
        private TextBox txtComment;
        private Button btnSave;
    }
}