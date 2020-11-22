using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
    /// <summary>
    /// Класс, содержащий номер телефона.
    /// </summary>
    public class Phone 
    {
        private string _number;
        public string Number
        {
            get { return _number; }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер телефона должен содержать 11 цифр");
                }
                
                else if (value.Substring(0, 1) != "7")
                {
                    throw new ArgumentException("Номер телефона должен начинаться с 7 ");
                }
                
                    _number = value;
            }
        }
        public Phone()
        {
            _number = "";
        }
    }

}
