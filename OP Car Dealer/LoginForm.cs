using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OP_Car_Dealer
{
    public partial class LoginForm : Form
    {
        public const string ADMIN = "admin";
        public const string KARYAWAN = "karyawan";
        public static int userID;

        public Form activeForm = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Cek apakah sudah diisi
            if (emailTextbox.Texts == "" || passwordTextbox.Texts == "")
            {
                MessageBox.Show("Tolong isi semua kolom!");
                return;
            }

            // Fetch data user dari database
            string query = "SELECT * FROM users WHERE username = @name OR email = @name;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.Parameters.AddWithValue("@name", emailTextbox.Texts);

            MySqlDataReader reader = cmd.ExecuteReader();

            // Cek apakah ditemukan atau tidak
            if (reader.Read())
            {
                // Cek password
                string hash = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(passwordTextbox.Texts)));
                if (reader.GetString("password") != hash)
                {
                    reader.Close();
                    MessageBox.Show("Password anda salah!");
                    return;
                }

                // Cek tipe akses user
                if (reader.GetString("types") == LoginForm.ADMIN)
                {
                    LoginForm.userID = reader.GetInt32("id_user");
                    activeForm = new AdminForm();
                }
                else if (reader.GetString("types") == LoginForm.KARYAWAN)
                {
                    LoginForm.userID = reader.GetInt32("id_user");
                    activeForm = new DealerForm();
                }
                reader.Close();

                Hide();
                activeForm.ShowDialog();
                Show();

                activeForm.Dispose();
            }
            else
            {
                reader.Close();

                // User tidak ditemukan
                MessageBox.Show("User tidak ditemukan!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DbConnection.openConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error membuka database aplikasi: {ex.Message}");
            }
        }

        // FORM MOVEMENT CODE
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
