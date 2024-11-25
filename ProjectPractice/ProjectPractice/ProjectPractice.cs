using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectPractice
{
    public partial class ProjectPractice : Form
    {
        public ProjectPractice()
        {
            InitializeComponent();
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Staff", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Table.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Jobs", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Table.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Assignments", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Table.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Zapros1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
            string query = "SELECT Jobs.Id_job, Jobs.Code_job, Assignments.Service_number, Jobs.Name, Jobs.Planned_date, Assignments.Real_date " +
                "FROM Jobs " +
                "INNER JOIN Assignments ON Jobs.Code_job = Assignments.Code_job " +
                "WHERE strftime('%Y', Assignments.Real_date) = '2022' " +
                "AND Assignments.Real_date > Jobs.Planned_date; ";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Table.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Zapros2_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
            string query = "SELECT COUNT(*) AS Number_of_works " +
                "FROM Jobs " +
                "INNER JOIN Assignments ON Jobs.Code_job = Assignments.Code_job " +
                "WHERE Assignments.Service_number = '765823' " +
                "AND strftime('%Y', Assignments.Date_issue) = '2023' " +
                "AND(Assignments.Real_date IS NULL OR strftime('%Y', Assignments.Real_date) = '2023'); ";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Table.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Zapros3_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
            string query = "SELECT Jobs.*, Assignments.Real_laboriousness, Assignments.Real_date " +
                "FROM Jobs " +
                "INNER JOIN Assignments ON Jobs.Code_job = Assignments.Code_job " +
                "WHERE Assignments.Real_laboriousness <= 0.5 * Jobs.Laboriousness " +
                "AND Assignments.Planned_date <= Assignments.Real_date; ";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Table.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Zapros4_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
            string query = "SELECT Staff.Service_number, Staff.Staff_Name, Staff.Post, Jobs.Code_job, Jobs.name, COUNT(Staff.Service_number) AS Количество " +
                "FROM Staff " +
                "INNER JOIN Assignments ON Staff.Service_number = Assignments.Service_number " +
                "INNER JOIN Jobs ON Assignments.Code_job = Jobs.Code_job WHERE Jobs.name = 'Ремонт помещений' " +
                "GROUP BY Staff.Post; ";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Table.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
