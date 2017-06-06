using System;

namespace DVDS
{
    class UserFormPresenter
    {
        private IUserFormView _view;
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
            if (Equals(_user, null))
            {
                isNull = true;
                _user = new User();
            }

            try
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

                if (!isNull)
                {
                    return _user.UpdateUser();
                }

                return _user.CreateUser();
            }
            catch (Exception e)
            {
                _view.ShowAlert("Ошибка при сохранении данных пользователя. Попробуйте еще раз, пожалуйста.");

                return false;
            }
        }
    }
}
