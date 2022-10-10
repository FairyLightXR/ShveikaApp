using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShveikaApp.Model;
using ShveikaApp.Utils;

namespace ShveikaApp.Views
{
    public partial class AuthForm : Form
    {
        
        
        
        public AuthForm()
        {
            InitializeComponent();
            
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                MessageBox.Show("Поле 'Пароль' обязательно к заполнению! ");
                return;
            }
            if (String.IsNullOrWhiteSpace(LoginTxt.Text))
            {
                MessageBox.Show("Поле 'Логин' обязательно к заполнению! ");
                return;
            }
            foreach (User user in DbContext.Context.User.ToList())
            {
                if (user.UserLogin == LoginTxt.Text && user.UserPassword == PasswordTxt.Text)
                {
                   CurrentUser.UserCurrent = user;
                   
                }
            }
            if (CurrentUser.UserCurrent.UserID ==0)
            {
                MessageBox.Show("Неверный логин/пароль");
                return;
            }
            MenuForm menuForm = new MenuForm();
            switch (CurrentUser.UserCurrent.UserRole)
            {

                case 1:
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();

                    break;
                case 2:
                    
                    this.Hide();
                    menuForm.Show();
                    break;
                case 3:
                    
                    this.Hide();
                    menuForm.Show();
                    break; 
            }
        }

        private void GuestEnterBtn_Click(object sender, EventArgs e)
        {
            
            MainForm MainFrm = new MainForm();
            this.Hide();
            MainFrm.Show();
        }
    }
}
