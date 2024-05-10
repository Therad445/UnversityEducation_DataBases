namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tovar = new System.Windows.Forms.RadioButton();
            this.Sotrudnik = new System.Windows.Forms.RadioButton();
            this.Postavshik = new System.Windows.Forms.RadioButton();
            this.Otdel = new System.Windows.Forms.RadioButton();
            this.Magazin = new System.Windows.Forms.RadioButton();
            this.Dogovor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioUpdfate = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.param3 = new System.Windows.Forms.RadioButton();
            this.param2 = new System.Windows.Forms.RadioButton();
            this.param1 = new System.Windows.Forms.RadioButton();
            this.allPostavshiki = new System.Windows.Forms.RadioButton();
            this.allShops = new System.Windows.Forms.RadioButton();
            this.allDogovory = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.sysreq = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(409, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 303);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tovar);
            this.groupBox1.Controls.Add(this.Sotrudnik);
            this.groupBox1.Controls.Add(this.Postavshik);
            this.groupBox1.Controls.Add(this.Otdel);
            this.groupBox1.Controls.Add(this.Magazin);
            this.groupBox1.Controls.Add(this.Dogovor);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Tovar
            // 
            this.Tovar.AutoSize = true;
            this.Tovar.Location = new System.Drawing.Point(107, 77);
            this.Tovar.Name = "Tovar";
            this.Tovar.Size = new System.Drawing.Size(80, 17);
            this.Tovar.TabIndex = 5;
            this.Tovar.TabStop = true;
            this.Tovar.Text = "Процедура";
            this.Tovar.UseVisualStyleBackColor = true;
            // 
            // Sotrudnik
            // 
            this.Sotrudnik.AutoSize = true;
            this.Sotrudnik.Location = new System.Drawing.Point(107, 49);
            this.Sotrudnik.Name = "Sotrudnik";
            this.Sotrudnik.Size = new System.Drawing.Size(68, 17);
            this.Sotrudnik.TabIndex = 4;
            this.Sotrudnik.TabStop = true;
            this.Sotrudnik.Text = "Пациент";
            this.Sotrudnik.UseVisualStyleBackColor = true;
            // 
            // Postavshik
            // 
            this.Postavshik.AutoSize = true;
            this.Postavshik.Location = new System.Drawing.Point(107, 20);
            this.Postavshik.Name = "Postavshik";
            this.Postavshik.Size = new System.Drawing.Size(129, 17);
            this.Postavshik.TabIndex = 3;
            this.Postavshik.TabStop = true;
            this.Postavshik.Text = "ЛечебноеЗаведение";
            this.Postavshik.UseVisualStyleBackColor = true;
            // 
            // Otdel
            // 
            this.Otdel.AutoSize = true;
            this.Otdel.Location = new System.Drawing.Point(6, 77);
            this.Otdel.Name = "Otdel";
            this.Otdel.Size = new System.Drawing.Size(59, 17);
            this.Otdel.TabIndex = 2;
            this.Otdel.TabStop = true;
            this.Otdel.Text = "Прием";
            this.Otdel.UseVisualStyleBackColor = true;
            // 
            // Magazin
            // 
            this.Magazin.AutoSize = true;
            this.Magazin.Location = new System.Drawing.Point(6, 49);
            this.Magazin.Name = "Magazin";
            this.Magazin.Size = new System.Drawing.Size(69, 17);
            this.Magazin.TabIndex = 1;
            this.Magazin.TabStop = true;
            this.Magazin.Text = "Диагноз";
            this.Magazin.UseVisualStyleBackColor = true;
            // 
            // Dogovor
            // 
            this.Dogovor.AutoSize = true;
            this.Dogovor.Location = new System.Drawing.Point(7, 20);
            this.Dogovor.Name = "Dogovor";
            this.Dogovor.Size = new System.Drawing.Size(49, 17);
            this.Dogovor.TabIndex = 0;
            this.Dogovor.TabStop = true;
            this.Dogovor.Text = "Врач";
            this.Dogovor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioUpdfate);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.param3);
            this.groupBox2.Controls.Add(this.param2);
            this.groupBox2.Controls.Add(this.param1);
            this.groupBox2.Controls.Add(this.allPostavshiki);
            this.groupBox2.Controls.Add(this.allShops);
            this.groupBox2.Controls.Add(this.allDogovory);
            this.groupBox2.Location = new System.Drawing.Point(19, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioUpdfate
            // 
            this.radioUpdfate.AutoSize = true;
            this.radioUpdfate.Location = new System.Drawing.Point(191, 77);
            this.radioUpdfate.Name = "radioUpdfate";
            this.radioUpdfate.Size = new System.Drawing.Size(58, 17);
            this.radioUpdfate.TabIndex = 9;
            this.radioUpdfate.TabStop = true;
            this.radioUpdfate.Text = "update";
            this.toolTip3.SetToolTip(this.radioUpdfate, "Обновление товара с id=1");
            this.radioUpdfate.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(191, 53);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(54, 17);
            this.delete.TabIndex = 8;
            this.delete.TabStop = true;
            this.delete.Text = "delete";
            this.toolTip2.SetToolTip(this.delete, "Удаление Товара");
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(191, 30);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(43, 17);
            this.add.TabIndex = 7;
            this.add.TabStop = true;
            this.add.Text = "add";
            this.toolTip1.SetToolTip(this.add, "Добавление Товара");
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // param3
            // 
            this.param3.AutoSize = true;
            this.param3.Location = new System.Drawing.Point(116, 77);
            this.param3.Name = "param3";
            this.param3.Size = new System.Drawing.Size(57, 17);
            this.param3.TabIndex = 6;
            this.param3.TabStop = true;
            this.param3.Text = "Полис";
            this.param3.UseVisualStyleBackColor = true;
            // 
            // param2
            // 
            this.param2.AutoSize = true;
            this.param2.Location = new System.Drawing.Point(116, 53);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(51, 17);
            this.param2.TabIndex = 5;
            this.param2.TabStop = true;
            this.param2.Text = "Цена";
            this.param2.UseVisualStyleBackColor = true;
            // 
            // param1
            // 
            this.param1.AutoSize = true;
            this.param1.Location = new System.Drawing.Point(116, 30);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(49, 17);
            this.param1.TabIndex = 4;
            this.param1.TabStop = true;
            this.param1.Text = "Врач";
            this.param1.UseVisualStyleBackColor = true;
            // 
            // allPostavshiki
            // 
            this.allPostavshiki.AutoSize = true;
            this.allPostavshiki.Location = new System.Drawing.Point(6, 77);
            this.allPostavshiki.Name = "allPostavshiki";
            this.allPostavshiki.Size = new System.Drawing.Size(153, 17);
            this.allPostavshiki.TabIndex = 3;
            this.allPostavshiki.TabStop = true;
            this.allPostavshiki.Text = "Все лечебные заведения";
            this.allPostavshiki.UseVisualStyleBackColor = true;
            // 
            // allShops
            // 
            this.allShops.AutoSize = true;
            this.allShops.Location = new System.Drawing.Point(6, 54);
            this.allShops.Name = "allShops";
            this.allShops.Size = new System.Drawing.Size(96, 17);
            this.allShops.TabIndex = 2;
            this.allShops.TabStop = true;
            this.allShops.Text = "Все диагнозы";
            this.allShops.UseVisualStyleBackColor = true;
            // 
            // allDogovory
            // 
            this.allDogovory.AutoSize = true;
            this.allDogovory.Location = new System.Drawing.Point(6, 30);
            this.allDogovory.Name = "allDogovory";
            this.allDogovory.Size = new System.Drawing.Size(76, 17);
            this.allDogovory.TabIndex = 1;
            this.allDogovory.TabStop = true;
            this.allDogovory.Text = "Все врачи";
            this.allDogovory.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(289, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "get";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sysreq
            // 
            this.sysreq.Location = new System.Drawing.Point(679, 331);
            this.sysreq.Name = "sysreq";
            this.sysreq.Size = new System.Drawing.Size(75, 23);
            this.sysreq.TabIndex = 13;
            this.sysreq.Text = "sysreq";
            this.sysreq.UseVisualStyleBackColor = true;
            this.sysreq.Click += new System.EventHandler(this.sysreq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 372);
            this.Controls.Add(this.sysreq);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Tovar;
        private System.Windows.Forms.RadioButton Sotrudnik;
        private System.Windows.Forms.RadioButton Postavshik;
        private System.Windows.Forms.RadioButton Otdel;
        private System.Windows.Forms.RadioButton Magazin;
        private System.Windows.Forms.RadioButton Dogovor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton param3;
        private System.Windows.Forms.RadioButton param2;
        private System.Windows.Forms.RadioButton param1;
        private System.Windows.Forms.RadioButton allPostavshiki;
        private System.Windows.Forms.RadioButton allShops;
        private System.Windows.Forms.RadioButton allDogovory;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioUpdfate;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.Button sysreq;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

