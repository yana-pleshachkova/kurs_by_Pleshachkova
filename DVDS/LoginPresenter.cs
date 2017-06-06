namespace DVDS
{
    /*
     * Презентер для формы авторизации
     */
    class LoginPresenter
    {
        private readonly ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
        }

        /*
         * Отображение основной формы, после авторизации пользователя
         */
        public void Login()
        {
            User user = new User();
            string[] loginData = _view.GetLoginData(); // Получаем данные login и password из формы
            user = user.LoginUser(loginData[0], loginData[1]); // Производим авторизацию пользователя

            if (!Equals(user, null)) // Если пользователь найден
            {
                _view.ShowMainWindow(user.Id); // Отображаем основную форму

                return;
            }

            // Если пользователь не наден, то сообщаем об ошибке
            _view.ShowAlert("Неправильный логин или пароль. Попробуйте еще раз, пожалуйста.");
        }
    }
}
