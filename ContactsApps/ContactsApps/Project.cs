using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
    class Project
    {
        /// <summary>
        /// Список из объектов класса Contact
        /// </summary>
        private List<IContact> _contactlist;

        public List<IContact> Contactlist
        {
            get { return _contactlist; }
            set
            {
                _contactlist = value;
            }
        }

    }
}
