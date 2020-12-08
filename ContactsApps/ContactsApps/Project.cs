using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
   public class Project
    {
        /// <summary>
        /// Список из объектов класса Contact
        /// </summary>
        public List<Contact> _contactlist;

        public Project()
        {
            _contactlist = new List<Contact>(200);
        }
        /// <summary>
        /// Поиск контактов содержащих в своем имени или фамилии конкретной строчки
        /// </summary>
        /// <param name="lookforstring"></param>
        /// <returns></returns>
        public List<Contact> FindName(string lookforstring)
        {
            List<Contact> searchlist = new List<Contact>();
            searchlist.AddRange(_contactlist.FindAll(x => x.Lastname.Contains(lookforstring) || x.Name.Contains(lookforstring)));
            return searchlist;
            
        }
        /// <summary>
        /// поиск именинников из текущего списка контактов и создание списка из таких контактов
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Contact> BirthdayBoy(DateTime date)
        {
            var birthdateboyList = new List<Contact>();
            var Contactlist = new List<Contact>();
            Contactlist = _contactlist;
            foreach (Contact contact in Contactlist)
            {
                if (contact.Birthdate.Month == date.Month && contact.Birthdate.Day == date.Day)
                {
                    birthdateboyList.Add((contact));
                }
            }
            return birthdateboyList;
        }
    }
}
