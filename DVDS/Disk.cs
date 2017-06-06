using System;
using System.Collections;
using System.Linq;
using MySql.Data.MySqlClient;

namespace DVDS
{
    /*
     * 
     * */

    public class Disk
    {
        /*
         * Основные поля пользователя
         */
        public long Id { get; protected set; }
        public int Count { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string DirectedBy { get; set; }
        public float Cost { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        /*
         * Пустой констурктор
         */
        public Disk() { }

        /*
         * Контсрутор с основной информацией
         */
        public Disk(string title, string about, DateTime year,
            string actors, string directedBy, float cost,int count)
        {
            Title = title;
            About = about;
            Year = year;
            Actors = actors;
            DirectedBy = directedBy;
            Cost = cost;
            Count = count;
        }

        /*
         * Получение информации о диске
         */
        public static Disk GetDisk(int id = 0)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `disks` WHERE `id` = @diskId AND `deleted_at` IS NULL LIMIT 0, 1";
                cmd.Parameters.AddWithValue("@diskId", id);
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                if (diskData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    if (diskData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        // Создаем новый объект пользователя
                        Disk diskInfo = new Disk(
                            diskData["title"].ToString(),
                            diskData["about"].ToString(),
                            DateTime.Parse(diskData["year"].ToString()),
                            diskData["actors"].ToString(),
                            diskData["directed_by"].ToString(),
                            float.Parse(diskData["cost"].ToString()),
                            int.Parse(diskData["count"].ToString())
                        )
                        {
                            Id = int.Parse(diskData["id"].ToString()),
                            CreatedAt = DateTime.Parse(diskData["created_at"].ToString()),
                            UpdatedAt = DateTime.Parse(diskData["updated_at"].ToString()),
                            Country = GetCountries(int.Parse(diskData["id"].ToString())),
                            Genre = GetGenres(int.Parse(diskData["id"].ToString()))
                        };

                        connect.CloseConnection(); // Закрываем соединение с БД

                        return diskInfo; // Возвращаем результат
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
        }

        private static string GetCountries(int diskId)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT c.id, c.name FROM `countries` as c, `disks_countries` as dc WHERE dc.id_country = c.id AND dc.id_disk = @diskId";
                cmd.Parameters.AddWithValue("@diskId", diskId);
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                string retData = "";

                if (diskData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (diskData.Read())
                    {
                        retData += diskData["id"] + " " + diskData["name"] + ",";
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return retData; // Возвращаем результат
            }

            return "";
        }

        private static string GetGenres(int diskId)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT g.id, g.title FROM genres as g, disks_genres as dg WHERE dg.genre_id = g.id AND dg.disk_id = @diskId";
                cmd.Parameters.AddWithValue("@diskId", diskId);
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                string retData = "";

                if (diskData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (diskData.Read())
                    {
                        retData += diskData["id"] + " " + diskData["title"] + ",";
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return retData; // Возвращаем результат
            }

            return "";
        }

        /*
         * Получить ID стран для диска
         */
        public ArrayList GetCountries()
        {
            string[] countries = Country.Split(',');
            ArrayList ids = new ArrayList();

            foreach (var contry in countries)
            {
                if (contry != "")
                {
                    ids.Add(int.Parse(contry.Split(' ')[0]) - 1);
                }
            }

            return ids;
        }

        /*
         * Получить ID жанров для диска
         */
        public ArrayList GetGenres()
        {
            string[] genres = Genre.Split(',');
            ArrayList ids = new ArrayList();

            foreach (var genre in genres)
            {
                if (genre != "")
                {
                    ids.Add(int.Parse(genre.Split(' ')[0]) - 1);
                }
            }

            return ids;
        }

        /*
         * Получить список пользователей по идентификатору роли 
         */
        public static ArrayList GetDisks()
        {
            var disks = new ArrayList();

            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `disks` WHERE `deleted_at` IS NULL";
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                if (diskData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (diskData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        // Создаем новый объект диска
                        Disk diskInfo = new Disk(
                            diskData["title"].ToString(),
                            diskData["about"].ToString(),
                            DateTime.Parse(diskData["year"].ToString()),
                            diskData["actors"].ToString(),
                            diskData["directed_by"].ToString(),
                            float.Parse(diskData["cost"].ToString()),
                            int.Parse(diskData["count"].ToString())
                        )
                        {
                            Id = int.Parse(diskData["id"].ToString()),
                            CreatedAt = DateTime.Parse(diskData["created_at"].ToString()),
                            UpdatedAt = DateTime.Parse(diskData["updated_at"].ToString()),
                            Country = GetCountries(int.Parse(diskData["id"].ToString())),
                            Genre = GetGenres(int.Parse(diskData["id"].ToString()))
                        };

                        disks.Add(diskInfo);
                    }

                    connect.CloseConnection(); // Закрываем соединение с БД

                    return disks;
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return null; // Возвращаем результат
            }

            return null;
        }

        /*
         * Получить список пользователей по идентификатору роли 
         */
        public static ArrayList DisksSearch(string searchText)
        {
            var disks = new ArrayList();

            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `disks` WHERE (`title` LIKE @searchText OR `about` LIKE @searchText) AND `deleted_at` IS NULL";
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                if (diskData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (diskData.Read())
                    {
                        Disk diskInfo = new Disk(
                            diskData["title"].ToString(),
                            diskData["about"].ToString(),
                            DateTime.Parse(diskData["year"].ToString()),
                            diskData["actors"].ToString(),
                            diskData["directed_by"].ToString(),
                            float.Parse(diskData["cost"].ToString()),
                            int.Parse(diskData["count"].ToString())
                        )
                        {
                            Id = int.Parse(diskData["id"].ToString()),
                            CreatedAt = DateTime.Parse(diskData["created_at"].ToString()),
                            UpdatedAt = DateTime.Parse(diskData["updated_at"].ToString()),
                            Country = GetCountries(int.Parse(diskData["id"].ToString())),
                            Genre = GetGenres(int.Parse(diskData["id"].ToString()))
                        };

                        disks.Add(diskInfo);
                    }

                    connect.CloseConnection(); // Закрываем соединение с БД

                    return disks;
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
        public static bool DeleteDisk(int id = 0)
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "UPDATE `disks` SET `deleted_at` = CURRENT_TIMESTAMP WHERE `id` = @diskId";
                cmd.Parameters.AddWithValue("@diskId", id);
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

        public bool UpdateDisk()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "UPDATE `disks` SET `title` = @title, `about` = @about, " +
                                  "`year` = @year, `actors` = @actors, " +
                                  "`directed_by` = @directed_by, `cost` = @cost, " +
                                  "`count` = @count WHERE `id` = @diskId";
                cmd.Parameters.AddWithValue("@diskId", Id);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@about", About);
                cmd.Parameters.AddWithValue("@year", Year);
                cmd.Parameters.AddWithValue("@actors", Actors);
                cmd.Parameters.AddWithValue("@directed_by", DirectedBy);
                cmd.Parameters.AddWithValue("@cost", Cost);
                cmd.Parameters.AddWithValue("@count", Count);
                cmd.Prepare();

                MySqlDataReader userData = cmd.ExecuteReader(); // Выполним запрос

                if (userData.RecordsAffected != 0) // Если запрос возвратил какой-либо результат, то
                {
                    connect.CloseConnection(); // Закрываем соединение с БД
                }
                
                connect.CloseConnection(); // Закрываем соединение с БД

                AddGenres();
                AddCountries();

                return true; // Возвращаем результат
            }

            return false;
        }

        public bool AddGenres()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `disks_genres` WHERE `disk_id` = @diskId", connect.Connection);    
                cmd.Parameters.AddWithValue("@diskId", Id);
                cmd.Prepare();

                cmd.ExecuteNonQuery(); // Выполним запрос

                foreach (var genreId in Genre.Split(',').Distinct())
                {
                    if (int.Parse(genreId) != -1)
                    {
                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `disks_genres` VALUES (@diskId, @genreId)", connect.Connection);
                        cmd1.Parameters.AddWithValue("@diskId", Id);
                        cmd1.Parameters.AddWithValue("@genreId", int.Parse(genreId) + 1);
                        cmd1.Prepare();

                        cmd1.ExecuteNonQuery(); // Выполним запрос
                    }
                }

                connect.CloseConnection();

                return true;
            }

            return false;
        }

        public bool AddCountries()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `disks_countries` WHERE `id_disk` = @diskId", connect.Connection);
                cmd.Parameters.AddWithValue("@diskId", Id);
                cmd.Prepare();

                cmd.ExecuteNonQuery(); // Выполним запрос

                foreach (var countryId in Country.Split(',').Distinct())
                {
                    if (int.Parse(countryId) != -1)
                    {
                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `disks_countries` VALUES (@diskId, @countryId)", connect.Connection);
                        cmd1.Parameters.AddWithValue("@diskId", Id);
                        cmd1.Parameters.AddWithValue("@countryId", int.Parse(countryId) + 1);
                        cmd1.Prepare();

                        cmd1.ExecuteNonQuery(); // Выполним запрос
                    }
                }

                connect.CloseConnection();

                return true;
            }

            return false;
        }

        public bool CreateDisk()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                // Формируем команду для выбора 1-го пользователя по ID
                // Будем использовать подготовленные запросы для защиты БД
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "INSERT INTO `disks` VALUES (NULL, @title, @about, " +
                                  "@year, @actors, " +
                                  "@directed_by, CURRENT_TIMESTAMP, NULL, NULL, @cost, " +
                                  "@count)";
                cmd.Parameters.AddWithValue("@diskId", Id);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@about", About);
                cmd.Parameters.AddWithValue("@year", Year);
                cmd.Parameters.AddWithValue("@actors", Actors);
                cmd.Parameters.AddWithValue("@directed_by", DirectedBy);
                cmd.Parameters.AddWithValue("@cost", Cost);
                cmd.Parameters.AddWithValue("@count", Count);
                cmd.Prepare();

                MySqlDataReader diskData = cmd.ExecuteReader(); // Выполним запрос

                if (diskData.RecordsAffected != 0) // Если запрос возвратил какой-либо результат, то
                {
                    Id = cmd.LastInsertedId;

                    connect.CloseConnection(); // Закрываем соединение с БД
                }

                connect.CloseConnection(); // Закрываем соединение с БД

                AddGenres();
                AddCountries();

                return true; // Возвращаем результат
            }

            return false;
        }
    }
}
