namespace DVDS
{
    /*
     * Интерфейс представления для формы авторизации
     */
    interface ILoginView
    {
        string[] GetLoginData();
        void ShowAlert(string alert);
        void ShowMainWindow(int userId);
    }
}
