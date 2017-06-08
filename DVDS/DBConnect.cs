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
            Initialize(); //вызов метода инициализации
        }

        // Инициализация соединения с БД
        private void Initialize()
        {
            _server = "localhost";
            _database = "DVD";
            _uid = "root";
            _password = ""; //тестируем локально, поэтому может быть такой пароль

            var connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
                                      _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";

            Connection = new MySqlConnection(connectionString);
        }

        // Открываем соединение с БД
        public bool OpenConnection()
        {
            try //блок обработки ошибок, если ошибка перейдет в блок catch
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Обработка ошибок
                switch (ex.Number) //свитч для работы с кейсами действий
                {
                    case 0: //номер ошибки которая может выйти
                        MessageBox.Show(@"Невозможно установить соедения с БД. Свяжитесь с администратором.");
                        break;

                    case 1045: ////номер ошибки которая может выйти
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
