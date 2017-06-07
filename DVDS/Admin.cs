using System;
using MySql.Data.MySqlClient;

namespace DVDS
{
    class Admin : Manager
    {

        public Admin() : base()
        {

        }

        public Admin(
            string login, string password, string email,
            string firstName, string lastName, string patrnumyc,
            string phones, DateTime birthDate,
            int passportNumber, DateTime passportYear, string passportIssuer
            ) : base(
                login, password, email, firstName, lastName, patrnumyc, phones,
                birthDate, passportNumber, passportYear, passportIssuer
                )
        {

        }

        /*
         * Удалить пользователя из системы по id
         */
        public static bool DeleteUser(int id = 0)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "UPDATE `users` SET `deleted_at` = CURRENT_TIMESTAMP WHERE `id` = @userId";
                cmd.Parameters.AddWithValue("@userId", id);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.RecordsAffected != 0) // Если запрос возвратил какой-либо результат, то
                {
                    connect.CloseConnection(); // Закрываем соединение с БД

                    return true; // Возвращаем результат
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return false; // Возвращаем результат
            }

            return false;
        }
    }
}
