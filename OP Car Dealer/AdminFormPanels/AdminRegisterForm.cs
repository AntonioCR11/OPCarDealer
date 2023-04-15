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

namespace OP_Car_Dealer.AdminFormPanels
{
    public partial class AdminRegisterForm : Form
    {
        // DataSet Attribute
        private DataSet ds1;

        // Edit Attribute
        private bool insertMode;
        private int editId;
        private DataGridViewRow globalRow;

        public AdminRegisterForm()
        {
            InitializeComponent();
            ds1 = new DataSet();
            insertMode = true;
        }

        private void updateMode(bool isInsert)
        {
            this.insertMode = isInsert;

            if (this.insertMode)
            {
                registerModeLabel.Text = "Mode: Insert";
                deleteButton.Enabled = false;
            }
            else
            {
                registerModeLabel.Text = "Mode: Edit";
                deleteButton.Enabled = true;
            }
        }

        private void loadAllUsers()
        {
            ds1.Clear(); // Clear the DataSet for renewal

            // Create Query Command
            string query = "SELECT * FROM users ORDER BY LENGTH(id_user), id_user;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());

            // Fill the query result to a dataset
            MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
            adt.Fill(ds1);

            // Show the result to the GUI
            userDataGridView.DataSource = null;
            userDataGridView.DataSource = ds1.Tables[0];
        }

        /**
         * Loads the Form and the users data.
         * Called ones in the beginning and stores the data in a dataset.
         */
        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {
            loadAllUsers();
        }

        /**
         * Starts edit mode and put the selected data into the fields to start editing.
         * To exit edit mode, save the edit result or delete the record and it should go back to insert mode.
         */
        private void userDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateMode(false); // Update mode label

            // Sets the row and id of the now being edited record
            DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
            editId = Convert.ToInt32(row.Cells["id_user"].Value);
            globalRow = row;

            // Sets the field to be the same as the data being edited
            usernameTextbox.Texts = Convert.ToString(row.Cells["username"].Value);
            emailTextbox.Texts = Convert.ToString(row.Cells["email"].Value);
            addressTextbox.Texts = Convert.ToString(row.Cells["address"].Value);
            phoneTextbox.Texts = Convert.ToString(row.Cells["phone"].Value);

            int typesIndex = 0;
            bool continueSearch = true;
            while (typesIndex < typesComboBox.Items.Count && continueSearch)
            {
                if (typesComboBox.Items[typesIndex].ToString() == Convert.ToString(row.Cells["types"].Value)) continueSearch = false;
                else typesIndex++;
            }

            // Set the access types
            if (!continueSearch)
                typesComboBox.SelectedIndex = typesIndex;
            else typesComboBox.SelectedIndex = -1;
        }

        /**
         * Clears all fileds from the form
         */
        private void clearFields()
        {
            usernameTextbox.Texts = "";
            passwordTextbox.Texts = "";
            typesComboBox.SelectedIndex = -1;
            emailTextbox.Texts = "";
            addressTextbox.Texts = "";
            phoneTextbox.Texts = "";
        }

        /**
         * Updates a record while NOT in insert mode.
         */
        private void updateRecord()
        {
            // Determine whether use old password or new password if there is any
            string newPassword;
            if (passwordTextbox.Texts != "")
            {
                newPassword = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(passwordTextbox.Texts)));
            }
            else newPassword = Convert.ToString(globalRow.Cells["password"].Value);

            // MessageBox.Show(newPassword);

            // Starts the query to update the record
            string query = "UPDATE users SET username = @username, password = @password, email = @email, address = @address, phone = @phone, types = @types WHERE id_user = @id;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.Parameters.AddWithValue("@username", usernameTextbox.Texts);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@email", emailTextbox.Texts);
            cmd.Parameters.AddWithValue("@address", addressTextbox.Texts);
            cmd.Parameters.AddWithValue("@phone", phoneTextbox.Texts);
            cmd.Parameters.AddWithValue("@types", typesComboBox.Items[typesComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@id", editId);

            // Catch an error if anything happens while updating
            try
            {
                cmd.ExecuteNonQuery(); // Executes the query
                MessageBox.Show("Berhasil update record!"); // Shown to the user if the operation finishes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update record: " + ex.Message); // An error occured while doing the operation
            }

            updateMode(true); // Enter insert mode
        }

        /**
         * Inserts a record while in insertMode.
         */
        private void insertRecord()
        {
            // Hash new Password to be stored
            string newPassword = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(passwordTextbox.Texts)));

            // Prepares the query
            string query = "INSERT INTO users(username, password, email, address, phone, types) VALUES (@username, @password, @email, @address, @phone, @types);";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.Parameters.AddWithValue("@username", usernameTextbox.Texts);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@email", emailTextbox.Texts);
            cmd.Parameters.AddWithValue("@address", addressTextbox.Texts);
            cmd.Parameters.AddWithValue("@phone", phoneTextbox.Texts);
            cmd.Parameters.AddWithValue("@types", typesComboBox.Items[typesComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@id", editId);

            // Catch an error if anything happens while inserting
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert record berhasil!");
            } catch (Exception ex)
            {
                MessageBox.Show("Error melakukan Insert: " + ex.Message);
            }
        }

        /**
         * Do an insert or update operation based on what mode the form currently in.
         * After finishing the operation, refreshes the dataGridView.
         */
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Checks whether the required fields has been filled yet
            if (String.IsNullOrWhiteSpace(usernameTextbox.Texts) || String.IsNullOrWhiteSpace(passwordTextbox.Texts) || String.IsNullOrWhiteSpace(emailTextbox.Texts) || String.IsNullOrWhiteSpace(addressTextbox.Texts) || String.IsNullOrWhiteSpace(phoneTextbox.Texts) || typesComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Tolong isi semua kolom yang ada terlebih dahulu!");
                return;
            }

            // Do insert or update operation based on the mode
            if (this.insertMode == true)
                insertRecord();
            else
                updateRecord();

            clearFields(); // Resets the fields
            loadAllUsers(); // refreshes the dataGridView
        }

        /**
         * Do a delete operation on the record being edited.
         * Asks for a confirmation to avoid misclick, which after confirmed deletes the record from the database.
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Confirmation to delete record
            DialogResult response = MessageBox.Show($"Apakah anda yakin ingin melakukan delete pada id = {editId}?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (response == DialogResult.Yes)
            {
                // Prepares the query for deletion
                string query = "DELETE FROM users WHERE id_user = @id;";
                MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.Parameters.AddWithValue("@id", editId);

                // Catch if there is any error while the operation is running
                try
                {
                    cmd.ExecuteNonQuery(); // Do the delete operation
                    userDataGridView.Rows.RemoveAt(globalRow.Index); // Delete the row from the dataGridView

                    MessageBox.Show("Berhasil melakukan Delete!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error melakukan Delete: " + ex.Message); // An error occured while the operation is running
                }

                updateMode(true); // Enter insert mode
                clearFields();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Texts == "")
                loadAllUsers();
            else {
                // Prepares the query
                string searchQuery = $"%{searchTextbox.Texts}%";
                string query = "SELECT * FROM users WHERE username LIKE @text OR email LIKE @text OR address LIKE @text OR phone LIKE @text OR types LIKE @text;";
                MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.Parameters.AddWithValue("@text", searchQuery);

                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                ds1.Clear();

                // Catches the error while the operation is running
                try
                {
                    adt.Fill(ds1);

                    userDataGridView.DataSource = null;
                    userDataGridView.DataSource = ds1.Tables[0];
                } catch (Exception ex)
                {
                    MessageBox.Show("Error melakukan Search: " + ex.Message);
                }
            }
        }
    }
}
