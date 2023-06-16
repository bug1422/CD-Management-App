

using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Services;
using System.Text.RegularExpressions;

namespace CD_Management_System
{
    public partial class EmployeeManagement : Form
    {
        CDStoreContext _context = new CDStoreContext();
        List<Account> listEmployee = new List<Account>();
        AccountService _accountService;
        public EmployeeManagement()
        {
            InitializeComponent();
            getAllEmployees();

        }
        private void getAllEmployees()
        {
            _accountService = new AccountService();
            var listEmployee = _accountService.GetAll().Include(p => p.Role).Select(p => new
            {
                p.AccountId,
                p.UserName,
                p.FullName,
                p.Role.RoleName,
                p.Email,
                p.Address,
                p.PhoneNumber
            }).ToList();
            dgvEmployee.DataSource = new BindingSource()
            {
                DataSource = listEmployee
            };

        }

        private void chooseEmployee(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvEmployee[0, e.RowIndex].Value;
            var selectedEmployee = _accountService.GetAll()
                .Where(p => p.AccountId.Equals(id))
                .FirstOrDefault();
            if (selectedEmployee != null)
            {
                txtAccountId.Text = selectedEmployee.AccountId.ToString();
                txtUserName.Text = selectedEmployee.UserName;
                txtFullName.Text = selectedEmployee.FullName;
                txtEmail.Text = selectedEmployee.Email;
                txtAddress.Text = selectedEmployee.Address;
                txtPhoneNumber.Text = selectedEmployee.PhoneNumber;

            }
        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            Account account = new Account();
            if ( txtUserName.Text == ""
                || txtFullName.Text == ""
                || txtEmail.Text == ""
                || txtAddress.Text == ""
                || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Khong the de trong o nhap", "Thong bao", MessageBoxButtons.OK);
            }
            else if (!emailRegex(txtEmail.Text))
            {
                MessageBox.Show("Email sai format", "Thong bao", MessageBoxButtons.OK);
            }
            else if (!phoneNumberRegex(txtPhoneNumber.Text))
            {
                MessageBox.Show("So dien thoai sai format", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                account.AccountId = Int32.Parse(txtAccountId.Text);
                account.UserName = txtUserName.Text;
                account.FullName = txtFullName.Text;
                account.Email = txtEmail.Text;
                account.Address = txtAddress.Text;
                account.PhoneNumber = txtPhoneNumber.Text;
                account.RoleId = "EM";
                _accountService.Create(account);
                refreshList();
            }
                
        }
        

        private bool phoneNumberRegex(string phoneNumber)
        {
            var regex = new Regex("^\\(?([0]{1})\\)?[-. ]?([0-9]{9})$");
            bool valid = true;
            if (!regex.IsMatch(phoneNumber))
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        private bool emailRegex(string email)
        {
            var regex = new Regex("^\\S+@\\S+\\.\\S+$");
            bool valid = true;
            if (!regex.IsMatch(email))
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        public void refreshList(List<Account> list = null)
        {
            if (list != null)
            {
                dgvEmployee.DataSource = new BindingSource()
                {
                    DataSource = list
                };
            }
            else
            {

                dgvEmployee.DataSource = _accountService.GetAll().Select(p => new
                {
                    p.AccountId,
                    p.UserName,
                    p.FullName,
                    p.Email,
                    p.Address,
                    p.PhoneNumber
                }).ToList();
            }
        }
    }
}
