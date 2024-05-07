using ContestProject.Model.EF;
using ContestProject.Model.EF.Entities;
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
    public partial class Contenst : Form
    {
        ResultRepository dbResult = new ResultRepository(new ContestDbContext());
        ContestRepository dbContest = new ContestRepository(new ContestDbContext());
        public Contenst()
        {
            InitializeComponent();
            InitDGW();
            InitComboBox();
        }
        private async void InitComboBox()
        {
            
            var names = await dbContest.GetContests();
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "Id";
            names.Insert(0, new Contest()
            {
                Name = "Все типы"
            });
            
            cmbName.DataSource = names;
           

        }
        
        private async void InitDGW()
        {
            var results = await dbResult.GetResults();
            dataGridView1.DataSource = results.Select(c=> new
            {
                c.User.FullName,
                c.Contest.Name,
                c.ResultContest
            }).ToList();
        }

        private async void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contestbyName = await dbResult.GetResultByName(cmbName.Text);
            dataGridView1.DataSource = contestbyName.Select(c=> new
            {
                c.User.FullName,
                c.Contest.Name,
                c.ResultContest
            }).ToList();
            if(cmbName.Text == "Все типы")
            {
                InitDGW();
            }
        }

        private async void btnAllType_Click(object sender, EventArgs e)
        {
            var contests = await dbResult.GetResults();
            dataGridView1.DataSource = contests.Select(c => new
            {
                c.User.FullName,
                c.Contest.Name,
                c.ResultContest
            }).ToList();
        }
    }
}
