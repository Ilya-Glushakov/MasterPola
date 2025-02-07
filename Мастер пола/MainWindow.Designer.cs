namespace Мастер_пола
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партнерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.партнерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sklad = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.DataGridView();
            this.dolgnost = new System.Windows.Forms.DataGridView();
            this.btnClosedatagrid = new System.Windows.Forms.Button();
            this.поступлениеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местоХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(658, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складToolStripMenuItem,
            this.продукцияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.заявкаToolStripMenuItem,
            this.партнерыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.материалыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складаToolStripMenuItem,
            this.поступлениеЗаказаToolStripMenuItem,
            this.местоХраненияToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // складаToolStripMenuItem
            // 
            this.складаToolStripMenuItem.Name = "складаToolStripMenuItem";
            this.складаToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.складаToolStripMenuItem.Text = "№ ";
            this.складаToolStripMenuItem.Click += new System.EventHandler(this.складаToolStripMenuItem_Click);
            // 
            // продукцияToolStripMenuItem
            // 
            this.продукцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наименованиеToolStripMenuItem});
            this.продукцияToolStripMenuItem.Name = "продукцияToolStripMenuItem";
            this.продукцияToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.продукцияToolStripMenuItem.Text = "Продукция";
            // 
            // наименованиеToolStripMenuItem
            // 
            this.наименованиеToolStripMenuItem.Name = "наименованиеToolStripMenuItem";
            this.наименованиеToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.наименованиеToolStripMenuItem.Text = "Наименование";
            this.наименованиеToolStripMenuItem.Click += new System.EventHandler(this.наименованиеToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.должностьToolStripMenuItem,
            this.складToolStripMenuItem1,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.списокToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.должностьToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem1
            // 
            this.складToolStripMenuItem1.Name = "складToolStripMenuItem1";
            this.складToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.складToolStripMenuItem1.Text = "Склад";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // заявкаToolStripMenuItem
            // 
            this.заявкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.партнерToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.заявкаToolStripMenuItem.Name = "заявкаToolStripMenuItem";
            this.заявкаToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.заявкаToolStripMenuItem.Text = "Заявка";
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.типToolStripMenuItem.Text = "Создать";
            // 
            // партнерToolStripMenuItem
            // 
            this.партнерToolStripMenuItem.Name = "партнерToolStripMenuItem";
            this.партнерToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.партнерToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // партнерыToolStripMenuItem
            // 
            this.партнерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem1,
            this.удалитьToolStripMenuItem2,
            this.зарегистрироватьToolStripMenuItem});
            this.партнерыToolStripMenuItem.Name = "партнерыToolStripMenuItem";
            this.партнерыToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.партнерыToolStripMenuItem.Text = "Партнеры";
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.списокToolStripMenuItem1.Text = "Список";
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem3,
            this.списокToolStripMenuItem2});
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить ";
            // 
            // удалитьToolStripMenuItem3
            // 
            this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
            this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(163, 26);
            this.удалитьToolStripMenuItem3.Text = "Удалить";
            // 
            // списокToolStripMenuItem2
            // 
            this.списокToolStripMenuItem2.Name = "списокToolStripMenuItem2";
            this.списокToolStripMenuItem2.Size = new System.Drawing.Size(163, 26);
            this.списокToolStripMenuItem2.Text = "Список";
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоToolStripMenuItem,
            this.добавитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem4,
            this.поставщикToolStripMenuItem});
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.материалыToolStripMenuItem.Text = "Материалы";
            // 
            // количествоToolStripMenuItem
            // 
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.количествоToolStripMenuItem.Text = "Остаток";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(169, 26);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem4
            // 
            this.удалитьToolStripMenuItem4.Name = "удалитьToolStripMenuItem4";
            this.удалитьToolStripMenuItem4.Size = new System.Drawing.Size(169, 26);
            this.удалитьToolStripMenuItem4.Text = "Удалить";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.поставщикToolStripMenuItem.Text = "Поставщик";
            // 
            // sklad
            // 
            this.sklad.AllowUserToAddRows = false;
            this.sklad.AllowUserToDeleteRows = false;
            this.sklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sklad.Location = new System.Drawing.Point(0, 31);
            this.sklad.Name = "sklad";
            this.sklad.ReadOnly = true;
            this.sklad.RowHeadersWidth = 51;
            this.sklad.RowTemplate.Height = 24;
            this.sklad.Size = new System.Drawing.Size(461, 389);
            this.sklad.TabIndex = 2;
            // 
            // product
            // 
            this.product.AllowUserToDeleteRows = false;
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.Location = new System.Drawing.Point(0, 33);
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.RowHeadersWidth = 51;
            this.product.RowTemplate.Height = 24;
            this.product.Size = new System.Drawing.Size(461, 387);
            this.product.TabIndex = 3;
            // 
            // employee
            // 
            this.employee.AllowUserToDeleteRows = false;
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.Location = new System.Drawing.Point(0, 33);
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.RowHeadersWidth = 51;
            this.employee.RowTemplate.Height = 24;
            this.employee.Size = new System.Drawing.Size(461, 387);
            this.employee.TabIndex = 4;
            // 
            // dolgnost
            // 
            this.dolgnost.AllowUserToDeleteRows = false;
            this.dolgnost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dolgnost.Location = new System.Drawing.Point(0, 31);
            this.dolgnost.Name = "dolgnost";
            this.dolgnost.ReadOnly = true;
            this.dolgnost.RowHeadersWidth = 51;
            this.dolgnost.RowTemplate.Height = 24;
            this.dolgnost.Size = new System.Drawing.Size(461, 389);
            this.dolgnost.TabIndex = 5;
            // 
            // btnClosedatagrid
            // 
            this.btnClosedatagrid.Location = new System.Drawing.Point(0, 509);
            this.btnClosedatagrid.Name = "btnClosedatagrid";
            this.btnClosedatagrid.Size = new System.Drawing.Size(117, 57);
            this.btnClosedatagrid.TabIndex = 6;
            this.btnClosedatagrid.Text = "Закрыть";
            this.btnClosedatagrid.UseVisualStyleBackColor = true;
            this.btnClosedatagrid.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // поступлениеЗаказаToolStripMenuItem
            // 
            this.поступлениеЗаказаToolStripMenuItem.Name = "поступлениеЗаказаToolStripMenuItem";
            this.поступлениеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.поступлениеЗаказаToolStripMenuItem.Text = "Поступление заказа";
            // 
            // местоХраненияToolStripMenuItem
            // 
            this.местоХраненияToolStripMenuItem.Name = "местоХраненияToolStripMenuItem";
            this.местоХраненияToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.местоХраненияToolStripMenuItem.Text = "Место хранения";
            // 
            // зарегистрироватьToolStripMenuItem
            // 
            this.зарегистрироватьToolStripMenuItem.Name = "зарегистрироватьToolStripMenuItem";
            this.зарегистрироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зарегистрироватьToolStripMenuItem.Text = "Зарегистрировать";
            this.зарегистрироватьToolStripMenuItem.Click += new System.EventHandler(this.зарегистрироватьToolStripMenuItem_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(217)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(682, 565);
            this.Controls.Add(this.btnClosedatagrid);
            this.Controls.Add(this.dolgnost);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.product);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продукцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партнерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партнерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.DataGridView sklad;
        private System.Windows.Forms.DataGridView product;
        private System.Windows.Forms.DataGridView employee;
        private System.Windows.Forms.DataGridView dolgnost;
        private System.Windows.Forms.Button btnClosedatagrid;
        private System.Windows.Forms.ToolStripMenuItem поступлениеЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местоХраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьToolStripMenuItem;
    }
}