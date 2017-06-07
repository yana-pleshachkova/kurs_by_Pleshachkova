using System;
using System.Diagnostics;

namespace DVDS
{
    class UserFormPresenter
    {
        private readonly IUserFormView _view;
        private User _user;

        public UserFormPresenter(IUserFormView view)
        {
            _view = view;
        }


        /*
         * Установить значения в поля формы для пользователя
         */
        public void SetUserFields(int userId)
        {
            _user = User.GetUser(userId);

            if (Equals(_user, null))
            {
                _view.ShowAlert("Не удалось найти пользователя, попробуйте еще раз.");
            }

            _view.SetUserFields(_user);
        }

        /*
         * Обновить инофрмацию о пользователе или создать нового пользователя 
         */
        public bool UpdateUser(int role, string login, string password, string email,
            string firstName, string lastName, string patronumyc, string phones,
            DateTime birthDate, string passportNumber, DateTime passportYear, string passportIssuer)
        {
            bool isNull = false;
            Manager manager = null;
            if (Equals(_user, null))
            {
                isNull = true;
                manager = new Manager();
            }

            try
            {
                if (!isNull)
                {
                    _user.Role = role;
                    _user.Login = login;
                    _user.Password = password;
                    _user.Email = email;
                    _user.FirstName = firstName;
                    _user.LastName = lastName;
                    _user.Patrnumyc = patronumyc;
                    _user.Phones = phones;
                    _user.BirthDate = birthDate;
                    _user.PassportNumber = int.Parse(passportNumber);
                    _user.PassportYear = passportYear;
                    _user.PassportIssuer = passportIssuer;

                    return _user.UpdateUser(_view.GetUserSession());
                }

                manager.Role = role;
                manager.Login = login;
                manager.Password = password;
                manager.Email = email;
                manager.FirstName = firstName;
                manager.LastName = lastName;
                manager.Patrnumyc = patronumyc;
                manager.Phones = phones;
                manager.BirthDate = birthDate;
                manager.PassportNumber = int.Parse(passportNumber);
                manager.PassportYear = passportYear;
                manager.PassportIssuer = passportIssuer;

                return manager.CreateUser();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                _view.ShowAlert("Ошибка при сохранении данных пользователя. Попробуйте еще раз, пожалуйста.");

                return false;
            }
        }
    }
}
