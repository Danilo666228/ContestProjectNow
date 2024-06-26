﻿using ContestProject.Model.EF;
using ContestProject.Model.EF.Entities;
using ContestProject.Model.EF.Repository;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContestProject
{
    public partial class Organizer : Form
    {
        UserRepository dbUser = new UserRepository(new ContestDbContext());
        public Organizer()
        {
            InitializeComponent();
            InitDGW();
        }
        private async void InitDGW()
        {
            var users = await dbUser.GetUserNoOrg();
            dgwUsers.DataSource = users;
        }
        private async void InitComboBox()
        {
            var db = new RoleRepository(new ContestDbContext());
            var roles = await db.GetRoles();

            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";

            cmbRole.DataSource = roles;


        }
        private void WelcomeUser()
        {
            DateTime dataTime = DateTime.Now;
            if (dataTime.Hour > 9 && dataTime.Hour < 12)
            {
                lblDate.Text = "Доброе утро, Организатор";
            }
            else if (dataTime.Hour > 12 && dataTime.Hour < 18)
            {
                lblDate.Text = "Добрый день, Организатор";
            }
            else if (dataTime.Hour > 18 && dataTime.Hour < 24)
            {
                lblDate.Text = "Добрый вечер, Организатор";
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {

        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            WelcomeUser();

            InitComboBox();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var db = new UserRepository(new ContestDbContext());
            var validate = new Validate();
            var ExistUser = await db.ExistUser(txbEmail.Text);
            if (!ExistUser)
            {
                if (validate.RegistrationUser(txbEmail.Text, txbPassword.Text, txbRepeatPassword.Text, cmbGender.Text, txbFullName.Text, txbPhone.Text, cmbRole.Text))
                {
                    await db.AddUser(txbEmail.Text, txbPassword.Text, cmbGender.Text, txbFullName.Text, txbPhone.Text, (int)cmbRole.SelectedValue);
                    MessageBox.Show($"{cmbRole.Text} добавлен");
                }
            }
            else
            {
                MessageBox.Show("Пользователь с таким Email уже существует\nВыбери другой");
            }
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Organizer_Activated(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void dgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Вы уверены", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = dgwUsers.Rows[e.RowIndex].Cells["email"].Value.ToString();
                await dbUser.DeleteUser(name);
                MessageBox.Show("Успешно удален");
                InitDGW();
            }


        }
    }
}
