using System;
using System.Windows.Forms;

namespace DVDS
{
    /*
     * Представление формы авторизации
     */
    public partial class LoginForm : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);

            loginAvatar.Image = Properties.Resources.LoginAvatar;
            passwordAvatar.Image = Properties.Resources.LoginPassword;
            mainLogin.Image = Properties.Resources.LoginMain;
        }

        private void LoginUserInSystem(object sender, EventArgs e)
        {
            _presenter.Login();
        }

        // Intarface implemants ==================
        
        /*
         * Получаем введенные пользователем данные login и password из формы
         */
        public string[] GetLoginData()
        {
            return new[] { loginTextBox.Text, passwordTextBox.Text };
        }

        /*
         * Показываем предупрежедение с сообщением
         */
        public void ShowAlert(string alert)
        {
            MessageBox.Show(alert);
        }

        /*
         * Показываем основную форму
         */
        public void ShowMainWindow(int userId)
        {
            Main newMain = new Main(userId); // Создаем экземпляр основной формы
            newMain.FormClosed += MainFormClosed; // Обработчик для закрытия основной формы
            newMain.Show(); // Показываем новую форму
            Hide(); // Скрываем эту форму - Авторизации
        }

        // This form methods =====================

        /*
         * Закрываем форму - Авторизации
         */
        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        /*
         * Метод, который назначен для полей login и password для отслеживания
         * нажатия клавиши Enter, для того, чтобы попробовать авторизоваться
         */
        private void KeyDownEnterLogin(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _presenter.Login();
            }
        }
    }
}
