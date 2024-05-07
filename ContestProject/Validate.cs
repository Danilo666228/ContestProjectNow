using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestProject
{
    public class Validate
    {
        public bool RegistrationUser(string email, string password, string repeatpassword, string gender, string fullname, string phone, string role)
        {
            var IsCorrectPhone = new Regex(@"^8\(\d{3}\)\d{3}-\d{2}-\d{2}$");
            var EmailValidate = new Regex(@"@");
            if (string.IsNullOrWhiteSpace(email)
               || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(gender)
                || string.IsNullOrWhiteSpace(fullname)
                || string.IsNullOrWhiteSpace(phone)
                || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            if(!IsCorrectPhone.IsMatch(phone))
            {
                MessageBox.Show("Введите корректный номер");
                return false;
            }
            if(password != repeatpassword)
            {
                MessageBox.Show("Пароли должны совпадать");
                return false;
            }
            if(!EmailValidate.IsMatch(email))
            {
                MessageBox.Show("Почта должно содержать символ @");
                return false;
            }
            return true;
        }
    }
}
