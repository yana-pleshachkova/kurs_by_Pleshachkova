using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace DVDS
{
    class Genres
    {
        public static ArrayList GetGenres()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            ArrayList genresList = new ArrayList();

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `genres`";
                cmd.Prepare();

                MySqlDataReader genreData = cmd.ExecuteReader(); // Выполним запрос

                if (genreData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (genreData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        genresList.Add(genreData["id"] + " " + genreData["title"]);
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return genresList; // Возвращаем результат
            }

            return null;
        }
    }
}
