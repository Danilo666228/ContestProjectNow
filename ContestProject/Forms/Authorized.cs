using ContestProject.Model.EF;
using ContestProject.Model.EF.Entities;
using ContestProject.Model.EF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContestProject.Captcha;

namespace ContestProject.Forms
{
    public partial class Authorized : Form
    {
        UserRepository dbUser = new UserRepository(new ContestDbContext());
        public Authorized()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = txbLogin.Text;
            string password = txbPassword.Text;
            bool Validated = true;
            string CapText = "a";

            try
            {
                var user = await dbUser.GetUser(txbLogin.Text, txbPassword.Text);
                if (user != null)
                {
                    if ((Validated) || ((!Validated) && (CapText == textBox1.Text)))
                    {
                        txbPassword.Clear();
                        if (user.Role.Name == "Организатор")
                        {
                            MessageBox.Show($"Добро пожаловать {user.Role.Name}");
                            Hide();
                            var organizer = new Organizer();
                            organizer.Show();
                        }
                        else if (user.Role.Name == "Жури")
                        {
                            MessageBox.Show($"Добро пожаловать {user.Role.Name}");
                            Hide();
                            var jury = new Jury();
                            jury.Show();
                        }
                        else if (user.Role.Name == "Участник")
                        {
                            MessageBox.Show($"Добро пожаловать {user.Role.Name}");
                            Hide();
                            var contest = new Contenst();
                            contest.Show();
                        }

                    }
                    else
                    {
                        if (CapText != textBox1.Text)
                        {
                            MessageBox.Show("Неверная капча");
                            btnLogin.Enabled = false;
                            btnLogin.Text = "10";
                            timer1.Start();
                            CaptchaIMG.Image = MakeCaptcha.CreateImage(CaptchaIMG.Width, CaptchaIMG.Height, out CapText);
                        }
                    }
                }
                else
                {
                    if (Validated)
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        Validated = !Validated;
                        CaptchaIMG.Image = MakeCaptcha.CreateImage(CaptchaIMG.Width, CaptchaIMG.Height, out CapText);
                    }
                    else
                    {
                        if (CapText != textBox1.Text)
                        {
                            MessageBox.Show("Неверная капча");
                            btnLogin.Enabled = false;
                            btnLogin.Text = "10";
                            timer1.Start();
                            CaptchaIMG.Image = MakeCaptcha.CreateImage(CaptchaIMG.Width, CaptchaIMG.Height, out CapText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}


