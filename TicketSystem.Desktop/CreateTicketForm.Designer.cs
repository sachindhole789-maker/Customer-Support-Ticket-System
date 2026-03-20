namespace TicketSystem.Desktop
{
    partial class CreateTicketForm
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
            label1 = new Label();
            label2 = new Label();
            txtSubject = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            cmbPriority = new ComboBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 44);
            label1.Name = "label1";
            label1.Size = new Size(249, 50);
            label1.TabIndex = 0;
            label1.Text = "Create Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 131);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 1;
            label2.Text = "Subject :-";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(352, 130);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(200, 39);
            txtSubject.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 237);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 3;
            label3.Text = "Description :-";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(352, 234);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 39);
            txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 322);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 5;
            label4.Text = "Priority :-";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(352, 319);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(242, 40);
            cmbPriority.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LightGreen;
            btnSubmit.Location = new Point(266, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CreateTicketForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(cmbPriority);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTicketForm";
            Text = "CreateTicketForm";
            Load += CreateTicketForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSubject;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private ComboBox cmbPriority;
        private Button btnSubmit;
    }
}