using System.Collections;
using System.Windows.Forms;

namespace DVDS
{
    /*
     * Интерфейс представления для основной формы
     */
    interface IMainView
    {
        void ShowUsersList(ArrayList users, DataGridView table);
        void ShowAlert(string alert);

        int GetSelectesUsersTab();
        DataGridView GetSelectedGridView(int tabId);

        Session GetSession();

        void ShowDisksList(ArrayList disks, DataGridView table);
        DataGridView GetDisksGridView();

        Session GetUserSession();
    }
}
