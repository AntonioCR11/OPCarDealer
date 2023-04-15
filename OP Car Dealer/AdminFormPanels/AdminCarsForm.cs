using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace OP_Car_Dealer.AdminFormPanels
{
    public partial class AdminCarsForm : Form
    {
        // Attributes
        private DataSet ds1;
        private string newFileName;

        // Edit Attributes
        private bool insertMode;
        private int editId;
        private string oldPath;
        private DataGridViewRow globalRow;

        public AdminCarsForm()
        {
            InitializeComponent();

            ds1 = new DataSet();
            newFileName = "";

            insertMode = true;
            editId = -1;
            oldPath = "";
        }

        /**
         * Load the data related to cars into a DataGridView.
         * Called one while loading the form.
         */
        private void AdminCarsForm_Load(object sender, EventArgs e)
        {
            loadAllCars(); // Loads the data
            loadTypes();
            loadInspectors();
        }

        /**
         * Updates the mode of the form.
         * Enabling insert mode disables
         */
        private void updateMode(bool isInsert)
        {
            if (isInsert) {
                carModeLabel.Text = "Mode: Insert";
                insertMode = true;
                deleteButton.Enabled = false;
                inspectorComboBox.Enabled = true;
            } else
            {
                carModeLabel.Text = "Mode: Edit";
                insertMode = false;
                deleteButton.Enabled = true;
                inspectorComboBox.Enabled = false;
            }
        }

        /**
         * TODO
         * Updates a record while NOT in insert mode.
         */
        private void updateRecord()
        {
            // Starts the query to update the record
            string query = "UPDATE cars SET car_brand = @brand, car_model = @model, car_type = @type, car_name = @name, car_transmission = @transmission, car_year = @year, car_kilometer = @kilometer, car_price = @price, car_location = @location, car_status = @status, fuel = @fuel, color = @color, seat = @seat, registration_date = @date, registration_type = @type, kilometer_driven = @driven, sparekey = @spare, service_book = @book, warranty = @warranty, period = @period WHERE id_car = @id;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.Parameters.AddWithValue("@id", editId);
            cmd.Parameters.AddWithValue("@dealer", inspectorComboBox.SelectedIndex);
            cmd.Parameters.AddWithValue("@brand", brandTextbox.Texts);
            cmd.Parameters.AddWithValue("@model", modelTextbox.Texts);
            cmd.Parameters.AddWithValue("@type", typeComboBox.Items[typeComboBox.SelectedIndex]);
            cmd.Parameters.AddWithValue("@name", nameTextbox.Texts);
            cmd.Parameters.AddWithValue("@transmission", transmissionComboBox.Items[transmissionComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(yearNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@kilometer", Convert.ToInt32(kilometerNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(hargaNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@location", locationTextbox.Texts);
            cmd.Parameters.AddWithValue("@status", statusComboBox.Items[statusComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@fuel", fuelComboBox.Items[fuelComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@color", colorTextbox.Texts);
            cmd.Parameters.AddWithValue("@seat", Convert.ToInt32(seatNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMM yyyy"));
            cmd.Parameters.AddWithValue("@regisType", registrationComboBox.Items[registrationComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@driven", Convert.ToInt32(drivenNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@spare", spareKeyComboBox.Items[spareKeyComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@book", bookComboBox.Items[bookComboBox.SelectedIndex].ToString());

            // Dates
            string warranty;
            if (warrantyDateTimePicker.Value > DateTime.Today)
                warranty = warrantyDateTimePicker.Value.ToString("MMM yyyy");
            else warranty = "Tidak";

            string period = periodDateTimePicker.Value.ToString("MMM yyyy");
            cmd.Parameters.AddWithValue("@warranty", warranty);
            cmd.Parameters.AddWithValue("@period", period);


            // Catch an error if anything happens while updating
            try
            {
                cmd.ExecuteNonQuery(); // Executes the query

                // Replace the image if new path is chosen
                if (imageTextbox.Texts != oldPath)
                {
                    string newPath = Path.Combine(@"asset\images\car_" + editId + ".jpg");
                    File.Delete(newPath);
                    File.Copy(imageTextbox.Texts, newPath);
                }

                MessageBox.Show("Berhasil update record!"); // Shown to the user if the operation finishes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update record: " + ex.Message); // An error occured while doing the operation
            }

            updateMode(true); // Enter insert mode
        }

        /**
         * TODO
         * Inserts a record while in insertMode.
         */
        private void insertRecord()
        {
            // Prepares the query
            string query = "INSERT INTO cars(id_dealer, car_brand, car_model, car_type, car_name, car_transmission, car_year, car_kilometer, car_price, car_location, car_status, fuel, color, seat, registration_date, registration_type, kilometer_driven, sparekey, service_book, warranty, period) VALUES (@dealer, @brand, @model, @type, @name, @transmission, @year, @kilometer, @price, @location, @status, @fuel, @color, @seat, @date, @regisType, @driven, @spare, @book, @warranty, @period);";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.Parameters.AddWithValue("@dealer", inspectorComboBox.SelectedIndex);
            cmd.Parameters.AddWithValue("@brand", brandTextbox.Texts);
            cmd.Parameters.AddWithValue("@model", modelTextbox.Texts);
            cmd.Parameters.AddWithValue("@type", typeComboBox.Items[typeComboBox.SelectedIndex]);
            cmd.Parameters.AddWithValue("@name", nameTextbox.Texts);
            cmd.Parameters.AddWithValue("@transmission", transmissionComboBox.Items[transmissionComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(yearNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@kilometer", Convert.ToInt32(kilometerNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(hargaNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@location", locationTextbox.Texts);
            cmd.Parameters.AddWithValue("@status", statusComboBox.Items[statusComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@fuel", fuelComboBox.Items[fuelComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@color", colorTextbox.Texts);
            cmd.Parameters.AddWithValue("@seat", Convert.ToInt32(seatNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MMM yyyy"));
            cmd.Parameters.AddWithValue("@regisType", registrationComboBox.Items[registrationComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@driven", Convert.ToInt32(drivenNumericUpDown.Texts));
            cmd.Parameters.AddWithValue("@spare", spareKeyComboBox.Items[spareKeyComboBox.SelectedIndex].ToString());
            cmd.Parameters.AddWithValue("@book", bookComboBox.Items[bookComboBox.SelectedIndex].ToString());

            // Dates
            string warranty;
            if (warrantyDateTimePicker.Value > DateTime.Today)
                warranty = warrantyDateTimePicker.Value.ToString("MMM yyyy");
            else warranty = "Tidak";

            string period = periodDateTimePicker.Value.ToString("MMM yyyy");
            cmd.Parameters.AddWithValue("@warranty", warranty);
            cmd.Parameters.AddWithValue("@period", period);

            // Catch an error if anything happens while inserting
            try
            {
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("SELECT MAX(id_car) from cars", DbConnection.getConn());
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                // Copys the chosen image to the program directory
                string path = Path.Combine(@"asset\images");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path); // If directory doesn't exists, create one

                path = $"{path}\\car_{newId}.jpg";
                File.Copy(imageTextbox.Texts, path); // Copy file

                MessageBox.Show("Insert record berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error melakukan Insert: " + ex.Message);
            }
        }

        /**
         * Loads all types of cars that are in the database.
         */
        private void loadTypes()
        {
            typeComboBox.Items.Clear(); // Resets the combobox

            // Prepares the query
            string query = "SELECT * FROM types ORDER BY LENGTH(id_type), id_type;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            MySqlDataReader reader = cmd.ExecuteReader();

            // Add the result to the combobox
            while (reader.Read())
            {
                typeComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
        }

        private void loadInspectors()
        {
            inspectorComboBox.Items.Clear(); // Resets the combobox

            // Prepares the query
            string query = "SELECT * FROM users ORDER BY LENGTH(id_user), id_user;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            MySqlDataReader reader = cmd.ExecuteReader();

            // Add the result to the combobox
            while (reader.Read())
            {
                inspectorComboBox.Items.Add(reader.GetString("username"));
            }
            reader.Close();
        }

        /**
         * Loads the cars data into the DataGridView
         */
        private void loadAllCars()
        {
            ds1.Clear(); // Clears the dataset for renewal

            // Prepares a query
            string query = "SELECT * FROM cars ORDER BY LENGTH(id_car), id_car;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());

            MySqlDataAdapter adt = new MySqlDataAdapter(cmd);

            // Catches an error if occured while the operation is running
            try
            {
                adt.Fill(ds1); // Fills the Datagridview with the fetched data

                // Shows the data to the user
                carDataGridView.DataSource = null;
                carDataGridView.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil data: " + ex.Message);
            }
        }

        /**
         * Resets all the field in the form back to default value
         */
        private void resetFields()
        {
            // TextBoxs
            brandTextbox.Texts = brandTextbox.Placeholder;
            modelTextbox.Texts = modelTextbox.Placeholder;
            nameTextbox.Texts = nameTextbox.Placeholder;
            locationTextbox.Texts = locationTextbox.Placeholder;
            colorTextbox.Texts = colorTextbox.Placeholder;
            imageTextbox.Texts = imageTextbox.Placeholder;

            // Date Time Picker
            warrantyDateTimePicker.Value = DateTime.Today;
            periodDateTimePicker.Value = DateTime.Today;

            // ComboBox
            typeComboBox.SelectedIndex = -1;
            transmissionComboBox.SelectedIndex = -1;
            statusComboBox.SelectedIndex = -1;
            fuelComboBox.SelectedIndex = -1;
            spareKeyComboBox.SelectedIndex = -1;
            bookComboBox.SelectedIndex = -1;
            registrationComboBox.SelectedIndex = -1;
            inspectorComboBox.SelectedIndex = -1;

            // Numeric up down
            yearNumericUpDown.Texts = yearNumericUpDown.MinimumValue.ToString();
            kilometerNumericUpDown.Texts = kilometerNumericUpDown.MinimumValue.ToString();
            hargaNumericUpDown.Texts = hargaNumericUpDown.MinimumValue.ToString();
            seatNumericUpDown.Texts = seatNumericUpDown.MinimumValue.ToString();
            drivenNumericUpDown.Texts = drivenNumericUpDown.MinimumValue.ToString();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            // Catches an error if occured while the operation is running
            try
            {
                // Get the new imageFile
                OpenFileDialog fileDialog = new OpenFileDialog();

                // Has the form target a file yet?
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageTextbox.Texts = fileDialog.FileName.ToString(); // Gets the targeted file path and name
                    // newFileName = Path.GetFileName(fileDialog.FileName);
                    // MessageBox.Show(newFileName);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Checks whether all the data required has been inputed
            if (String.IsNullOrWhiteSpace(brandTextbox.Texts) || String.IsNullOrWhiteSpace(modelTextbox.Texts) || String.IsNullOrWhiteSpace(nameTextbox.Texts) || String.IsNullOrWhiteSpace(locationTextbox.Texts) || String.IsNullOrWhiteSpace(colorTextbox.Texts) || String.IsNullOrWhiteSpace(brandTextbox.Texts) || String.IsNullOrWhiteSpace(imageTextbox.Texts) || typeComboBox.SelectedIndex < 0 || transmissionComboBox.SelectedIndex < 0 || statusComboBox.SelectedIndex < 0 || fuelComboBox.SelectedIndex < 0 || spareKeyComboBox.SelectedIndex < 0 || bookComboBox.SelectedIndex < 0 || registrationComboBox.SelectedIndex < 0 || inspectorComboBox.SelectedIndex < 0 || kilometerNumericUpDown.Texts == kilometerNumericUpDown.MinimumValue.ToString() || periodDateTimePicker.Value.ToString("dd MM yyyy") == DateTime.Now.ToString("dd MM yyyy"))
            {
                MessageBox.Show("Tolong isi semua kolom terlebih dahulu!");
                return;
            }

            // Checks wheter the form is in insert mode or update mode and act accordingly
            if (insertMode)
                insertRecord(); // Do the insert operation
            else
                updateRecord(); // Do the update operation

            resetFields();
            loadAllCars();
        }

        /**
         * Starts updating the selected record. Can either be updated or deleted based on what button was pressed.
         * Can exit edit mode by simply saving the record back without doing any changes to the data.
         */
        private void carDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateMode(false); // Updates the form mode to update mode

            // Sets what record is being edited
            globalRow = carDataGridView.Rows[e.RowIndex];
            editId = Convert.ToInt32(globalRow.Cells[0].Value); // The car Id

            // Sets the fields with the data from the record being selected
            brandTextbox.Texts = globalRow.Cells["car_brand"].Value.ToString();
            modelTextbox.Texts = globalRow.Cells["car_model"].Value.ToString();
            nameTextbox.Texts = globalRow.Cells["car_name"].Value.ToString();
            locationTextbox.Texts = globalRow.Cells["car_location"].Value.ToString();
            colorTextbox.Texts = globalRow.Cells["color"].Value.ToString();

            // Type Combobox
            int i = 0;
            bool isValid = false;
            while(i < typeComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["car_type"].Value.ToString() == typeComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                typeComboBox.SelectedIndex = i;

            // Transmission Combobox
            i = 0;
            isValid = false;
            while(i < transmissionComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["car_transmission"].Value.ToString() == transmissionComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                transmissionComboBox.SelectedIndex = i;

            // Status Combobox
            i = 0;
            isValid = false;
            while(i < statusComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["car_status"].Value.ToString() == statusComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                statusComboBox.SelectedIndex = i;

            // Fuel Combobox
            i = 0;
            isValid = false;
            while(i < fuelComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["fuel"].Value.ToString() == fuelComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                fuelComboBox.SelectedIndex = i;

            // Spare Key Combobox
            i = 0;
            isValid = false;
            while(i < spareKeyComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["sparekey"].Value.ToString() == spareKeyComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                spareKeyComboBox.SelectedIndex = i;

            // Book Combobox
            i = 0;
            isValid = false;
            while(i < bookComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["service_book"].Value.ToString() == bookComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                bookComboBox.SelectedIndex = i;

            // Registration Combobox
            i = 0;
            isValid = false;
            while(i < registrationComboBox.Items.Count && !isValid) {
                if (globalRow.Cells["registration_type"].Value.ToString() == registrationComboBox.Items[i].ToString()) isValid = true;
                else i++;
            }
            if (isValid)
                registrationComboBox.SelectedIndex = i;

            // Inspector Combobox
            try
            {
                inspectorComboBox.SelectedIndex = Convert.ToInt32(globalRow.Cells["id_dealer"].Value) - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            yearNumericUpDown.Texts = globalRow.Cells["car_year"].Value.ToString();
            kilometerNumericUpDown.Texts = globalRow.Cells["car_kilometer"].Value.ToString();
            hargaNumericUpDown.Texts = globalRow.Cells["car_price"].Value.ToString();
            seatNumericUpDown.Texts = globalRow.Cells["seat"].Value.ToString();
            drivenNumericUpDown.Texts = globalRow.Cells["kilometer_driven"].Value.ToString();

            oldPath = Path.Combine(Path.GetFullPath(@"asset\images\car_" + editId + ".jpg"));
            imageTextbox.Texts = oldPath; // Image path being used now

            // Convert from string to dateTime for Warranty
            if (globalRow.Cells["warranty"].Value.ToString() != "Tidak" && globalRow.Cells["warranty"].Value.ToString() != "Ya")
                warrantyDateTimePicker.Value = Convert.ToDateTime(globalRow.Cells["warranty"].Value.ToString(), CultureInfo.InvariantCulture);
            else warrantyDateTimePicker.Value = DateTime.Now;
            warrantyDateTimePicker.Refresh();

            // Convert from string to dateTime for Period
            if (globalRow.Cells["period"].Value.ToString() != "Tidak" && globalRow.Cells["period"].Value.ToString() != "Ya")
                periodDateTimePicker.Value = Convert.ToDateTime(globalRow.Cells["period"].Value.ToString(), CultureInfo.InvariantCulture);
            else periodDateTimePicker.Value = DateTime.Now;
            periodDateTimePicker.Refresh();
        }

        /**
         * Deletes the selected row after a confirmation
         */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus record ini?", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM cars WHERE id_car = @id;";
                MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.Parameters.AddWithValue("@id", editId);

                // Catch error if occured while operation is running
                try
                {
                    cmd.ExecuteNonQuery(); // Execute operation

                    carDataGridView.Rows.Remove(globalRow); // Delete row from dataGridView
                    File.Delete(Path.Combine(@"asset\images\car_" + editId + ".jpg")); // Delete image file from directory

                    MessageBox.Show("Berhasil mendelete record!");

                    updateMode(true); // Update mode to insert mode
                    resetFields();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error saat menghapus record: " + ex.Message);
                }
            }
        }

        /**
         * Search the car database for potential matches and display them in the DataGridView
         * Only checks string data if the query contains letters, and checks both string and number if only numbers is inputed
         */
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTextbox.Texts))
                loadAllCars(); // Loads all the data if no search input is inputted
            else
            {
                // Prepares the query string
                string searchString = $"%{searchTextbox.Texts}%";

                string query = "SELECT * FROM cars WHERE car_brand LIKE @search OR car_model LIKE @search OR car_type LIKE @search OR car_name LIKE @search OR car_transmission LIKE @search OR car_location LIKE @search OR car_status LIKE @search OR fuel LIKE @search OR color LIKE @search OR registration_date LIKE @search OR registration_type LIKE @search OR sparekey LIKE @search OR service_book LIKE @search OR warranty LIKE @search OR period LIKE @search";

                // Checks if the searchInput is number only or contains letters
                int output;
                bool valid = int.TryParse(searchTextbox.Texts, out output);
                if (valid)
                    query += " OR id_car = @intSearch OR id_dealer = @intSearch OR car_year = @intSearch OR car_kilometer = @intSearch OR car_price = @intSearch OR seat = @intSearch OR kilometer_driven = @intSearch;";
                else query += ";";

                // Prepares the query
                MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.Parameters.AddWithValue("@search", searchString);
                if (valid) cmd.Parameters.AddWithValue("@intSearch", Convert.ToInt32(searchTextbox.Texts));

                ds1.Clear();
                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);

                // Catches an error if occured while the operation is running
                try
                {
                    adt.Fill(ds1); // Fill the dataGridView with the searched data

                    // Show the data to the user
                    carDataGridView.DataSource = null;
                    carDataGridView.DataSource = ds1.Tables[0];
                    carDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error mengambil data: " + ex.Message);
                }
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
