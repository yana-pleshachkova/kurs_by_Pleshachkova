using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace DVDS
{
    /*
     * Модель пользователя
     */
    public class User
    {
        /*
         * Основные поля пользователя
         */
        public int Id { get; protected set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patrnumyc { get; set; }
        public string Phones { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public DateTime PassportYear { get; set; }
        public string PassportIssuer { get; set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime DeletedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public int Role { get; set; }

        /*
         * Пустой констурктор
         */
        public User() { }

        /*
         * Контсрутор с основной информацией
         */
        public User(string login, string password, string email,
            string firstName, string lastName, string patrnumyc,
            string phones, DateTime birthDate,
            int passportNumber, DateTime passportYear, string passportIssuer)
        {
            Login = login;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Patrnumyc = patrnumyc;
            Phones = phones;
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            PassportYear = passportYear;
            PassportIssuer = passportIssuer;
        }

        /*
         * Хеширование пароля пользоватея, для того, чтобы не хранить в БД в открытом виде
         */
        public string HashPassword(string password)
        {
            return BitConverter.ToString(
                SHA256.Create().ComputeHash(
                    Encoding.UTF8.GetBytes(password)
                    )
                ).Replace("-", "").ToLower();
        }

        /*
         * Авторизация пользователя в системе по login и password
         */
        public User LoginUser(string login, string password)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                string hashedPassword = HashPassword(password);

                // Формируем команду для выбора 1-го пользователя по логину и паролю
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `users` WHERE `login` = @login AND `password_hash` = @password AND `deleted_at` IS NULL LIMIT 0, 1";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    if (userData.Read()) // Считываем данные - здесь приходит только 1 строка
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

                        connect.CloseConnection(); // Закрываем соединение с БД

                        return userInfo; // Возвращаем результат
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
        }

        /*
         * Получение информации о пользователе по id
         */
        public static User GetUser(int id = 0)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `users` WHERE `id` = @userId AND `deleted_at` IS NULL LIMIT 0, 1";
                cmd.Parameters.AddWithValue("@userId", id);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    if (userData.Read()) // Считываем данные - здесь приходит только 1 строка
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

                        connect.CloseConnection(); // Закрываем соединение с БД

                        return userInfo; // Возвращаем результат
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
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

        /*
         * Удалить пользователя из системы по id
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
         * Создание сессии пользователя
         */
        public Session CreateSession()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД
            string token = Guid.NewGuid().ToString();
            long lastInsertId = 0;
            Session newSession = null;

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для генерации сесии пользовтаеля
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "INSERT INTO `tokens` VALUES(NULL, @userId, @token, NULL, CURRENT_TIMESTAMP)";
                cmd.Parameters.AddWithValue("@userId", Id);
                cmd.Parameters.AddWithValue("@token", token);
                cmd.Prepare();

                cmd.ExecuteReader(); // Выполним запрос

                lastInsertId = cmd.LastInsertedId;

                connect.CloseConnection(); // Закрываем соединение с БД
            }

            connect = new DbConnect();

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `tokens` WHERE `id` = @lastId";
                cmd.Parameters.AddWithValue("@lastId", lastInsertId);
                cmd.Prepare();

                MySqlDataReader sessionData = cmd.ExecuteReader(); // Выполним запрос

                if (sessionData.HasRows) // Если запрос возвратил какой-либо результат, то
                {

                    if (sessionData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        newSession = new Session(Id, token, DateTime.Parse(sessionData["created_at"].ToString()).ToFileTime(), Role);
                    }

                    connect.CloseConnection(); // Закрываем соединение с БД

                    return newSession;
                }

                connect.CloseConnection(); // Закрываем соединение с БД

                return null;
            }

            return null;
        }

        /*
         * Получить список пользователей по идентификатору роли 
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

        /*
         * Получить роль пользотваеля по ID роли
         */
        public static string GetUserStringRole(int role)
        {
            if (role == 1)
            {
                return "Администратор";
            }

            if (role == 2)
            {
                return "Менеджер";
            }

            if (role == 3)
            {
                return "Клиент";
            }

            return "НЕОПРЕДЕЛЕН";
        }
    }
}