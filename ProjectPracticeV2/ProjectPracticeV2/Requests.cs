using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectPracticeV2
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            TableRequests.Visible = false;
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RollUpForm_Click(object sender, EventArgs e)
        {
            Requests Requests = this;
            Requests.WindowState = FormWindowState.Minimized;
        }

        private void RequestsOne_Click(object sender, EventArgs e)
        {
            TableRequests.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
            string query = "SELECT Jobs.Id_job, Jobs.Code_job, Assignments.Service_number, Jobs.Name, Jobs.Planned_date, Assignments.Real_date " +
                "FROM Jobs " +
                "INNER JOIN Assignments ON Jobs.Code_job = Assignments.Code_job " +
                "WHERE strftime('%Y', Assignments.Real_date) = '2022' " +
                "AND Assignments.Real_date < Jobs.Planned_date; ";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                TableRequests.DataSource = dataTable;
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

        private void RequestsTwo_Click(object sender, EventArgs e)
        {
            TableRequests.Visible = true;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db"))
            {
                string query = "SELECT COUNT(*) AS Number_of_works, Jobs.Code_job, Jobs.name, Assignments.Service_number " +
                    "FROM Jobs " +
                    "INNER JOIN Assignments ON Jobs.Code_job = Assignments.Code_job " +
                    "WHERE Assignments.Service_number = @ServiceNumber " +
                    "AND strftime('%Y', Assignments.Date_issue) = '2023' " +
                    "AND strftime('%m', Assignments.Date_issue) IN('03', '04', '05') " +
                    "AND(Assignments.Real_date IS NULL OR strftime('%Y', Assignments.Real_date) = '2023'); ";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (string.IsNullOrWhiteSpace(ServiceNumberTextBox.Text))
                    {
                        MessageBox.Show("Пожалуйста, введите табельный номер сотрудника.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@ServiceNumber", ServiceNumberTextBox.Text);

                    try
                    {
                        conn.Open();

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            TableRequests.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            } 
        }

        private void Requests3_Click(object sender, EventArgs e)
        {
            TableRequests.Visible = true;
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
                TableRequests.DataSource = dataTable;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TableRequests.Visible = true;
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
                TableRequests.DataSource = dataTable;
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

        private void ButtonExitAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Registration Registration = new Registration();
                Registration.Show();
                Hide();
            }
        }

        private void ButtonBackForm_Click(object sender, EventArgs e)
        {
            Tables Tables = new Tables();
            Tables.Show();
            Hide();
        }
    }
}
