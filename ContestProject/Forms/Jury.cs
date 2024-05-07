using ContestProject.Model.EF;
using ContestProject.Model.EF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestProject.Forms
{
    public partial class Jury : Form
    {
        ResultRepository dbResult = new ResultRepository(new ContestDbContext());
        UserRepository dbUser = new UserRepository(new ContestDbContext());
        ContestRepository dbContest = new ContestRepository(new ContestDbContext());
        public Jury()
        {
            InitializeComponent();
            WelcomeUser();

        }
        private async void InitComboBoxes()
        {
            var users = await dbUser.GetUserNoOrg();
            cmbUser.DisplayMember = "FullName";
            cmbUser.ValueMember = "Id";
            cmbUser.DataSource = users;

            var contestes = await dbContest.GetContests();
            cmbContest.DisplayMember = "Name";
            cmbContest.ValueMember = "Id";
            cmbContest.DataSource = contestes;

        }
        private void WelcomeUser()
        {
            DateTime dataTime = DateTime.Now;
            if (dataTime.Hour > 9 && dataTime.Hour < 12)
            {
                lblDate.Text = "Доброе утро, Жури";
            }
            else if (dataTime.Hour > 12 && dataTime.Hour < 18)
            {
                lblDate.Text = "Добрый день, Жури";
            }
            else if (dataTime.Hour > 18 && dataTime.Hour < 24)
            {
                lblDate.Text = "Добрый вечер, Жури";
            }
        }

        private async void btnAddResult_Click(object sender, EventArgs e)
        {

            int userId = Convert.ToInt32(cmbUser.SelectedValue);
            int contestId = Convert.ToInt32(cmbContest.SelectedValue);

            await dbResult.AddResult(userId, contestId, txbResult.Text);

            MessageBox.Show("Результат конкурса добавлен");

        }

        private void Jury_Load(object sender, EventArgs e)
        {
            InitComboBoxes();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbContest_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
