using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace EmployeeBrowser
{
    public partial class frmMain : Form
    {
        public static class Data
        {
            public static string ConnectionString;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dTPTo.Value = DateTime.Now; 
            try
            {
                // Получение строки соединения
                StreamReader sr = File.OpenText("Settings.txt"); 
                Data.ConnectionString = sr.ReadLine();
                sr.Close();
                string conStr = Data.ConnectionString;

                // Получение базового списка сотрудников
                string cmd = "EXECUTE filtered_list_pr 0, ''";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conStr);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);       
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dbBindSource.DataSource = table;

                //grVwMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                grVwMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                grVwMain.ReadOnly = true;
                grVwMain.DataSource = dbBindSource;

                // Получение базового количества сотрудников
                SqlConnection con2 = new SqlConnection(conStr);
                con2.Open();
                string cmd2 = "EXECUTE count_pr 0, '', '', ''";
                SqlCommand sqlcmd2 = new SqlCommand(cmd2, con2);
                Int32 count = Convert.ToInt32(sqlcmd2.ExecuteScalar());
                if (count > 0)
                {
                    lblCount.Text = "Количество сотрудников: " + Convert.ToString(count.ToString());
                }
                else
                {
                    lblCount.Text = "Количество сотрудников: 0";
                }

                string cmd3 = "EXECUTE base_status_name_pr";
                SqlDataAdapter adpt = new SqlDataAdapter(cmd3,con2);
                DataSet ds = new DataSet();
                adpt.Fill(ds, "status");
                SqlCommand sqlcmd3 = new SqlCommand(cmd3, con2);

                cBxStatus.DataSource = ds.Tables["status"];
                cBxStatus.DisplayMember = "name";
                cBxStatus.ValueMember = "name";
                cBxStatus.Text = "-";
                con2.Close();

            }
            catch //(Exception ex)
            {
                MessageBox.Show("Убедитесь в правильности ввода строки подключения к базе данных в меню Настройки.", "Просмотр сотрудников");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int filterType = 0;
            if (cBxFilter.Text == "По статусу")
            {
                filterType = 1;
            }
            else if (cBxFilter.Text == "По отделу")
            {
                filterType = 2;
            }
            else if (cBxFilter.Text == "По должности")
            {
                filterType = 3;
            }
            else if (cBxFilter.Text == "По фамилии")
            {
                filterType = 4;
            }

            try
            {
                string conStr = Data.ConnectionString;
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string cmd = "EXECUTE filtered_list_pr " + filterType.ToString() + ", " + "'" + tBxFilter.Text + "'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conStr);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dbBindSource.DataSource = table;

                //grVwMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                grVwMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                grVwMain.ReadOnly = true;
                grVwMain.DataSource = dbBindSource;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Просмотр сотрудников");
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            if (Settings.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            if (cBxStatus.Text == "-")
            {
                MessageBox.Show("Выберите статус.", "Просмотр сотрудников");
            }
            else
            {
                int employmentType = 0;
                if (cBxEmpl.Text == "Принят на работу")
                {
                    employmentType = 1;
                }
                else if (cBxEmpl.Text == "Уволен")
                {
                    employmentType = 2;
                }

                try
                {
                    string conStr = Data.ConnectionString;
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    string cmd = "EXECUTE count_pr " + employmentType.ToString() + ", " + "'" + (cBxStatus.SelectedIndex + 1).ToString() + "'" + ", " + "'" + dTPFrom.Text + "'" + ", " + "'" + dTPTo.Text + "'";

                    SqlCommand sqlcmd2 = new SqlCommand(cmd, con);
                    Int32 count = Convert.ToInt32(sqlcmd2.ExecuteScalar());
                    if (count > 0)
                    {
                        lblCount.Text = "Количество сотрудников: " + Convert.ToString(count.ToString());
                    }
                    else
                    {
                        lblCount.Text = "Количество сотрудников: 0";
                    }

                    //grVwMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    grVwMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    grVwMain.ReadOnly = true;
                    grVwMain.DataSource = dbBindSource;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Просмотр сотрудников");
                }
            }
        }

    }
}
