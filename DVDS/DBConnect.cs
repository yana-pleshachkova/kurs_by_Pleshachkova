using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DVDS
{
    internal class DbConnect
    {
        public MySqlConnection Connection { get; private set; }
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        // Конструктор класса
        public DbConnect()
        {
            Initialize();
        }

        // Инициализация соединения с БД
        private void Initialize()
        {
            _server = "localhost";
            _database = "DVD";
            _uid = "root";
            _password = "";

            var connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
                                      _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";

            Connection = new MySqlConnection(connectionString);
        }

        // Открываем соединение с БД
        public bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Обработка ошибок
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show(@"Невозможно установить соедения с БД. Свяжитесь с администратором.");
                        break;

                    case 1045:
                        MessageBox.Show(@"Некорректный логин/пароль. Попробуйте еще раз.");
                        break;
                }
                return false;
            }
        }

        // Закрываем соединение
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
