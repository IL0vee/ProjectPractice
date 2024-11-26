using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectPracticeV2
{
    public partial class Registration : Form
    {
        private bool isPasswordVisible;

        public Registration()
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
            Registration registration = this;
            registration.WindowState = FormWindowState.Minimized;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Trim() == "" || PassTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены", "Error");
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
                conn.Open();
                string querry = "SELECT * FROM Users WHERE Login=@Login and Password=@Password";
                SQLiteCommand cmd = new SQLiteCommand(querry, conn);
                cmd.Parameters.AddWithValue("@Login", LoginTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PassTextBox.Text);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Вы авторизовались", "Authorization successful");
                    Tables Tables = new Tables();
                    Tables.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации", "Error");
                }
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            if (!IsValidLogin(login))
            {
                MessageBox.Show("В логине не должно быть цифр", "Error");
                return;
            }
            if (LoginTextBox.Text.Trim() == "" && PassTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены", "Error");
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=Practice.db");
                conn.Open();
                {
                    SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Users (Login, Password) VALUES (@Login, @Password)", conn);
                    cmd.Parameters.Add(new SQLiteParameter("@Login", LoginTextBox.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", PassTextBox.Text));
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Регистрация завершена", "Registration successful");
                    conn.Close();
                }
            }
        }

        private bool IsValidLogin(string Login)
        {
            int result;
            return !int.TryParse(Login, out result);
        }

        private void PassVisibleButton_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            PassTextBox.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            PassTextBox.UseSystemPasswordChar = true;
        }
    }
}
