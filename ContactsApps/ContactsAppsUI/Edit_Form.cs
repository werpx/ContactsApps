using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApps;
namespace ContactsAppsUI
{
    public partial class Edit_Form : Form
    {
        public Contact _current;
        public Edit_Form()
        {
            InitializeComponent();
        }
     
        private void EditContactForm_Load(object sender, EventArgs e)
        {
            if (_current != null)
            {
               
                var name = _current.Name;
                var lastname = _current.Lastname;

                NameTextBox.Text = name;
                LastnameTextBox.Text = lastname ;

                BirthdateDateTimePicker.Text = _current.Birthdate.ToString();

                PhoneTextBox.Text = _current.Number.Number;

                EmailTextBox.Text = _current.Email;
                VKidTextBox.Text = _current.VKid;
            }
            else
            {
                _current = new Contact();
            }
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                _current.Number = new Phone();
                _current.Name = NameTextBox.Text;
                _current.Lastname = LastnameTextBox.Text;
                _current.Birthdate = BirthdateDateTimePicker.Value;
                _current.Number.Number = PhoneTextBox.Text;
                _current.Email = EmailTextBox.Text;
                _current.VKid = VKidTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BanSpecialSymbols(object sender, KeyPressEventArgs e)
        {
            var reg = new Regex(@"[^a-zA-Z0-9\b\s]");
            if ((reg.IsMatch(e.KeyChar.ToString())))
            {
                e.Handled = true;
                this.BackColor = Color.Red;
            }
            else
                this.BackColor = Color.White;
        }



    }
}
