using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApps;

namespace console
{
    class Program
    {

        static void Main(string[] args)
        {
            string filename = @"C:\Users\1\Documents\ContactsApp.txt";
            Project project = new Project();

            Phone phone = new Phone();
            phone.Number = 79998887766;

            Contact contact = new Contact();
            contact.Name = "petya";
            contact.Lastname = "pEtRoVS";
            contact.Number = phone;
            contact.VKid = "12456";
            contact.Birthdate = new DateTime(2000, 12, 3);
            contact.Email = "mail@mail.ru";

            project._contactlist.Add(contact);
            ProjectManager.SaveToFile(project, filename);
            project = null;
            project = ProjectManager.LoadFromFile(filename);

            string _telnumber = Convert.ToString(contact.Number.Number);
            string _bdate = Convert.ToString(contact.Birthdate.Date);

            //textBox1.Text = contact.Name;
            //textBox2.Text = contact.Lastname;
            //textBox3.Text = _telnumber;
            //textBox4.Text = contact.VKid;
            //textBox5.Text = _bdate;
            //textBox6.Text = contact.Email;
            Console.WriteLine("{1},{0},{2} ",contact.Name, contact.Lastname, contact.Email);
            Console.ReadKey();
        }
    }
}
