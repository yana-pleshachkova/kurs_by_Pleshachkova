using System.Collections;
using MySql.Data.MySqlClient;

namespace DVDS
{
    class Countries
    {
        public static ArrayList GetCountries()
        {
            DbConnect connect = new DbConnect(); // Создаем экземпляр коннектора к БД

            ArrayList countriesList = new ArrayList();

            if (connect.OpenConnection()) // Открываем соединение и если оно открыто, то
            {
                MySqlCommand cmd = connect.Connection.CreateCommand();
                cmd.CommandText = "SELECT `id`, `name` FROM `countries`";
                cmd.Prepare();

                MySqlDataReader countryData = cmd.ExecuteReader(); // Выполним запрос

                if (countryData.HasRows) // Если запрос возвратил какой-либо результат, то
                {
                    while (countryData.Read()) // Считываем данные - здесь приходит только 1 строка
                    {
                        countriesList.Add(countryData["id"] + " " + countryData["name"]);
                    }
                }

                // если данных небыло
                connect.CloseConnection(); // Закрываем соединение с БД

                return countriesList; // Возвращаем результат
            }

            return null;
        }
    }
}
