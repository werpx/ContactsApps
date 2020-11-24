using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApps;

namespace ContactsAppsUI
{

    public partial class Main_Form : Form
    {
        public Project project;
        private BindingList<Contact> _formlist;
        public string _filename = "ContactsApp.txt";
        public string _filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Main_Form()
        {
            InitializeComponent();
            project = new Project();

            //Phone phone = new Phone();
            //phone.Number = "79998887766";

            //Contact contact1 = new Contact();
            //contact1.Name = "petya";
            //contact1.Lastname = "pEtRoVS";
            //contact1.Number = phone;
            //contact1.VKid = "12456";
            //contact1.Birthdate = new DateTime(2000, 12, 3);
            //contact1.Email = "mail@mail.ru";

            //Contact contact2 = new Contact();
            //contact2.Name = "petsdya";
            //contact2.Lastname = "pfffEtRoVS";
            //contact2.Number = phone;
            //contact2.VKid = "1245ss6";
            //contact2.Birthdate = new DateTime(2000, 12, 3);
            //contact2.Email = "masfil@mail.ru";

            //project._contactlist.Add(contact1);
            //project._contactlist.Add(contact2);
            //ProjectManager.SaveToFile(project, (_filepath + @"\" + _filename));
        }
        private void RefreshContactInfo()
        {
            if (_formlist.Count != 0)
            {
                var index = ContactsListBox.SelectedIndex;

                Contact _selectedContact = index == -1 ? _formlist.Last() : _formlist[index];

                var name = _selectedContact.Name;
                var lastname = _selectedContact.Lastname;

                NameTextBox.Text = name;
                LastnameTextBox.Text = lastname;

                BirthdateDateTimePicker.Text = _selectedContact.Birthdate.ToString();

                MaskedPhoneTextBox.Text =  _selectedContact.Number.Number.ToString();

                EmailTextBox.Text = _selectedContact.Email;
                VKidTextBox.Text = _selectedContact.VKid;
            }
            else
            {
                ClearContactInfo();
            }
        }
        private void ClearContactInfo()
        {
            NameTextBox.Text = "";
            LastnameTextBox.Text = "";
            BirthdateDateTimePicker.Text = "";
            MaskedPhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            VKidTextBox.Text = "";
        }
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactInfo();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (File.Exists(_filepath + @"\" + _filename))
            {
                _formlist = new BindingList<Contact>(ProjectManager.LoadFromFile(_filepath + @"\" + _filename)._contactlist);
            }
            else
            {
                _formlist = new BindingList<Contact>();
            }
            ContactsListBox.DataSource = _formlist;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form aboutForm = new About_Form();
            aboutForm.ShowDialog();

        }
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            Edit_Form _editForm = new Edit_Form();
            DialogResult _result = _editForm.ShowDialog(this);
            if (_result == DialogResult.Cancel)
            {
                _editForm.Close();
            }
            else if (_result == DialogResult.OK)
            {
                _formlist.Add(_editForm._current);
                _editForm.Close();
                RefreshContactInfo();
            }
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Вы действительно хотите удалить данный контакнт?","Подтверждение",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _formlist.Remove((Contact)ContactsListBox.SelectedItem);
                    RefreshContactInfo();
                }
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            Edit_Form _editform = new Edit_Form();

            _editform._current = _formlist[ContactsListBox.SelectedIndex];

            DialogResult _result = _editform.ShowDialog(this);
            if (_result == DialogResult.Cancel)
                _editform.Close();
            else if (_result == DialogResult.OK)
            {
                _formlist[ContactsListBox.SelectedIndex] = _editform._current;
                _editform.Close();
            }
           RefreshContactInfo();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.* ";
            fileDialog.FileName = "ContactsApp";
            project._contactlist = _formlist.ToList();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            ProjectManager.SaveToFile(project, (_filepath + @"\" + _filename));
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "contacts(*.txt)| *.txt | All files(*.*) | *.* ";
            fileDialog.FileName = "ContactsApp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _formlist = new BindingList<Contact>(ProjectManager.LoadFromFile(fileDialog.FileName)._contactlist);
                ContactsListBox.DataSource = _formlist;
            }
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
