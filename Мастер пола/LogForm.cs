using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастер_пола
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string Login = txtLog.Text;
            string Password = txtPass.Text;
            try
            {

                if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }

                bool boolfound = false;

                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from \"Партнеры\" where \"Почта\" = @mail and Пароль = @userpassword", connect))
                    {
                        command.Parameters.AddWithValue("@mail", Login);
                        command.Parameters.AddWithValue("@userpassword", Password);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                boolfound = true;
                                MainWindow win = new MainWindow();
                                win.Show();
                                MessageBox.Show("Добро пожаловать");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           AddUsers adduser = new AddUsers();
           adduser.Show();
           this.Hide();
        }
        Point lastpoint = new Point();
        private void LogForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
           

        }

        private void LogForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X,e.Y);
        }
        Point point = new Point();
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X,e.Y);
        }
    }
}
