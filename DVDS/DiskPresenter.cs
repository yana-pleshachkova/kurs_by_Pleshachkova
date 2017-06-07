using System;
using System.Collections;
using System.Windows.Forms;

namespace DVDS
{
    class DiskPresenter
    {
        private IDiskFormView _view;
        private Disk _disk;

        public DiskPresenter(IDiskFormView view)
        {
            _view = view;
        }

        /*
         * Установить значения для полей формы для диска
         */
        public void SetDiskFields(int userId)
        {
            _disk = Disk.GetDisk(userId);

            if (Equals(_disk, null))
            {
                _view.ShowAlert("Не удалось найти диск, попробуйте еще раз.");
            }

            _view.SetDiskFields(_disk);
        }

        /*
         * Установить список жанров в указанный комбо бокс
         */
        public void SetGenres(ComboBox cmb)
        {
            ArrayList genres = Genres.GetGenres();

            foreach (var genre in genres)
            {
                cmb.Items.Add(genre);
            }
        }

        /*
         * Установить список стран в указанный комбобокс
         */
        public void SetCountries(ComboBox cmb)
        {
            ArrayList countries = Countries.GetCountries();

            foreach (var country in countries)
            {
                cmb.Items.Add(country);
            }
        }

        /*
         * Обновить или создать информацию о диске
         */
        public bool UpdateDisk(
            string diskCardCost,
            string diskCardCount,
            string diskCardAbout,
            string diskCardTitle,
            string diskCardDIrectedBy,
            string diskCardActors,
            DateTime diskCardYear,
            ArrayList countries,
            ArrayList genres
            )
        {
            bool isNull = false;
            if (Equals(_disk, null))
            {
                isNull = true;
                _disk = new Disk();
            }

            try { 
                _disk.Cost = float.Parse(diskCardCost.Replace(".", ","));
                _disk.Count = int.Parse(diskCardCount);
                _disk.About = diskCardAbout;
                _disk.Title = diskCardTitle;
                _disk.DirectedBy = diskCardDIrectedBy;
                _disk.Actors = diskCardActors;
                _disk.Year = diskCardYear;
                _disk.Country = string.Join(",", countries.ToArray());
                _disk.Genre = string.Join(",", genres.ToArray());

                if (!isNull)
                {
                    return _disk.UpdateDisk();
                }

                return _disk.CreateDisk();
            }
            catch (Exception)
            {
                _view.ShowAlert("Ошибка при сохранении данных диска. Попробуйте еще раз, пожалуйста.");

                return false;
            }
        }
    }
}
