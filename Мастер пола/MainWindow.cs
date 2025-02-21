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
        public MainWindow()
        {
            InitializeComponent();
            sklad.Visible = false;
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
            sklad.Visible = true;
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
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name_product", HeaderText = "Название", DataPropertyName = "Наименование_продукции" });
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

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
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
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Фаммилия", DataPropertyName = "Фамилия" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Имя", DataPropertyName = "Имя" });
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

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
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
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "dolgn", HeaderText = "Должность", DataPropertyName = "Наименование_должности" });
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            sklad.Visible = false;
            btnClosedatagrid.Visible = false;
        }

        private void зарегистрироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddUsers adusrs = new AddUsers();
            adusrs.Show();
            this.Hide();


        }

        private void поступлениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_продукции, Поступление_продукции from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Название продукции", DataPropertyName = "Название_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datapost", HeaderText = "Дата поступления", DataPropertyName = "Поступление_продукции" });
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

        private void местоХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_продукции, Место_хранения_продукции from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Название продукции", DataPropertyName = "Название_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datapost", HeaderText = "Место хранения продукции", DataPropertyName = "Место_хранения_продукции" });
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

        private void аопраоиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsers log = new LoginUsers();
            log.Show();
            this.Hide();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void материалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_материала, Место_хранения_материала, Поступление_материала from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Наименование материала", DataPropertyName = "Название_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Место хранения материала", DataPropertyName = "Место_хранения_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Дата поступления материала", DataPropertyName = "Поступление_материала" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegOrder reg = new RegOrder();
            reg.Show();
            this.Hide();
        }

        private void поступлениеМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Наименование_компании from Партнеры", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Компании", DataPropertyName = "Наименование_компании" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void списокToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Тип_заявки, Наименование_продукции, Стоимость, Статус from Заявка", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Тип заявки", DataPropertyName = "Тип_заявки" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Наименование продукции", DataPropertyName = "Наименование_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Стоимость", DataPropertyName = "Стоимость" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Статус", DataPropertyName = "Статус" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
