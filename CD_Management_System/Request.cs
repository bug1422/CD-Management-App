using Services.Models;
using Services.Repository;

using System.Data;

using System.Net.Mail;

using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
namespace CD_Management_System
{
    public partial class Request : Form
    {
        static Request f;
        RequestRepository rr;
        Services.Models.Request? req;
        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string FileAttactment { get; set; }
        }

        public Request()
        {
            InitializeComponent();
            rr = new RequestRepository();
            updateDvg();
        }

        // components

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You haven't selected any request!", "No request selected");
                return;
            }
            sendEmail("accept");
            clearAllSelected(this);
            setStatusToTrue();
            txtFromEmail.Text = Constants.EMAIL;
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You haven't selected any request!", "No request selected");
                return;
            }
            sendEmail("deny");
            clearAllSelected(this);
            setStatusToTrue();
            txtFromEmail.Text = Constants.EMAIL;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You haven't selected any request!", "No request selected");
                return;
            }
            enableEmail(true);
            txtToEmail.Text = req.Email;
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSubject.Text) || String.IsNullOrEmpty(txtBody.Text))
            {
                MessageBox.Show("There're blank box in the form!", "Insufficient data form");
                return;
            }
            sendEmail("custom");
            enableEmail(false);
            clearAllSelected(this);
            setStatusToTrue();
            txtFromEmail.Text = Constants.EMAIL;
            txtToEmail.Text = req.Email;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            enableEmail(false);
            txtBody.Text = "";
            txtToEmail.Text = "";
        }

        private void sendEmail(string opt)
        {
            txtNoti.Visible = true;
            string fromEmail = "cdalbumcompany@gmail.com";
            string toEmail = "binlambaobao142@gmail.com";
            //string toEmail = req.Email;
            string body = String.Format("Hi {0}, thank you for reaching out with us. It's our pleasure to work with you.\n", req.CustomerName);
            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress(fromEmail);
                mm.To.Add(toEmail);
                mm.Subject = "About your Order";
                switch (opt)
                {
                    case "accept":
                        {
                            body += "Therefore, We accept your request. Please wait for 5-7 days for further notifications.";
                            break;
                        }
                    case "deny":
                        {
                            body += "Unfortunately, We can't not handle your request at the moment. Please try again 3-4 months later.";
                            break;
                        }
                    case "custom":
                        {
                            body += txtBody.Text;
                            break;
                        }
                }
                mm.Body = body;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(fromEmail, "jfiqypuiwmzrscjh");
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("Email has been sent.", "Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void enableEmail(bool enable)
        {
            txtFromEmail.Enabled = enable;
            txtToEmail.Enabled = enable;
            txtBody.Enabled = enable;
            txtSubject.Enabled = enable;
            acceptBtn.Enabled = !enable;
            denyBtn.Enabled = !enable;
            editBtn.Enabled = !enable;
            sendBtn.Enabled = enable;
            cancelBtn.Visible = enable;

        }

        private void setStatusToTrue()
        {
            try
            {
                txtStatus.Text = "Completed";
                req.Status = true;
                rr.Update(req);
                MessageBox.Show("Update complete!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void getMailBtn_Click(object sender, EventArgs e)
        {
            getAllMail();
            
        }

        private void getReqBtn_Click(object sender, EventArgs e)
        {
            updateDvg();
        }


        // functions
        private void clearAllSelected(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                if (c.Controls.Count > 0)
                {
                    clearAllSelected(c);
                }
            }
        }

        public async void getAllMail()
        {
            // Initialize
            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();

            // Access gmail's inbox
            mailClient.Connect("imap.gmail.com", 993);
            mailClient.Authenticate(Constants.EMAIL, Constants.PASS);
            var folder = await mailClient.GetFolderAsync(Constants.FOLDER_HEAD);
            await folder.OpenAsync(MailKit.FolderAccess.ReadWrite);

            // Get each mail
            IList<UniqueId> uids = folder.Search(SearchQuery.All);
            foreach (UniqueId uid in uids)
            {
                // Get mail's components
                MimeMessage message = folder.GetMessage(uid);
                if (message.From.ToString().ToLower().Contains("google")) continue;
                var emailInfo = new EmailInfo();
                emailInfo.Id = uid.ToString();
                emailInfo.From = message.From.ToString();
                emailInfo.TimeReceive = message.Date;
                emailInfo.Subject = message.Subject;
                emailInfo.Body = message.TextBody;
                var fileAttachment = new List<string>();

                // Store file attachments into a list
                foreach (MimeEntity attachment in message.Attachments)
                {
                    // Add file
                    var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                    fileAttachment.Add(fileName);

                    // If file decode to stream, if text write to stream
                    using (var stream = File.Create(fileName))
                    {
                        if (attachment is MessagePart)
                        {
                            var rfc822 = (MessagePart)attachment;
                            rfc822.Message.WriteTo(stream);
                        }
                        else
                        {
                            var part = (MimePart)attachment;
                            part.Content.DecodeTo(stream);
                        }
                    }
                }
                emailInfo.FileAttactment = string.Join("; ", fileAttachment);
                listEmail.Add(emailInfo);
            }
            requestDgv.DataSource = listEmail.Select(p => new { p.From, p.Subject, p.Body, p.TimeReceive }).ToList();
        }

        public void updateDvg()
        {
            requestDgv.DataSource = rr.GetAll().Select(p => new { p.RequestId, p.CustomerName, p.PhoneNumber, p.Email, p.Description, status = p.Status ? "Completed" : "Pending", p.SubmitDate }).ToList();
        }

        private void requestDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else if (requestDgv.Columns[0].HeaderText != "RequestId") return;
            string? requestId = requestDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            req = rr.GetAll().ToList().FirstOrDefault(p => p.RequestId.ToString() == requestId);
            txtName.Text = req.CustomerName;
            txtPhone.Text = req.PhoneNumber;
            txtEmail.Text = req.Email;
            txtDescription.Text = req.Description;
            txtStatus.Text = req.Status ? "Completed" : "Pending";
            txtDate.Text = req.SubmitDate.ToString("dd-mm-yyyy");
        }
    }
}
