using System;
using System.Collections;
using System.Windows.Forms;

namespace DVDS
{
    /*
     * Представление формы авторизации
     */
    public partial class Main : Form, IMainView
    {
        private readonly MainPresenter _presenter;
        public Session SessionUser { get; protected set; } = null;
        public User _user { get; protected set; } = null;

        public Main(int userId)
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);

            InitForm(userId);
        }

        public void InitForm(int userId)
        {
            _user = User.GetUser(userId);
            SessionUser = _user.CreateSession();

            _presenter.LoadDisks(disksDataGrid);

            if (!Equals(SessionUser, null))
            {
                if (SessionUser.Role != 1)
                {
                    userButtonDelete.Hide();
                }

                if (SessionUser.Role == 1)
                {
                    _presenter.LoadUsersByRole(1, userAdminGrid);
                }

                if (SessionUser.Role == 2)
                {
                    userTabs.TabPages.Remove(userAdminTabPage);
                    userTabs.TabPages.Remove(userManagerTabPage);

                    _presenter.LoadUsersByRole(3, userClientGrid);
                }

                if (SessionUser.Role == 3)
                {
                    mainTabControl.TabPages.Remove(usersTabPage);

                    userButtonAdd.Hide();
                    userButtonEdit.Hide();

                    diskButtonAdd.Hide();
                    diskButtonDelete.Hide();
                    diskButtonEdit.Hide();
                } 
            }
        }

        /*
         * При выборе вкладки пользователей, загружаем и отображаем нужный по типу
         */
        private void SelectingTab(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                _presenter.LoadUsersByRole(1, userAdminGrid);
            }

            if (e.TabPageIndex == 1)
            {
                _presenter.LoadUsersByRole(2, userManagerGrid);
            }

            if (e.TabPageIndex == 2)
            {
                _presenter.LoadUsersByRole(3, userClientGrid);
            }
        }

        /*
         * Открыть форму для добавления нового пользователя
         */
        private void AddUser(object sender, EventArgs e)
        {
            _presenter.AddUser();
        }

        /*
         * Открыть форму для редактирования данных пользователя 
         */
        private void EditUser(object sender, EventArgs e)
        {
            _presenter.EditUser();
        }

        /*
         * Удалить пользователя
         */
        private void DeleteUser(object sender, EventArgs e)
        {
            _presenter.DeleteUser();
        }

        /*
         * Поиск пользователей
         */
        private void SearchUsers(object sender, EventArgs e)
        {
            _presenter.SearchUsers(userSearch);
        }

        /*
         * Поиск дисков
         */
        private void SearchDisks(object sender, EventArgs e)
        {
            _presenter.SearchDisks(disksSearch, disksDataGrid);
        }

        /*
         * Удаление диска
         */
        private void DeleteDisk(object sender, EventArgs e)
        {
            _presenter.DeleteDisk(disksDataGrid);
        }

        /*
         * Открыть форму для добавления нового диска
         */
        private void AddNewDisk(object sender, EventArgs e)
        {
            _presenter.AddDisk();
        }

        /*
         * Открыть форму для редактирования диска
         */
        private void EditDisk(object sender, EventArgs e)
        {
            _presenter.EditDisk();
        }

        // Intarface implemants ==================

        /*
         * Отображаем список пользователей во View
         */
        public void ShowUsersList(ArrayList users, DataGridView table)
        {
            table.Rows.Clear();

            foreach (User user in users)
            {
                object[] row = {
                            user.Id,
                            user.LastName,
                            user.FirstName,
                            user.Patrnumyc,
                            user.Phones,
                            user.Login,
                            User.GetUserStringRole(user.Role),
                            user.BirthDate,
                            user.PassportNumber,
                            user.PassportYear,
                            user.PassportIssuer
                        };

                table.Rows.Add(row);
            }
        }

        /*
         * Показываем предупрежедение с сообщением
         */
        public void ShowAlert(string alert)
        {
            MessageBox.Show(alert);
        }

        /*
         * Получить индекс активной вкладки пользователей
         */
        public int GetSelectesUsersTab()
        {
            return userTabs.SelectedIndex + 1;
        }

        /*
         * Получить таблицу представления с дисками
         */
        public DataGridView GetDisksGridView()
        {
            return disksDataGrid;
        }

        /*
         * Получить DataGridView для активной вкладки пользователя
         */
        public DataGridView GetSelectedGridView(int tabId)
        {
            if (tabId == 1)
            {
                return userAdminGrid;
            }

            if (tabId == 2)
            {
                return userManagerGrid;
            }

            if (tabId == 3)
            {
                return userClientGrid;
            }

            return null;
        }

        /*
         * Получить сессию пользователя
         */
        public Session GetSession()
        {
            return SessionUser;
        }

        /*
         * Отображение списка дисков
         */
        public void ShowDisksList(ArrayList disks, DataGridView table)
        {
            table.Rows.Clear();

            foreach (Disk disk in disks)
            {
                object[] row = {
                            disk.Id,
                            disk.Title,
                            disk.Country,
                            disk.Year,
                            disk.Cost,
                            disk.About
                        };

                table.Rows.Add(row);
            }
        }

        public Session GetUserSession()
        {
            return SessionUser;
        }
    }
}
