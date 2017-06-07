using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DVDS
{
    class Manager : User
    {
        public Manager() : base()
        {

        }

        public Manager(
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
         * Обновить информацию о пользователе по ID
         */
        public bool UpdateUser()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "UPDATE `users` SET `first_name` = @first_name, `last_name` = @last_name, " +
                                  "`patronumyc` = @patronumyc, `phones` = @phones, " +
                                  "`birth_date` = @birth_date, `passport_number` = @passport_number, " +
                                  "`passport_year` = @passport_year, `passport_issuer` = @passport_issuer, " +
                                  "`login` = @login, `email` = @email, " +
                                  "`role` = @role, `password_hash` = @password_hash WHERE `id` = @userId";
                cmd.Parameters.AddWithValue("@userId", Id);
                cmd.Parameters.AddWithValue("@phones", Phones);
                cmd.Parameters.AddWithValue("@first_name", FirstName);
                cmd.Parameters.AddWithValue("@last_name", LastName);
                cmd.Parameters.AddWithValue("@patronumyc", Patrnumyc);
                cmd.Parameters.AddWithValue("@birth_date", BirthDate);
                cmd.Parameters.AddWithValue("@passport_number", PassportNumber);
                cmd.Parameters.AddWithValue("@passport_year", PassportYear);
                cmd.Parameters.AddWithValue("@passport_issuer", PassportIssuer);
                cmd.Parameters.AddWithValue("@login", Login);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@role", Role);
                cmd.Parameters.AddWithValue("@password_hash", HashPassword(Password));
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

        /*
         * Удалить пользователя из системы по id
         */
        public bool CreateUser()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "INSERT INTO `users` VALUES (NULL, @first_name, @last_name, @patronumyc, " +
                                  "@phones, @birth_date, @passport_number, @passport_year, @passport_issuer, " +
                                  "NULL, NULL, NULL, @login, @password_hash, @email, @role)";
                cmd.Parameters.AddWithValue("@phones", Phones);
                cmd.Parameters.AddWithValue("@first_name", FirstName);
                cmd.Parameters.AddWithValue("@last_name", LastName);
                cmd.Parameters.AddWithValue("@patronumyc", Patrnumyc);
                cmd.Parameters.AddWithValue("@birth_date", BirthDate);
                cmd.Parameters.AddWithValue("@passport_number", PassportNumber);
                cmd.Parameters.AddWithValue("@passport_year", PassportYear);
                cmd.Parameters.AddWithValue("@passport_issuer", PassportIssuer);
                cmd.Parameters.AddWithValue("@login", Login);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@role", Role);
                cmd.Parameters.AddWithValue("@password_hash", HashPassword(Password));
                cmd.Prepare();

                int userDataAffectedRows = cmd.ExecuteNonQuery(); // Выполним запрос

                if (userDataAffectedRows != 0) // Если запрос возвратил какой-либо результат, то
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

        /*
         * Получить список пользователей по идентификатору роли 
         */
        public static ArrayList GetUsersByRole(int role)
        {
            var users = new ArrayList();

            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `users` WHERE `role` = @role AND `deleted_at` IS NULL";
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (userData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        // Создаем новый объект пользователя
                        User userInfo = new User(
                            userData["login"].ToString(),
                            "",
                            userData["email"].ToString(),
                            userData["first_name"].ToString(),
                            userData["last_name"].ToString(),
                            userData["patronumyc"].ToString(),
                            userData["phones"].ToString(),
                            DateTime.Parse(userData["birth_date"].ToString()),
                            int.Parse(userData["passport_number"].ToString()),
                            DateTime.Parse(userData["passport_year"].ToString()),
                            userData["passport_issuer"].ToString()
                        )
                        {
                            Id = int.Parse(userData["id"].ToString()),
                            CreatedAt = DateTime.Parse(userData["created_at"].ToString()),
                            UpdatedAt = DateTime.Parse(userData["updated_at"].ToString()),
                            Role = int.Parse(userData["role"].ToString())
                        };

                        users.Add(userInfo);
                    }

                    connect.CloseConnection(); // Закрываем соединение с БД

                    return users;
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
        }

        /*
         * Поиск пользователей по ключевому слову и роли 
         */
        public static ArrayList UsersSearch(string searchText, int role)
        {
            var users = new ArrayList();

            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `users` WHERE (`first_name` LIKE @searchText OR `last_name` LIKE @searchText OR `patronumyc` LIKE @searchText OR `phones` LIKE @searchText) AND `deleted_at` IS NULL AND `role` = @role";
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (userData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        // Создаем новый объект пользователя
                        User userInfo = new User(
                            userData["login"].ToString(),
                            "",
                            userData["email"].ToString(),
                            userData["first_name"].ToString(),
                            userData["last_name"].ToString(),
                            userData["patronumyc"].ToString(),
                            userData["phones"].ToString(),
                            DateTime.Parse(userData["birth_date"].ToString()),
                            int.Parse(userData["passport_number"].ToString()),
                            DateTime.Parse(userData["passport_year"].ToString()),
                            userData["passport_issuer"].ToString()
                        )
                        {
                            Id = int.Parse(userData["id"].ToString()),
                            CreatedAt = DateTime.Parse(userData["created_at"].ToString()),
                            UpdatedAt = DateTime.Parse(userData["updated_at"].ToString()),
                            Role = int.Parse(userData["role"].ToString())
                        };

                        users.Add(userInfo);
                    }

                    connect.CloseConnection(); // Закрываем соединение с БД

                    return users;
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
        }
    }
}
