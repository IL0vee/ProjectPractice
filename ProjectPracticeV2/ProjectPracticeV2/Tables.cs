using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectPracticeV2
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
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
            Tables Tables = this;
            Tables.WindowState = FormWindowState.Minimized;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            TableStaff.Visible = false;
            TableJobs.Visible = false;
            TableAssignments.Visible = false;
        }

        private void ButtonStaff_Click(object sender, EventArgs e)
        {
            TableStaff.Visible = true;
            TableJobs.Visible = false;
            TableAssignments.Visible = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.DB");
            conn.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Staff", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TableStaff.DataSource = dt;
            conn.Close();
        }

        private void ButtonJobs_Click(object sender, EventArgs e)
        {
            TableStaff.Visible = false;
            TableJobs.Visible = true;
            TableAssignments.Visible = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.DB");
            conn.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Jobs", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TableJobs.DataSource = dt;
            conn.Close();
        }

        private void ButtonAssignments_Click(object sender, EventArgs e)
        {
            TableStaff.Visible = false;
            TableJobs.Visible = false;
            TableAssignments.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.DB");
            conn.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Assignments", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TableAssignments.DataSource = dt;
            conn.Close();
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

        private void ButtonRequests_Click(object sender, EventArgs e)
        {
            Requests Requests = new Requests();
            Requests.Show();
            Hide();
        }
    }
}
