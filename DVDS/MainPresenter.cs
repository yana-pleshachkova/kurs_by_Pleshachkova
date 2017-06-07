using System.Collections;
using System.Windows.Forms;

namespace DVDS
{
    /*
     * Презентер для основной формы
     */
    class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
        }

        /*
         * Загрузить список пользователей по роли
         */
        public void LoadUsersByRole(int role, DataGridView table)
        {
            ArrayList users = null;

            if (_view.GetUserSession().Role == 1 || _view.GetUserSession().Role == 2)
            {
                users = Manager.GetUsersByRole(role);
            }

            if (!Equals(users, null))
            {
                _view.ShowUsersList(users, table);

                return;
            }

            _view.ShowUsersList(new ArrayList(), table);

            _view.ShowAlert("Пользоватлей с ролью '" + User.GetUserStringRole(role) + "' не найдено.");
        }

        /*
         * Загрузить список дисков
         */
        public void LoadDisks(DataGridView table)
        {
            ArrayList disks = Disk.GetDisks();
            if (!Equals(disks, null))
            {
                _view.ShowDisksList(disks, table);
                
                return;
            }

            _view.ShowDisksList(new ArrayList(), table);

            _view.ShowAlert("Список дисков пуст.");
        }

        /*
         * Поиск дисков
         */
        public void SearchDisks(TextBox searchTextBox, DataGridView listDisks)
        {
            string searchText = searchTextBox.Text;

            if (Equals(searchText, ""))
            {
                LoadDisks(listDisks);

                return;
            }

            ArrayList disks = Disk.DisksSearch(searchText);

            if (!Equals(disks, null))
            {
                _view.ShowDisksList(disks, listDisks);

                return;
            }

            _view.ShowUsersList(new ArrayList(), listDisks);
        }

        /*
         * Удалить диск
         */
        public void DeleteDisk(DataGridView disksGrid)
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            if (disksGrid.CurrentRow != null)
            {
                int rowIndex = disksGrid.CurrentRow.Index; // получаем идентификтор выделенной строки
                int diskId = int.Parse(disksGrid.Rows[rowIndex].Cells[0].Value.ToString());

                Disk.DeleteDisk(diskId);
                LoadDisks(disksGrid);

                return;
            }

            LoadDisks(disksGrid);

            _view.ShowAlert("Вы не выбрали диск из списка. Попробуйте еще раз, пожалуйста.");
        }

        /*
         * Открыть форму добавления нового диска
         */
        public void AddDisk()
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            DiskForm userCard = new DiskForm();
            userCard.FormClosed += DiskCardClose;
            userCard.ShowDialog();
        }

        /*
         * Открыть форму для редактирования данных диска
         */
        public void EditDisk()
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            DataGridView selectedGridView = _view.GetDisksGridView();

            if (!Equals(selectedGridView, null))
            {
                if (!Equals(selectedGridView.CurrentRow, null))
                {
                    int rowIndex = selectedGridView.CurrentRow.Index; // получаем идентификтор выделенной строки
                    int diskId = int.Parse(selectedGridView.Rows[rowIndex].Cells[0].Value.ToString());

                    DiskForm diskCard = new DiskForm(diskId);
                    diskCard.FormClosed += DiskCardClose;
                    diskCard.ShowDialog();

                    return;
                }
            }

            _view.ShowAlert("Вы не выбрали диск из списка. Попробуйте еще раз, пожалуйста.");
        }

        /*
         * Открыть форму добавления нового пользователя
         */
        public void AddUser()
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            UserForm userCard = new UserForm(_view.GetUserSession());
            userCard.FormClosed += UserCardClose;
            userCard.ShowDialog();
        }

        /*
         * Открыть форму для редактирования данных пользователя
         */
        public void EditUser()
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            int selectedTab = _view.GetSelectesUsersTab();
            DataGridView selectedGridView = _view.GetSelectedGridView(selectedTab);

            if (!Equals(selectedGridView, null))
            {
                if (!Equals(selectedGridView.CurrentRow, null))
                {
                    int rowIndex = selectedGridView.CurrentRow.Index; // получаем идентификтор выделенной строки
                    int userId = int.Parse(selectedGridView.Rows[rowIndex].Cells[0].Value.ToString());

                    UserForm userCard = new UserForm(userId, _view.GetUserSession());
                    userCard.FormClosed += UserCardClose;
                    userCard.ShowDialog();

                    return;
                }
            }

            _view.ShowAlert("Вы не выбрали пользователя из списка. Попробуйте еще раз, пожалуйста.");
        }

        public void DeleteUser()
        {
            Session session = _view.GetSession();

            if (Equals(session, null))
            {
                _view.ShowAlert("Пожалуйста авторизуйтесь.");

                return;
            }

            if (Equals(session.Role, 2) || Equals(session.Role, 3))
            {
                _view.ShowAlert("У вас недостаточно прав для совершения этого действия.");

                return;
            }

            int selectedTab = _view.GetSelectesUsersTab();
            DataGridView selectedGridView = _view.GetSelectedGridView(selectedTab);

            if (!Equals(selectedGridView, null))
            {
                if (!Equals(selectedGridView.CurrentRow, null))
                {
                    int rowIndex = selectedGridView.CurrentRow.Index; // получаем идентификтор выделенной строки
                    int userId = int.Parse(selectedGridView.Rows[rowIndex].Cells[0].Value.ToString());

                    Admin.DeleteUser(userId);
                    LoadUsersByRole(selectedTab, selectedGridView);

                    return;
                }
            }

            LoadUsersByRole(selectedTab, selectedGridView);

            _view.ShowAlert("Вы не выбрали пользователя из списка. Попробуйте еще раз, пожалуйста.");
        }

        public void SearchUsers(TextBox searchTextBox)
        {
            string searchText = searchTextBox.Text;
            int selectedTab = _view.GetSelectesUsersTab();
            DataGridView selectedGridView = _view.GetSelectedGridView(selectedTab);

            if (Equals(searchText, ""))
            {
                LoadUsersByRole(selectedTab, selectedGridView);

                return;
            }

            if (!Equals(selectedGridView, null))
            {
                ArrayList users = null;

                if (_view.GetUserSession().Role == 1 || _view.GetUserSession().Role == 2)
                {
                    users = Manager.UsersSearch(searchText, selectedTab);
                }

                if (!Equals(users, null))
                {
                    _view.ShowUsersList(users, selectedGridView);

                    return;
                }

                _view.ShowUsersList(new ArrayList(), selectedGridView);
            }
        }

        /*
         * Закрываем форму - Карточка пользователя
         */
        private void UserCardClose(object sender, FormClosedEventArgs e)
        {
            int selectedTab = _view.GetSelectesUsersTab();
            DataGridView selectedGridView = _view.GetSelectedGridView(selectedTab);

            if (!Equals(selectedGridView, null))
            {
                LoadUsersByRole(selectedTab, selectedGridView);
            }
        }

        /*
         * Закрываем форму - Карточка диска
         */
        private void DiskCardClose(object sender, FormClosedEventArgs e)
        {
            LoadDisks(_view.GetDisksGridView());
        }
    }
}
