using System;
using System.Collections.Generic;
using System.Text;
using ContactsApps;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    class ProjectManagerTest
    {
        private Project actualproject = new Project();
        private Project expectedproject = new Project();
       

        [Test(Description = "Тест метода SaveToFile")]
        public void TestSaveToFile_CorrectValue()
        {
            var _path = @"C:\Users\1\Documents\ContactsApp.txt";
            Phone expectedphone = new Phone();
            expectedphone.Number = 79998887766;

            Contact expectedcontact = new Contact();
            expectedcontact.Name = "petysdaa";
            expectedcontact.Lastname = "pEtRoasdVS";
            expectedcontact.Number = expectedphone;
            expectedcontact.VKid = "12456";
            expectedcontact.Birthdate = new DateTime(2000, 12, 3);
            expectedcontact.Email = "mail@mafffil.ru";

            Phone actualphone = new Phone();
            actualphone.Number = 79998887766;

            Contact actualcontact = new Contact();
            actualcontact.Name = "petya";
            actualcontact.Lastname = "pEtRoVS";
            actualcontact.Number = actualphone;
            actualcontact.VKid = "12456";
            actualcontact.Birthdate = new DateTime(2000, 12, 3);
            actualcontact.Email = "mail@mail.ru";
            

            actualproject._contactlist.Add(actualcontact);
            ProjectManager.SaveToFile(actualproject, _path);
            expectedproject = null;
            expectedproject = ProjectManager.LoadFromFile(_path);
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedproject._contactlist[0].Name, actualproject._contactlist[0].Name, "Метод SaveToFile неправильно сохраняет проект(имя)");
                Assert.AreEqual(expectedproject._contactlist[0].Lastname, actualproject._contactlist[0].Lastname, "Метод SaveToFile неправильно сохраняет проект(фамилия)");
                Assert.AreEqual(expectedproject._contactlist[0].VKid, actualproject._contactlist[0].VKid, "Метод SaveToFile неправильно сохраняет проект(айди-вк)");
                Assert.AreEqual(expectedproject._contactlist[0].Email, actualproject._contactlist[0].Email, "Метод SaveToFile неправильно сохраняет проект(почта)");
                Assert.AreEqual(expectedproject._contactlist[0].Birthdate, actualproject._contactlist[0].Birthdate, "Метод SaveToFile неправильно сохраняет проект(дата рождения)");
                Assert.AreEqual(expectedproject._contactlist[0].Number.Number, actualproject._contactlist[0].Number.Number, "Метод SaveToFile неправильно сохраняет проект(номер телефогна)");
            }); 
            
        }
              
    }
}
