using System;
using System.Collections;
using System.Windows.Forms;

namespace DVDS
{
    public partial class DiskForm : Form, IDiskFormView
    {
        private readonly DiskPresenter _presenter;

        public DiskForm()
        {
            InitializeComponent();
            _presenter = new DiskPresenter(this);

            Init();
        }

        public DiskForm(int id)
        {
            InitializeComponent();
            _presenter = new DiskPresenter(this);

            Init();

            _presenter.SetDiskFields(id);
        }

        private void Init()
        {
            _presenter.SetCountries(diskCardCountry1);
            _presenter.SetCountries(diskCardCountry2);
            _presenter.SetCountries(diskCardCountry3);

            _presenter.SetGenres(diskCardGenre1);
            _presenter.SetGenres(diskCardGenre2);
            _presenter.SetGenres(diskCardGenre3);
            _presenter.SetGenres(diskCardGenre4);
            _presenter.SetGenres(diskCardGenre5);
            _presenter.SetGenres(diskCardGenre6);
        }

        private void SaveDisk(object sender, EventArgs e)
        {
            bool isUpdate = _presenter.UpdateDisk(
                diskCardCost.Text,
                diskCardCount.Text,
                diskCardAbout.Text,
                diskCardTitle.Text,
                diskCardDIrectedBy.Text,
                diskCardActors.Text,
                diskCardYear.Value,
                new ArrayList()
                {
                    diskCardCountry1.SelectedIndex,
                    diskCardCountry2.SelectedIndex,
                    diskCardCountry3.SelectedIndex
                },
                new ArrayList()
                {
                    diskCardGenre1.SelectedIndex,
                    diskCardGenre2.SelectedIndex,
                    diskCardGenre3.SelectedIndex,
                    diskCardGenre4.SelectedIndex,
                    diskCardGenre5.SelectedIndex,
                    diskCardGenre6.SelectedIndex
                }
                );

            if (isUpdate)
            {
                Close();
            }
            else
            {
                ShowAlert("Не удалось обновить информацию о диске.");
            }
        }

        // Interface methods implementation =================
        public void SetDiskFields(Disk disk)
        {
            diskCardId.Text = disk.Id.ToString();
            diskCardCost.Text = disk.Cost.ToString();
            diskCardCount.Text = disk.Count.ToString();
            diskCardAbout.Text = disk.About;
            diskCardTitle.Text = disk.Title;
            diskCardDIrectedBy.Text = disk.DirectedBy;
            diskCardActors.Text = disk.Actors;
            diskCardYear.Value = disk.Year;

            ArrayList countries = disk.GetCountries();
            for (int i = 0; i < countries.Count; i++)
            {
                if (i == 0)
                {
                    diskCardCountry1.SelectedIndex = (int)countries[0];
                }

                if (i == 1)
                {
                    diskCardCountry2.SelectedIndex = (int)countries[1];
                }

                if (i == 2)
                {
                    diskCardCountry3.SelectedIndex = (int)countries[2];
                }
            }

            ArrayList genres = disk.GetGenres();
            for (int i = 0; i < genres.Count; i++)
            {
                if (i == 0)
                {
                    diskCardGenre1.SelectedIndex = (int)genres[0];
                }

                if (i == 1)
                {
                    diskCardGenre2.SelectedIndex = (int)genres[1];
                }

                if (i == 2)
                {
                    diskCardGenre3.SelectedIndex = (int)genres[2];
                }

                if (i == 3)
                {
                    diskCardGenre4.SelectedIndex = (int)genres[3];
                }

                if (i == 4)
                {
                    diskCardGenre5.SelectedIndex = (int)genres[4];
                }

                if (i == 5)
                {
                    diskCardGenre6.SelectedIndex = (int)genres[5];
                }
            }
        }

        public void ShowAlert(string alert)
        {
            MessageBox.Show(alert);
        }
    }
}
