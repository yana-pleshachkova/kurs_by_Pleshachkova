namespace DVDS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.userSearch = new System.Windows.Forms.TextBox();
            this.userButtonDelete = new System.Windows.Forms.Button();
            this.userButtonEdit = new System.Windows.Forms.Button();
            this.userButtonAdd = new System.Windows.Forms.Button();
            this.userTabs = new System.Windows.Forms.TabControl();
            this.userAdminTabPage = new System.Windows.Forms.TabPage();
            this.userAdminGrid = new System.Windows.Forms.DataGridView();
            this.AuserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserPatronumyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserPhones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserPassportYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserPassportIssuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userManagerTabPage = new System.Windows.Forms.TabPage();
            this.userManagerGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCustomerTabPage = new System.Windows.Forms.TabPage();
            this.userClientGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disksTabPage = new System.Windows.Forms.TabPage();
            this.diskButtonDelete = new System.Windows.Forms.Button();
            this.diskButtonEdit = new System.Windows.Forms.Button();
            this.diskButtonAdd = new System.Windows.Forms.Button();
            this.disksDataGrid = new System.Windows.Forms.DataGridView();
            this.diskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskAbout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.disksSearch = new System.Windows.Forms.TextBox();
            this.mainTabControl.SuspendLayout();
            this.usersTabPage.SuspendLayout();
            this.userTabs.SuspendLayout();
            this.userAdminTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAdminGrid)).BeginInit();
            this.userManagerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerGrid)).BeginInit();
            this.userCustomerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userClientGrid)).BeginInit();
            this.disksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.usersTabPage);
            this.mainTabControl.Controls.Add(this.disksTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(-6, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1121, 566);
            this.mainTabControl.TabIndex = 0;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.label1);
            this.usersTabPage.Controls.Add(this.userSearch);
            this.usersTabPage.Controls.Add(this.userButtonDelete);
            this.usersTabPage.Controls.Add(this.userButtonEdit);
            this.usersTabPage.Controls.Add(this.userButtonAdd);
            this.usersTabPage.Controls.Add(this.userTabs);
            this.usersTabPage.Location = new System.Drawing.Point(4, 25);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(1113, 537);
            this.usersTabPage.TabIndex = 0;
            this.usersTabPage.Text = "Пользователи";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск";
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(64, 7);
            this.userSearch.MaximumSize = new System.Drawing.Size(1550, 33);
            this.userSearch.MinimumSize = new System.Drawing.Size(957, 33);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(1041, 22);
            this.userSearch.TabIndex = 4;
            this.userSearch.TextChanged += new System.EventHandler(this.SearchUsers);
            // 
            // userButtonDelete
            // 
            this.userButtonDelete.BackColor = System.Drawing.Color.MistyRose;
            this.userButtonDelete.Location = new System.Drawing.Point(975, 149);
            this.userButtonDelete.Name = "userButtonDelete";
            this.userButtonDelete.Size = new System.Drawing.Size(132, 33);
            this.userButtonDelete.TabIndex = 3;
            this.userButtonDelete.Text = "Удалить";
            this.userButtonDelete.UseVisualStyleBackColor = false;
            this.userButtonDelete.Click += new System.EventHandler(this.DeleteUser);
            // 
            // userButtonEdit
            // 
            this.userButtonEdit.Location = new System.Drawing.Point(975, 110);
            this.userButtonEdit.Name = "userButtonEdit";
            this.userButtonEdit.Size = new System.Drawing.Size(132, 33);
            this.userButtonEdit.TabIndex = 2;
            this.userButtonEdit.Text = "Редактировать";
            this.userButtonEdit.UseVisualStyleBackColor = true;
            this.userButtonEdit.Click += new System.EventHandler(this.EditUser);
            // 
            // userButtonAdd
            // 
            this.userButtonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.userButtonAdd.Location = new System.Drawing.Point(975, 71);
            this.userButtonAdd.Name = "userButtonAdd";
            this.userButtonAdd.Size = new System.Drawing.Size(132, 33);
            this.userButtonAdd.TabIndex = 1;
            this.userButtonAdd.Text = "Добавить";
            this.userButtonAdd.UseVisualStyleBackColor = false;
            this.userButtonAdd.Click += new System.EventHandler(this.AddUser);
            // 
            // userTabs
            // 
            this.userTabs.Controls.Add(this.userAdminTabPage);
            this.userTabs.Controls.Add(this.userManagerTabPage);
            this.userTabs.Controls.Add(this.userCustomerTabPage);
            this.userTabs.Location = new System.Drawing.Point(6, 47);
            this.userTabs.Name = "userTabs";
            this.userTabs.SelectedIndex = 0;
            this.userTabs.Size = new System.Drawing.Size(961, 487);
            this.userTabs.TabIndex = 0;
            this.userTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SelectingTab);
            // 
            // userAdminTabPage
            // 
            this.userAdminTabPage.Controls.Add(this.userAdminGrid);
            this.userAdminTabPage.Location = new System.Drawing.Point(4, 25);
            this.userAdminTabPage.Name = "userAdminTabPage";
            this.userAdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userAdminTabPage.Size = new System.Drawing.Size(953, 458);
            this.userAdminTabPage.TabIndex = 0;
            this.userAdminTabPage.Text = "Администраторы";
            this.userAdminTabPage.UseVisualStyleBackColor = true;
            // 
            // userAdminGrid
            // 
            this.userAdminGrid.AllowUserToAddRows = false;
            this.userAdminGrid.AllowUserToDeleteRows = false;
            this.userAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAdminGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuserId,
            this.AuserLastName,
            this.AuserFirstName,
            this.AuserPatronumyc,
            this.AuserPhones,
            this.AuserLogin,
            this.AuserRole,
            this.AuserBirthDate,
            this.AuserPassportNumber,
            this.AuserPassportYear,
            this.AuserPassportIssuer});
            this.userAdminGrid.Location = new System.Drawing.Point(6, 6);
            this.userAdminGrid.Name = "userAdminGrid";
            this.userAdminGrid.ReadOnly = true;
            this.userAdminGrid.RowTemplate.Height = 24;
            this.userAdminGrid.Size = new System.Drawing.Size(941, 486);
            this.userAdminGrid.TabIndex = 0;
            // 
            // AuserId
            // 
            this.AuserId.Frozen = true;
            this.AuserId.HeaderText = "Id";
            this.AuserId.Name = "AuserId";
            this.AuserId.ReadOnly = true;
            // 
            // AuserLastName
            // 
            this.AuserLastName.Frozen = true;
            this.AuserLastName.HeaderText = "Фамилия";
            this.AuserLastName.Name = "AuserLastName";
            this.AuserLastName.ReadOnly = true;
            // 
            // AuserFirstName
            // 
            this.AuserFirstName.Frozen = true;
            this.AuserFirstName.HeaderText = "Имя";
            this.AuserFirstName.Name = "AuserFirstName";
            this.AuserFirstName.ReadOnly = true;
            // 
            // AuserPatronumyc
            // 
            this.AuserPatronumyc.Frozen = true;
            this.AuserPatronumyc.HeaderText = "Отчество";
            this.AuserPatronumyc.Name = "AuserPatronumyc";
            this.AuserPatronumyc.ReadOnly = true;
            // 
            // AuserPhones
            // 
            this.AuserPhones.Frozen = true;
            this.AuserPhones.HeaderText = "Телефоны";
            this.AuserPhones.Name = "AuserPhones";
            this.AuserPhones.ReadOnly = true;
            // 
            // AuserLogin
            // 
            this.AuserLogin.Frozen = true;
            this.AuserLogin.HeaderText = "Логин";
            this.AuserLogin.Name = "AuserLogin";
            this.AuserLogin.ReadOnly = true;
            // 
            // AuserRole
            // 
            this.AuserRole.Frozen = true;
            this.AuserRole.HeaderText = "Роль";
            this.AuserRole.Name = "AuserRole";
            this.AuserRole.ReadOnly = true;
            // 
            // AuserBirthDate
            // 
            this.AuserBirthDate.Frozen = true;
            this.AuserBirthDate.HeaderText = "Дата рождения";
            this.AuserBirthDate.Name = "AuserBirthDate";
            this.AuserBirthDate.ReadOnly = true;
            // 
            // AuserPassportNumber
            // 
            this.AuserPassportNumber.Frozen = true;
            this.AuserPassportNumber.HeaderText = "Номер паспорта";
            this.AuserPassportNumber.Name = "AuserPassportNumber";
            this.AuserPassportNumber.ReadOnly = true;
            // 
            // AuserPassportYear
            // 
            this.AuserPassportYear.Frozen = true;
            this.AuserPassportYear.HeaderText = "Год выдачи паспорта";
            this.AuserPassportYear.Name = "AuserPassportYear";
            this.AuserPassportYear.ReadOnly = true;
            // 
            // AuserPassportIssuer
            // 
            this.AuserPassportIssuer.Frozen = true;
            this.AuserPassportIssuer.HeaderText = "Кем выдан паспорт";
            this.AuserPassportIssuer.Name = "AuserPassportIssuer";
            this.AuserPassportIssuer.ReadOnly = true;
            // 
            // userManagerTabPage
            // 
            this.userManagerTabPage.Controls.Add(this.userManagerGrid);
            this.userManagerTabPage.Location = new System.Drawing.Point(4, 25);
            this.userManagerTabPage.Name = "userManagerTabPage";
            this.userManagerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userManagerTabPage.Size = new System.Drawing.Size(953, 458);
            this.userManagerTabPage.TabIndex = 1;
            this.userManagerTabPage.Text = "Менеджеры";
            this.userManagerTabPage.UseVisualStyleBackColor = true;
            // 
            // userManagerGrid
            // 
            this.userManagerGrid.AllowUserToAddRows = false;
            this.userManagerGrid.AllowUserToDeleteRows = false;
            this.userManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userManagerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.userManagerGrid.Location = new System.Drawing.Point(6, 6);
            this.userManagerGrid.Name = "userManagerGrid";
            this.userManagerGrid.ReadOnly = true;
            this.userManagerGrid.RowTemplate.Height = 24;
            this.userManagerGrid.Size = new System.Drawing.Size(941, 486);
            this.userManagerGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефоны";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Год выдачи паспорта";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Кем выдан паспорт";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // userCustomerTabPage
            // 
            this.userCustomerTabPage.Controls.Add(this.userClientGrid);
            this.userCustomerTabPage.Location = new System.Drawing.Point(4, 25);
            this.userCustomerTabPage.Name = "userCustomerTabPage";
            this.userCustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userCustomerTabPage.Size = new System.Drawing.Size(953, 458);
            this.userCustomerTabPage.TabIndex = 2;
            this.userCustomerTabPage.Text = "Клиенты";
            this.userCustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // userClientGrid
            // 
            this.userClientGrid.AllowUserToAddRows = false;
            this.userClientGrid.AllowUserToDeleteRows = false;
            this.userClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userClientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.userClientGrid.Location = new System.Drawing.Point(6, 6);
            this.userClientGrid.Name = "userClientGrid";
            this.userClientGrid.ReadOnly = true;
            this.userClientGrid.RowTemplate.Height = 24;
            this.userClientGrid.Size = new System.Drawing.Size(941, 486);
            this.userClientGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.Frozen = true;
            this.dataGridViewTextBoxColumn13.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.Frozen = true;
            this.dataGridViewTextBoxColumn14.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.Frozen = true;
            this.dataGridViewTextBoxColumn15.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "Телефоны";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.Frozen = true;
            this.dataGridViewTextBoxColumn17.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.Frozen = true;
            this.dataGridViewTextBoxColumn18.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.Frozen = true;
            this.dataGridViewTextBoxColumn19.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.Frozen = true;
            this.dataGridViewTextBoxColumn20.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.Frozen = true;
            this.dataGridViewTextBoxColumn21.HeaderText = "Год выдачи паспорта";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.Frozen = true;
            this.dataGridViewTextBoxColumn22.HeaderText = "Кем выдан паспорт";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // disksTabPage
            // 
            this.disksTabPage.Controls.Add(this.diskButtonDelete);
            this.disksTabPage.Controls.Add(this.diskButtonEdit);
            this.disksTabPage.Controls.Add(this.diskButtonAdd);
            this.disksTabPage.Controls.Add(this.disksDataGrid);
            this.disksTabPage.Controls.Add(this.label2);
            this.disksTabPage.Controls.Add(this.disksSearch);
            this.disksTabPage.Location = new System.Drawing.Point(4, 25);
            this.disksTabPage.Name = "disksTabPage";
            this.disksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.disksTabPage.Size = new System.Drawing.Size(1113, 537);
            this.disksTabPage.TabIndex = 1;
            this.disksTabPage.Text = "Каталог дисков";
            this.disksTabPage.UseVisualStyleBackColor = true;
            // 
            // diskButtonDelete
            // 
            this.diskButtonDelete.BackColor = System.Drawing.Color.MistyRose;
            this.diskButtonDelete.Location = new System.Drawing.Point(973, 123);
            this.diskButtonDelete.Name = "diskButtonDelete";
            this.diskButtonDelete.Size = new System.Drawing.Size(132, 33);
            this.diskButtonDelete.TabIndex = 11;
            this.diskButtonDelete.Text = "Удалить";
            this.diskButtonDelete.UseVisualStyleBackColor = false;
            this.diskButtonDelete.Click += new System.EventHandler(this.DeleteDisk);
            // 
            // diskButtonEdit
            // 
            this.diskButtonEdit.Location = new System.Drawing.Point(973, 84);
            this.diskButtonEdit.Name = "diskButtonEdit";
            this.diskButtonEdit.Size = new System.Drawing.Size(132, 33);
            this.diskButtonEdit.TabIndex = 10;
            this.diskButtonEdit.Text = "Редактировать";
            this.diskButtonEdit.UseVisualStyleBackColor = true;
            this.diskButtonEdit.Click += new System.EventHandler(this.EditDisk);
            // 
            // diskButtonAdd
            // 
            this.diskButtonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.diskButtonAdd.Location = new System.Drawing.Point(973, 45);
            this.diskButtonAdd.Name = "diskButtonAdd";
            this.diskButtonAdd.Size = new System.Drawing.Size(132, 33);
            this.diskButtonAdd.TabIndex = 9;
            this.diskButtonAdd.Text = "Добавить";
            this.diskButtonAdd.UseVisualStyleBackColor = false;
            this.diskButtonAdd.Click += new System.EventHandler(this.AddNewDisk);
            // 
            // disksDataGrid
            // 
            this.disksDataGrid.AllowUserToAddRows = false;
            this.disksDataGrid.AllowUserToDeleteRows = false;
            this.disksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diskId,
            this.diskTitle,
            this.diskCountry,
            this.diskYear,
            this.diskCost,
            this.diskAbout});
            this.disksDataGrid.Location = new System.Drawing.Point(13, 45);
            this.disksDataGrid.Name = "disksDataGrid";
            this.disksDataGrid.ReadOnly = true;
            this.disksDataGrid.RowTemplate.Height = 24;
            this.disksDataGrid.Size = new System.Drawing.Size(954, 481);
            this.disksDataGrid.TabIndex = 8;
            // 
            // diskId
            // 
            this.diskId.Frozen = true;
            this.diskId.HeaderText = "Id";
            this.diskId.Name = "diskId";
            this.diskId.ReadOnly = true;
            // 
            // diskTitle
            // 
            this.diskTitle.Frozen = true;
            this.diskTitle.HeaderText = "Название";
            this.diskTitle.Name = "diskTitle";
            this.diskTitle.ReadOnly = true;
            // 
            // diskCountry
            // 
            this.diskCountry.Frozen = true;
            this.diskCountry.HeaderText = "Страна";
            this.diskCountry.Name = "diskCountry";
            this.diskCountry.ReadOnly = true;
            // 
            // diskYear
            // 
            this.diskYear.Frozen = true;
            this.diskYear.HeaderText = "Год";
            this.diskYear.Name = "diskYear";
            this.diskYear.ReadOnly = true;
            // 
            // diskCost
            // 
            this.diskCost.Frozen = true;
            this.diskCost.HeaderText = "Стоимость";
            this.diskCost.Name = "diskCost";
            this.diskCost.ReadOnly = true;
            // 
            // diskAbout
            // 
            this.diskAbout.Frozen = true;
            this.diskAbout.HeaderText = "Описание";
            this.diskAbout.Name = "diskAbout";
            this.diskAbout.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск";
            // 
            // disksSearch
            // 
            this.disksSearch.Location = new System.Drawing.Point(64, 6);
            this.disksSearch.MaximumSize = new System.Drawing.Size(1550, 33);
            this.disksSearch.MinimumSize = new System.Drawing.Size(957, 33);
            this.disksSearch.Name = "disksSearch";
            this.disksSearch.Size = new System.Drawing.Size(1041, 22);
            this.disksSearch.TabIndex = 6;
            this.disksSearch.TextChanged += new System.EventHandler(this.SearchDisks);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 565);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1133, 612);
            this.MinimumSize = new System.Drawing.Size(1133, 612);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.mainTabControl.ResumeLayout(false);
            this.usersTabPage.ResumeLayout(false);
            this.usersTabPage.PerformLayout();
            this.userTabs.ResumeLayout(false);
            this.userAdminTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAdminGrid)).EndInit();
            this.userManagerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userManagerGrid)).EndInit();
            this.userCustomerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userClientGrid)).EndInit();
            this.disksTabPage.ResumeLayout(false);
            this.disksTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TabPage disksTabPage;
        private System.Windows.Forms.TabControl userTabs;
        private System.Windows.Forms.TabPage userAdminTabPage;
        private System.Windows.Forms.TabPage userManagerTabPage;
        private System.Windows.Forms.TabPage userCustomerTabPage;
        private System.Windows.Forms.Button userButtonAdd;
        private System.Windows.Forms.Button userButtonDelete;
        private System.Windows.Forms.Button userButtonEdit;
        private System.Windows.Forms.DataGridView userAdminGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserPatronumyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserPassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserPassportYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserPassportIssuer;
        private System.Windows.Forms.DataGridView userManagerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView userClientGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.TextBox userSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox disksSearch;
        private System.Windows.Forms.DataGridView disksDataGrid;
        private System.Windows.Forms.Button diskButtonDelete;
        private System.Windows.Forms.Button diskButtonEdit;
        private System.Windows.Forms.Button diskButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskAbout;
    }
}