using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        OleDbConnection cn = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data Source=""H:\db\Database21.accdb"""
        );
        OleDbConnection syscn = new OleDbConnection(
         @"Provider=Microsoft.ACE.OLEDB.12.0;" +
         @"Data Source=""H:\db\Database21.accdb"";" +
         @"Jet OLEDB:Create System Database=true;" + // разрешение на доступ
         @"Jet OLEDB:System database=C:\Users\8224201.SIPC\AppData\Roaming\Microsoft\Access\System.mdw"
        );

        Char[] separators = { ';' };
        Dictionary<String, Table> tables = new Dictionary<String, Table>();
        public Form1()
        {
            InitializeComponent();
            initTables();
        }


        private void initTables()
        {
            // Врач
            this.tables.Add("Врач", new Table
            {
                Name = "Врач",
                Fields = new[] { "Табельный_номер_врача", "Номер_лечебного_учреждения", "Фамилия", "Имя", "Отчество", "Специальность"},
                Args = new[] { "@NumDoc","NumMed", "@Family", "@Name", "@Otchestvo", "Speciality" },
                Defaults = new[] { "", "1", "", "", "", "", "" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) =>
                {
                    res.Add(rd.GetValue(rd.GetOrdinal("Табельный_номер_врача")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Номер_лечебного_учреждения")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Фамилия")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Имя")).ToString() +"; " +
                    rd.GetValue(rd.GetOrdinal("Отчество")).ToString() +"; " +
                    rd.GetValue(rd.GetOrdinal("Специальность")).ToString());
        }
            });

            // Диагоноз
            this.tables.Add("Диагноз", new Table
            {
                Name = "Диагноз",
                Fields = new[] { "Идентификатор_диагноза", "Описание_диагноза", "Лечение" },
                Args = new[] { "@Number", "@Description", "@Healing" },
                Defaults = new[] { "", "", "" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) => {
                    res.Add(rd.GetValue(rd.GetOrdinal("Идентификатор_диагноза")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Описание_диагноза")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Лечение")).ToString());
                }
            });

            // Леченбное заведение
            this.tables.Add("Лечебное_заведение", new Table
            {
                Name = "Лечебное_заведение",
                Fields = new[] {  "Номер_лечебного_учреждения", "Тип_лечебного_учреждения", "Специализация_лечебного_учреждения", "Адрес"},
                Args = new[] { "@Number", "@Type", "@Spec", "@Address" },
                Defaults = new[] { "1", "1", "1", "1" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) => {
                    res.Add(rd.GetValue(rd.GetOrdinal("Номер_лечебного_учреждения")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Тип_лечебного_учреждения")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Специализация_лечебного_учреждения")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Адрес")).ToString());
                }
            });

            // Процедура
            this.tables.Add("Процедура", new Table
            {
                Name = "Процедура",
                Fields = new[] { "Номер_процедуры", "Название", "Длительность", "Цена" },
                Args = new[] { "@Number", "@Name", "@Time", "@Cost" },
                Defaults = new[] { "1", "1", "1", "1" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) => {
                    res.Add(rd.GetValue(rd.GetOrdinal("Номер_процедуры")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Название")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Длительность")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Цена")).ToString());
                }
            });

            // Пациент
            this.tables.Add("Пациент", new Table
            {
                Name = "Пациент",
                Fields = new[] { "Номер_страхового_полиса", "Фамилия", "Имя", "Отчество", "Дата_рождения", "Адрес" },
                Args = new[] { "@Number", "@Family", "@Name", "@Otchestvo", "@Date", "@Address" },
                Defaults = new[] { "1", "", "", "", "01.01.2001", "" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) => {
                    res.Add(rd.GetValue(rd.GetOrdinal("Номер_страхового_полиса")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Фамилия")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Имя")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Отчество")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Дата_рождения")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Адрес")).ToString());
                }
            });

            // Прием
            this.tables.Add("Прием", new Table
            {
                Name = "Прием",
                Fields = new[] { "Номер_приема", "Номер_кабинета", "Дата_приема", "Табельный_номер_врача", "Номер_страхового_полиса", "Идентификатор_диагноза", "Номер_процедуры" },
                Args = new[] { "Nums", "@NummberCab", "@Date", "@NummberTab", "@NummberPol", "@Id", "@NumberProc" },
                Defaults = new[] { "", "1", "01.01.2001", "1", "31251251", "1", "1" },
                FormatDelegates = (List<String> res, OleDbDataReader rd) => {
                    res.Add(rd.GetValue(rd.GetOrdinal("Номер_приема")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Номер_кабинета")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Дата_приема")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Табельный_номер_врача")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Номер_страхового_полиса")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Идентификатор_диагноза")).ToString() + "; " +
                    rd.GetValue(rd.GetOrdinal("Номер_процедуры")).ToString());
                }

            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private List<String> Get_From_Table(String tableName, formatRequestResult format, OleDbCommand cmd)
        {
            List<String> res = new List<String>();
           
            try
            {
                
                

                cn.Open();
                if (cmd == null)
                    cmd = new OleDbCommand();

                cmd.Connection = cn;
                cmd.CommandText =
                "SELECT * FROM ";
                cmd.CommandText += tableName;
                //OleDbDataReader rd = cmd.ExecuteReader();
                //if (rd.HasRows)
                //{
                //    while (rd.Read())
                //    {
                //        format(res, rd);
                //    }
                //} else
                //{
                //    res.Add("-");
                //}

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                label1.Text = "successfully";
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close(); // закрытие соединения с БД
            }

            return res;
        }
        private String getSelectedTable()
        {
            if (Dogovor.Checked)
                return "Врач";
            else if (Magazin.Checked)
                return "Диагноз";
            else if (Otdel.Checked)
                return "Прием";
            else if (Postavshik.Checked)
                return "Лечебное_заведение";
            else if (Sotrudnik.Checked)
                return "Пациент";
            else if (Tovar.Checked)
                return "Процедура";

            return "";
        }
    
        private String formatArgs(String[] list)
        {
            String format = "";
            for (int i = 0; i < list.Length - 1; i++)
                format += list[i] + ", ";
            format += list[list.Length - 1];

            return format;
        }
        private void Add_new(String text, Table table)
        {
            cn.Open();
            try
            {
                String[] subs = text.Split(this.separators);
                if (subs.Length > table.Args.Length)
                    return;

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO " + table.Name + "(" + formatArgs(table.Fields) + ")";
                cmd.CommandText += "VALUES (" + formatArgs(table.Args) + ")";
                for (int i = 0; i < subs.Length; i++)
                    cmd.Parameters.AddWithValue(table.Args[i], subs[i]);
                for (int i = subs.Length;i < table.Args.Length;i++)
                    cmd.Parameters.AddWithValue(table.Args[i], table.Defaults[i]);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void Delete_Employee(String id, Table table)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM " + table.Name + " WHERE " + table.Fields[0] + " = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void Update(String text, Table table)
        {
            cn.Open();
            try
            {
                String[] subs = text.Split(this.separators);
                if (subs.Length > table.Args.Length)
                    return;

                String id = subs[0];
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE " + table.Name + " SET ";
                for (int i = 1;i < subs.Length - 1;i++)
                {
                    if (subs[i] != "")
                    {
                        String value = "@Value" + i.ToString();
                        cmd.CommandText += table.Fields[i] + " = " + value + ", ";
                        cmd.Parameters.AddWithValue(value, subs[i]);
                    }
                }
                cmd.CommandText += table.Fields[subs.Length - 1] + " = @LastValue";
                cmd.Parameters.AddWithValue("@LastValue", subs[subs.Length - 1]);
                cmd.CommandText += " WHERE " + table.Fields[0] + " = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                label1.Text = "successfuly";
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listBox1.Items.Clear();
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                foreach (String i in Get_From_Table(selectedTable, this.tables[selectedTable].FormatDelegates, null))
                    listBox1.Items.Add(i);
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Add_new(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Delete_Employee(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String selectedTable = getSelectedTable();
            if (selectedTable != "")
            {
                if (textBox1.Text != "")
                    Update(textBox1.Text, this.tables[selectedTable]);
                else
                    label1.Text = "input name and second name";
            }
            else
                label1.Text = "Select one of Tables";
        }
        private void processOther()
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;

           
                if (add.Checked)
                {
                    cmd.CommandText = "EXEC SQL2_Добавление_врача";
                }
                else if (delete.Checked)
                {
                    cmd.CommandText = "EXEC SQL2_Удаление_Пациента";
                }
                else if (radioUpdfate.Checked)
                {
                    cmd.CommandText = "EXEC SQL2_Обновление_диагноза";
                }

                cmd.ExecuteNonQuery();
                label1.Text = "successfully";
            }
            catch
            {
                label1.Text = "error";
            }
            finally
            {
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listBox1.Items.Clear();

            if (allDogovory.Checked)
            {
                String selectedTable = "SQLВрач";
                foreach (String i in Get_From_Table(selectedTable, this.tables["Врач"].FormatDelegates, null))
                    listBox1.Items.Add(i);
            }
            else if (allShops.Checked)
            {
                String selectedTable = "SQLДиагноз";
                foreach (String i in Get_From_Table(selectedTable, this.tables["Диагноз"].FormatDelegates, null))
                    listBox1.Items.Add(i);
            }
            else if (allPostavshiki.Checked)
            {
                String selectedTable = "SQLЛечебноеЗаведение";
                foreach (String i in Get_From_Table(selectedTable, this.tables["Лечебное_заведение"].FormatDelegates, null))
                    listBox1.Items.Add(i);
            }
            else if (param1.Checked)
            {
                String table = "SQLПоискВрача";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Parameters.AddWithValue("Введите_фамилию", textBox2.Text);
                foreach (String i in Get_From_Table(table, this.tables["Врач"].FormatDelegates, cmd))
                    listBox1.Items.Add(i);
            }
            else if (param2.Checked)
            {
                String table = "SQLПоискПроцедуры";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Parameters.AddWithValue("Введите_цену", textBox2.Text);
                foreach (String i in Get_From_Table(table, this.tables["Процедура"].FormatDelegates, cmd))
                    listBox1.Items.Add(i);
            }
            else if (param3.Checked)
            {
                String table = "SQLПоискПациента";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Parameters.AddWithValue("Введите_полис", textBox2.Text);
                foreach (String i in Get_From_Table(table, this.tables["Пациент"].FormatDelegates, cmd))
                    listBox1.Items.Add(i);
            }
            else
            {
                processOther();
            }
        }
        private List<String> Get_Sys()
        {
            syscn.Open();
            List<String> res = new List<String>();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = syscn;
                cmd.CommandText = "SELECT * FROM MSysObjects";

                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        res.Add(rd.GetValue(rd.GetOrdinal("Name")).ToString() + "; " +
                        rd.GetValue(rd.GetOrdinal("Type")).ToString());
                    }
                }
                else
                {
                    res.Add("-");
                }
                label1.Text = "successfully";
            }

            finally
            {
                syscn.Close();
            }
            return res;
        }
        private void sysreq_Click(object sender, EventArgs e)
        {
            foreach (String i in Get_Sys())
                listBox1.Items.Add(i);
        }


        private void add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = cn;
                string query = "select * from Врач";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            catch
            {

            }
        }
    }
    public delegate void formatRequestResult(List<String> res, OleDbDataReader rd);
    public class Table
    {
        String name = "";
        String[] fields;
        String[] args;
        String[] defaults;
        formatRequestResult formatsDelegates;

        public String Name { get; set; }
        public String[] Fields { get; set; }
        public String[] Args { get; set; }
        public String[] Defaults { get; set; }
        public formatRequestResult FormatDelegates { get; set; }
    }
}
