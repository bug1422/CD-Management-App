namespace CD_Management_System
{
    partial class Request
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
            requestDgv = new DataGridView();
            name = new Label();
            email = new Label();
            phoneNumber = new Label();
            description = new Label();
            status = new Label();
            submitDate = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDescription = new TextBox();
            txtStatus = new TextBox();
            txtDate = new TextBox();
            acceptBtn = new Button();
            denyBtn = new Button();
            button2 = new Button();
            backBtn = new Button();
            txtNoti = new Label();
            txtFromEmail = new TextBox();
            txtToEmail = new TextBox();
            fromEmail = new Label();
            label1 = new Label();
            body = new Label();
            txtBody = new TextBox();
            editBtn = new Button();
            subject = new Label();
            txtSubject = new TextBox();
            sendBtn = new Button();
            cancelBtn = new Button();
            getMailBtn = new Button();
            getReqBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)requestDgv).BeginInit();
            SuspendLayout();
            // 
            // requestDgv
            // 
            requestDgv.AllowUserToAddRows = false;
            requestDgv.AllowUserToDeleteRows = false;
            requestDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestDgv.Location = new Point(14, 15);
            requestDgv.Name = "requestDgv";
            requestDgv.ReadOnly = true;
            requestDgv.RowHeadersWidth = 51;
            requestDgv.RowTemplate.Height = 29;
            requestDgv.Size = new Size(937, 188);
            requestDgv.TabIndex = 0;
            requestDgv.CellDoubleClick += requestDgv_CellDoubleClick;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(11, 216);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(11, 425);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 2;
            email.Text = "Email";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Location = new Point(11, 308);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(108, 20);
            phoneNumber.TabIndex = 3;
            phoneNumber.Text = "Phone Number";
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(230, 308);
            description.Name = "description";
            description.Size = new Size(85, 20);
            description.TabIndex = 4;
            description.Text = "Description";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(230, 217);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 5;
            status.Text = "Status";
            // 
            // submitDate
            // 
            submitDate.AutoSize = true;
            submitDate.Location = new Point(11, 535);
            submitDate.Name = "submitDate";
            submitDate.Size = new Size(92, 20);
            submitDate.TabIndex = 6;
            submitDate.Text = "Submit Date";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 248);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(11, 457);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(172, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(11, 351);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(172, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(230, 351);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(326, 149);
            txtDescription.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(230, 249);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(172, 27);
            txtStatus.TabIndex = 11;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(11, 577);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(172, 27);
            txtDate.TabIndex = 12;
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(230, 548);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(94, 60);
            acceptBtn.TabIndex = 13;
            acceptBtn.Text = "Accept";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // denyBtn
            // 
            denyBtn.Location = new Point(354, 548);
            denyBtn.Name = "denyBtn";
            denyBtn.Size = new Size(94, 60);
            denyBtn.TabIndex = 14;
            denyBtn.Text = "Deny";
            denyBtn.UseVisualStyleBackColor = true;
            denyBtn.Click += denyBtn_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(147, 672);
            button2.Name = "button2";
            button2.Size = new Size(105, 53);
            button2.TabIndex = 15;
            button2.Text = "Add album";
            button2.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(14, 672);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(104, 53);
            backBtn.TabIndex = 16;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // txtNoti
            // 
            txtNoti.AutoSize = true;
            txtNoti.Location = new Point(574, 688);
            txtNoti.Name = "txtNoti";
            txtNoti.Size = new Size(113, 20);
            txtNoti.TabIndex = 17;
            txtNoti.Text = "Sending email...";
            txtNoti.Visible = false;
            // 
            // txtFromEmail
            // 
            txtFromEmail.Location = new Point(574, 248);
            txtFromEmail.Margin = new Padding(3, 4, 3, 4);
            txtFromEmail.Name = "txtFromEmail";
            txtFromEmail.ReadOnly = true;
            txtFromEmail.Size = new Size(204, 27);
            txtFromEmail.TabIndex = 18;
            txtFromEmail.Text = "cdalbumcompany@gmail.com";
            // 
            // txtToEmail
            // 
            txtToEmail.Location = new Point(803, 252);
            txtToEmail.Margin = new Padding(3, 4, 3, 4);
            txtToEmail.Name = "txtToEmail";
            txtToEmail.ReadOnly = true;
            txtToEmail.Size = new Size(204, 27);
            txtToEmail.TabIndex = 19;
            // 
            // fromEmail
            // 
            fromEmail.AutoSize = true;
            fromEmail.Location = new Point(574, 216);
            fromEmail.Name = "fromEmail";
            fromEmail.Size = new Size(87, 20);
            fromEmail.TabIndex = 20;
            fromEmail.Text = "From Email:";
            fromEmail.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(803, 220);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 21;
            label1.Text = "To Email:";
            label1.Visible = false;
            // 
            // body
            // 
            body.AutoSize = true;
            body.Location = new Point(574, 385);
            body.Name = "body";
            body.Size = new Size(88, 20);
            body.TabIndex = 23;
            body.Text = "Description:";
            body.Visible = false;
            // 
            // txtBody
            // 
            txtBody.Enabled = false;
            txtBody.Location = new Point(574, 417);
            txtBody.Margin = new Padding(3, 4, 3, 4);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.PlaceholderText = "Enter your customized paragraph here.";
            txtBody.Size = new Size(351, 136);
            txtBody.TabIndex = 22;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(465, 548);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(91, 60);
            editBtn.TabIndex = 24;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Location = new Point(574, 299);
            subject.Name = "subject";
            subject.Size = new Size(61, 20);
            subject.TabIndex = 26;
            subject.Text = "Subject:";
            subject.Visible = false;
            // 
            // txtSubject
            // 
            txtSubject.Enabled = false;
            txtSubject.Location = new Point(574, 331);
            txtSubject.Margin = new Padding(3, 4, 3, 4);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(204, 27);
            txtSubject.TabIndex = 25;
            txtSubject.Text = "About your request";
            // 
            // sendBtn
            // 
            sendBtn.Enabled = false;
            sendBtn.Location = new Point(574, 601);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(94, 60);
            sendBtn.TabIndex = 27;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += send_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(465, 548);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(91, 60);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Visible = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // getMailBtn
            // 
            getMailBtn.Location = new Point(291, 672);
            getMailBtn.Name = "getMailBtn";
            getMailBtn.Size = new Size(88, 53);
            getMailBtn.TabIndex = 29;
            getMailBtn.Text = "Get mail";
            getMailBtn.UseVisualStyleBackColor = true;
            getMailBtn.Click += getMailBtn_Click;
            // 
            // getReqBtn
            // 
            getReqBtn.Location = new Point(407, 672);
            getReqBtn.Name = "getReqBtn";
            getReqBtn.Size = new Size(88, 53);
            getReqBtn.TabIndex = 30;
            getReqBtn.Text = "Get request";
            getReqBtn.UseVisualStyleBackColor = true;
            getReqBtn.Click += getReqBtn_Click;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 796);
            Controls.Add(getReqBtn);
            Controls.Add(getMailBtn);
            Controls.Add(cancelBtn);
            Controls.Add(sendBtn);
            Controls.Add(subject);
            Controls.Add(txtSubject);
            Controls.Add(editBtn);
            Controls.Add(body);
            Controls.Add(txtBody);
            Controls.Add(label1);
            Controls.Add(fromEmail);
            Controls.Add(txtToEmail);
            Controls.Add(txtFromEmail);
            Controls.Add(txtNoti);
            Controls.Add(backBtn);
            Controls.Add(button2);
            Controls.Add(denyBtn);
            Controls.Add(acceptBtn);
            Controls.Add(txtDate);
            Controls.Add(txtStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(submitDate);
            Controls.Add(status);
            Controls.Add(description);
            Controls.Add(phoneNumber);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(requestDgv);
            Name = "Request";
            Text = "Request";
            ((System.ComponentModel.ISupportInitialize)requestDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView requestDgv;
        private Label name;
        private Label email;
        private Label phoneNumber;
        private Label description;
        private Label status;
        private Label submitDate;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDescription;
        private TextBox txtStatus;
        private TextBox txtDate;
        private Button acceptBtn;
        private Button denyBtn;
        private Button button2;
        private Button backBtn;
        private Label txtNoti;
        private TextBox txtFromEmail;
        private TextBox txtToEmail;
        private Label fromEmail;
        private Label label1;
        private Label body;
        private TextBox txtBody;
        private Button editBtn;
        private Label subject;
        private TextBox txtSubject;
        private Button sendBtn;
        private Button cancelBtn;
        private Button getMailBtn;
        private Button getReqBtn;
    }
}