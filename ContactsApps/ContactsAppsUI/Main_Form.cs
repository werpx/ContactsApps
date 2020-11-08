using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public string filename = @"C:\Users\1\Documents\ContactsApp.txt";

        public Main_Form()
        {
            InitializeComponent();

            project = new Project();

            Phone phone = new Phone();
            phone.Number = 79998887766;

            Contact contact = new Contact();
            contact.Name = "petya";
            contact.Lastname = "pEtRoVS";
            contact.Number = phone;
            contact.VKid = "12456";
            contact.Birthdate = new DateTime(2000, 12, 3);
            contact.Email = "mail@mail.ru";

            textBox1.Text = contact.Lastname;
            textBox2.Text = contact.Name;

            project._contactlist.Add(contact);
            ProjectManager.SaveToFile(project, filename);
            project = null;
            ProjectManager.LoadFromFile(filename);
        }
                    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
