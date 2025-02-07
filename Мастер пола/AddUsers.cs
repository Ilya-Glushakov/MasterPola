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
    public partial class AddUsers : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola";
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            LogForm logform = new LogForm();
            logform.Show();
            this.Close();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            string Surname = txtSurname.Text;
            string Name = txtName.Text;
            string Mail = txtMail.Text;
            string Password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(Surname) || string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Mail) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Партнеры (Фамилия_директора, Имя_директора, Почта, Пароль) VALUES (@Surname, @Name, @Mail, @Password)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Surname", Surname);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Mail", Mail);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно");
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации");

            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
