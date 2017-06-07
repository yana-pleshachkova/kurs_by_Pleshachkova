using System;
using System.Windows.Forms;

namespace DVDS
{
    public partial class UserForm : Form, IUserFormView
    {
        private readonly UserFormPresenter _presenter;
        private readonly Session _userSession;

        public UserForm()
        {
            InitializeComponent();
            _presenter = new UserFormPresenter(this);
        }

        public UserForm(Session userSession)
        {
            InitializeComponent();
            _presenter = new UserFormPresenter(this);
            _userSession = userSession;
        }

        public UserForm(int id, Session userSession)
        {
            InitializeComponent();
            _presenter = new UserFormPresenter(this);
            _userSession = userSession;

            _presenter.SetUserFields(id);
        }

        private void SaveUserInfo(object sender, EventArgs e)
        {
            bool isUpdate = _presenter.UpdateUser(
                userCardRole.SelectedIndex + 1,
                userCardLogin.Text,
                userCardPassword.Text,
                userCardEmail.Text,
                userCardFirstName.Text,
                userCardLastName.Text,
                userCardPatronumyc.Text,
                userCardPhones.Text,
                userCardBirthDate.Value,
                userCardPassportNumber.Text,
                userCardPassportYear.Value,
                userCardPassportIssuer.Text
                );

            if (isUpdate)
            {
                Close();
            }
            else
            {
                ShowAlert("Не удалось обновить информацию о пользователе.");
            }
        }

        public void SetUserFields(User user)
        {
            if (Equals(user, null))
            {
                Close();

                return;
            }

            userCardId.Text = user.Id.ToString();
            userCardRole.SelectedIndex = user.Role - 1;
            userCardLogin.Text = user.Login;
            userCardEmail.Text = user.Email;
            userCardFirstName.Text = user.FirstName;
            userCardLastName.Text = user.LastName;
            userCardPatronumyc.Text = user.Patrnumyc;
            userCardPhones.Text = user.Phones;
            userCardBirthDate.Value = user.BirthDate;
            userCardPassportNumber.Text = user.PassportNumber.ToString();
            userCardPassportYear.Value = user.PassportYear;
            userCardPassportIssuer.Text = user.PassportIssuer;
            userCardCreatedAt.Value = user.CreatedAt;
            userCardUpdatedAt.Value = user.UpdatedAt;
        }

        /*
         * Показываем предупрежедение с сообщением
         */
        public void ShowAlert(string alert)
        {
            MessageBox.Show(alert);
        }

        public Session GetUserSession()
        {
            return _userSession;
        }
    }
}
