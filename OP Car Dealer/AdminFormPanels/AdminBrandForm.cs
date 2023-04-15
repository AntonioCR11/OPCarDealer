using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Car_Dealer.AdminFormPanels
{
    public partial class AdminBrandForm : Form
    {
        // VARIABLE
        bool isInserting = false, isEditing = false;
        DataTable DT_brand;
        string lastQuery = "",currentBrandName = "";

        public AdminBrandForm()
        {
            InitializeComponent();

            // Load DataGridView
            lastQuery = $"SELECT * from brands;";
            loadDG_brand(lastQuery);
            brandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            brandDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void loadDG_brand(string query)
        {
            // DataGridView Dummy
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getConn());
            DT_brand = new DataTable();
            adapter.Fill(DT_brand);
            brandDataGridView.DataSource = DT_brand;
            brandDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        // INSERT BRAND
        private void brandNameTextbox__TextChanged(object sender, EventArgs e)
        {
            checkIfInserting();
        }
        public void checkIfInserting()
        {
            if (!isInserting && !isEditing)
            {
                saveButton.Enabled = true;

                // GET LAST ID
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT MAX(id_brand) from brands;";
                cmd.Connection = DbConnection.getConn();

                // EXECUTE SCALAR
                int last_id = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                brandIdTextbox.Texts = last_id.ToString();
                isInserting = true;
            } else if (brandNameTextbox.Texts == "" && !isEditing) {
                isInserting = false;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
                brandIdTextbox.Texts = "";
                brandModeLabel.Text = "Mode: Insert";
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isInserting) {
                // INSERT QUERY
                MySqlCommand cmd = new MySqlCommand();
                string query = $@"INSERT INTO brands (id_brand, brand_name) VALUES (@id,@name);";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                // INSERT VALUE
                cmd.Parameters.AddWithValue("@id", brandIdTextbox.Texts);
                cmd.Parameters.AddWithValue("@name", brandNameTextbox.Texts);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menambahkan " + brandNameTextbox.Texts + " kedalam brand", "Succes tambah brand!");

                // LOAD DGV
                loadDG_brand("SELECT * from brands;");

                // CLEAR COMPONENT
                brandIdTextbox.Texts = "";
                brandNameTextbox.Texts = "";
                isInserting = false;
                saveButton.Enabled = false;
            } else if (isEditing) {
                // INSERT QUERY
                MySqlCommand cmd = new MySqlCommand();
                string query = $@"UPDATE brands SET brand_name = @name WHERE id_brand = @id;";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                // INSERT VALUE
                cmd.Parameters.AddWithValue("@id", brandIdTextbox.Texts);
                cmd.Parameters.AddWithValue("@name", brandNameTextbox.Texts);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengupdate brand", "Succes update brand!");

                // LOAD DGV
                loadDG_brand("SELECT * from brands;");

                // CLEAR COMPONENT
                brandModeLabel.Text = "Mode: Insert";
                brandIdTextbox.Texts = "";
                brandNameTextbox.Texts = "";
                isInserting = false;
                isEditing = false;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }
        // SEARCH BUTTON
        private void searchButton_Click(object sender, EventArgs e)
        {
            brandDataGridView.DataSource = null;
            lastQuery = $"SELECT * from brands where brand_name like '%{searchTextbox.Texts}%';";
            loadDG_brand(lastQuery);
            brandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            brandDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // DELETE BUTTON
        private void brandDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                isEditing = true;
                DataRow selectedRow = DT_brand.Rows[brandDataGridView.CurrentRow.Index];
                int id = Convert.ToInt32(selectedRow[0].ToString());
                string name = selectedRow[1].ToString();
                currentBrandName = name;

                brandIdTextbox.Texts = id.ToString();
                brandNameTextbox.Texts = name;
                brandModeLabel.Text = "Mode: Edit";
                saveButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isEditing) {
                // CREATE READER
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $"SELECT id_car, car_brand FROM cars";
                cmd.Connection = DbConnection.getConn();

                // EXECUTE READER
                string brand;
                bool found = false;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    brand = reader.GetString(1);
                    if (brand == currentBrandName) { 
                        MessageBox.Show("Dilarang menghapus brand karena terdapat mobil terdaftar dengan brand ini!","Invalid Delete!");
                        found = true;
                        break;
                    }
                }
                reader.Close();

                if (!found) {
                    // DELTE QUERY
                    cmd = new MySqlCommand();
                    string query = $@"DELETE FROM brands WHERE id_brand = @id;";
                    cmd = new MySqlCommand(query, DbConnection.getConn());
                    // INSERT VALUE
                    cmd.Parameters.AddWithValue("@id", brandIdTextbox.Texts);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus " + brandNameTextbox.Texts + " dari brand", "Succes hapus brand!");

                    // LOAD DGV
                    loadDG_brand("SELECT * from brands;");

                    // CLEAR COMPONENT
                    brandModeLabel.Text = "Mode: Insert";
                    brandIdTextbox.Texts = "";
                    brandNameTextbox.Texts = "";
                    isInserting = false;
                    isEditing = false;
                    saveButton.Enabled = false;
                    deleteButton.Enabled = false;
                }
            }
        }
    }
}
