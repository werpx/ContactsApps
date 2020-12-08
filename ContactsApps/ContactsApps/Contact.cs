using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
    /// <summary>
    /// Класс, содержащий 6 полей: фамилия, имя, номер тел, дата рождения, mail, IDвк
    /// </summary>
    public class Contact : IComparable<Contact>
    {
        private string _lastname;
        private string _name;
        private Phone _number;
        private DateTime _birthdate;
        private string _email;
        private string _vkid;

        /// <summary>
        /// Фамилия контакта, ограничение в 50 символов
        /// </summary>
        public string Lastname
        {
            get { return _lastname; }
            set
            {

                if (value.Length > 50)
                {
                    throw new ArgumentException("максимальное количество символов = 50!");
                }
                else
                {
                    {
                        _lastname = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                    }
                }
            }
        }
        /// <summary>
        /// Имя контакта, ограничение в 50 символов
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("максимальное количество символов = 50!");
                }
                else
                {
                    
                        _name = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                    
                }
            }
        }
        /// <summary>
        /// номер телефона контакта
        /// </summary>
        public Phone Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }
        /// <summary>
        /// дата рождения контакта, год не может быть меньше 1900 и не может быть более текущей даты
        /// </summary>
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                if (value.Year < 1900 || value > DateTime.Now)
                    throw new ArgumentException("дата рождения должна лежать в промежутке между 1900 и сейчас");
                else
                    _birthdate = value;
            }
        }
        /// <summary>
        /// электронная почта контакта, ограничение в 50 символов
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("максимальное количество символов = 50!");
                }
                else
                {
                    _email = value;
                }
            }
        }
        /// <summary>
        /// ВКайди контакта, ограничение в 15 символов
        /// </summary>
        public string VKid
        {
            get { return _vkid; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("максимальное количество символов = 15!");
                }
                else
                {
                    _vkid = value;
                }
            }
        }

        public override string ToString()
        {
            var name = Name;
            var lastname = Lastname;
            return lastname + " " + name;
        }
        public int CompareTo(Contact comparedObj)
        {
            return this.Lastname.CompareTo(comparedObj.Lastname);
        }
    }
}
