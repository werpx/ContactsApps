using System;
using ContactsApps;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void Setup()
        {
            _contact = new Contact();
        }

        [Test(Description = "Тест геттера Lastname")]
        public void TestLastnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.Lastname = expected;
            var actual = _contact.Lastname;
            Assert.AreEqual(expected, actual, "Геттер Lastname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест сеттера Lastname")]
        public void TestLastnameSet_CorrectValue()
        {
            var expected = "СмиРНов";
            _contact.Lastname = expected;
            var actual = "Смирнов";
            Assert.AreEqual(_contact.Lastname, actual, "Фамилия должна начинаться с буквы верхнего регистра, все остальные буквы должны быть нижнего регистра");
        }

        [Test(Description = "Негативный тест сеттера Lastname")]
        public void TestLastnameSet_UnCorrectValue()
        {
            var wronglastname = "СмиРНоввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввввв";
            _contact.Lastname = wronglastname;
            Assert.Throws<ArgumentException>(()=> { _contact.Lastname = wronglastname; }, "должно возникать исключение, если фамилия длиннее 50 символов");
        }
        /*====================================================================================================*/
        /*====================================================================================================*/
        [Test(Description = "Тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Имя";
            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            var expected = "ИМЯ";
            _contact.Name = expected;
            var actual = "Имя";
            Assert.AreEqual(_contact.Name, actual, "Имя должно начинаться с буквы верхнего регистра, все остальные буквы должны быть нижнего регистра");
        }

        [Test(Description = "Негативный тест сеттера Name")]
        public void TestNameSet_UnCorrectValue()
        {
            string wrongname = "имяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяяя";
            _contact.Name = wrongname;
            Assert.Throws<ArgumentException>(() => { _contact.Name = wrongname; }, "должно возникать исключение, если имя длиннее 50 символов");
        }
        /*====================================================================================================*/
        /*====================================================================================================*/
        [Test(Description = "Тест геттера Phone")]
        public void TestPhoneGet_CorrectValue()
        {
            var expected = new Phone();
            expected.Number = 79998886655; 
            _contact.Number = expected;
            var actual = _contact.Number;
            Assert.AreEqual(expected, actual, "Геттер Phone возвращает неправильный номер телефона");
        }

        [Test(Description = "Позитивный тест сеттера phone")]
        public void TestPhoneSet_CorrectValue()
        {
            var expected = new Phone();
            var actual = new Phone();
            expected.Number = 79998886655;
            _contact.Number = expected;
            actual = _contact.Number;
            Assert.AreEqual(expected, actual, "Номер телефона введен неправильно");
        }
        /*====================================================================================================*/
        /*====================================================================================================*/
        [Test(Description = "Тест геттера Birthdate")]
        public void TestBirthdateGet_CorrectValue()
        {
            var expected = new DateTime(1999, 10, 16);
            _contact.Birthdate = expected;
            var actual = _contact.Birthdate;
            Assert.AreEqual(expected, actual, "Геттер Birthdate возвращает неправильную дату");
        }

        [Test(Description = "Позитивный тест сеттера Birthdate")]
        public void TestBirthdateSet_CorrectValue()
        {
            var expected = new DateTime(1999, 10, 16);
            _contact.Birthdate = expected;
            var actual = _contact.Birthdate;
            Assert.AreEqual(expected, actual, "Дата введена неправильно");
        }

        [Test(Description = "Негативный тест сеттера Birthdate(год < 1900)")]
        public void TestBirthdateSet_TooLowValue()
        {
            var wrongbirthdate = new DateTime(1000, 10, 16);
            _contact.Birthdate = wrongbirthdate;
            Assert.Throws<ArgumentException>(() => { _contact.Birthdate = wrongbirthdate;  }, "должно возникать исключение, если год раньше 1900");
        }

        [Test(Description = "Негативный тест сеттера Birthdate(введеный дата больше текущей)")]
        public void TestBirthdateSet_TooBigValue()
        {
            var wrongbirthdate = new DateTime(3000, 10, 16);
            _contact.Birthdate = wrongbirthdate;
            Assert.Throws<ArgumentException>(() => { _contact.Birthdate = wrongbirthdate; }, "должно возникать исключение, если введеная дата больше текущей");
        }
        /*====================================================================================================*/
        /*====================================================================================================*/
        [Test(Description = "Тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "kek@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную почту");
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestEmailSet_CorrectValue()
        {
            var expected = "kek@mail.ru";
            _contact.Email = expected;
            var actual = "kek@mail.ru";
            Assert.AreEqual(expected, actual, "Почта введена неправильно");
        }

        [Test(Description = "Негативный тест сеттера Email")]
        public void TestEmailSet_UnCorrectValue()
        {
            var wrongemail = "kek@mail.ruuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu";
            _contact.Email = wrongemail;
            Assert.Throws<ArgumentException>(() => { _contact.Email = wrongemail; }, "должно возникать исключение, если почта длиннее 50 символов");
        }
        /*====================================================================================================*/
        /*====================================================================================================*/
        [Test(Description = "Тест геттера VKid")]
        public void TestVKidGet_CorrectValue()
        {
            var expected = "123";
            _contact.VKid = expected;
            var actual = _contact.VKid;
            Assert.AreEqual(expected, actual, "Геттер VKid возвращает неправильный айди");
        }

        [Test(Description = "Позитивный тест сеттера VKid")]
        public void TestVKidSet_CorrectValue()
        {
            var expected = "123";
            _contact.VKid = expected;
            var actual = "123";
            Assert.AreEqual(expected, actual, "вк-айди введен неправильно");
        }

        [Test(Description = "Негативный тест сеттера VKid")]
        public void TestVKidSet_UnCorrectValue()
        {
            var wrongevkid = "123123123123123123123123123123123123";
            _contact.VKid = wrongevkid;
            Assert.Throws<ArgumentException>(() => { _contact.VKid = wrongevkid; }, "должно возникать исключение, если вк-айди длиннее 15 символов");
        }
    }
}
