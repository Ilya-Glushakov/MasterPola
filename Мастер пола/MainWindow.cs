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
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастер_пола
{

    public partial class MainWindow : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola";

        public MainWindow()
        {
            InitializeComponent();
            sklad.Visible = false;
            product.Visible = false;
            employee.Visible = false;
            dolgnost.Visible = false;
            btnClosedatagrid.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зарегистрироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void складаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Номер_склада from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Number", HeaderText = "Номер", DataPropertyName = "Номер_склада" });
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void наименованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            product.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Наименование_продукции from Продукция", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            product.AutoGenerateColumns = false;
                            product.Columns.Clear();

                            product.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name_product", HeaderText = "Название", DataPropertyName = "Наименование_продукции" });
                            product.DataSource = dataTable;
                            if (product.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            employee.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Фамилия, Имя from Сотрудники", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            employee.AutoGenerateColumns = false;
                            employee.Columns.Clear();

                            employee.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Фаммилия", DataPropertyName = "Фамилия" });
                            employee.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Имя", DataPropertyName = "Имя" });
                            employee.DataSource = dataTable;
                            if (employee.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            dolgnost.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Наименование_должности from  Должность", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dolgnost.AutoGenerateColumns = false;
                            dolgnost.Columns.Clear();
                            dolgnost.Columns.Add(new DataGridViewTextBoxColumn() { Name = "dolgn", HeaderText = "Должность", DataPropertyName = "Наименование_должности" });
                            dolgnost.DataSource = dataTable;
                            if (dolgnost.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dolgnost.Visible = false;
            sklad.Visible = false;
            product.Visible = false;
            employee.Visible = false;
            dolgnost.Visible = false;
            btnClosedatagrid.Visible = false;
        }

        private void зарегистрироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           AddUsers addUsers = new AddUsers();
            addUsers.Show();
            this.Close();
           
        }
    }

}
