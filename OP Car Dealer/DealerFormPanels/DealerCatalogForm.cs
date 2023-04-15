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
using MySql.Data.MySqlClient;

namespace OP_Car_Dealer.DealerFormPanels
{
    public partial class DealerCatalogForm : Form
    {
        // Attributes
        private DataSet ds1;
        private List<string> formColumns;
        private List<string> formFilters;

        // View Attributes
        private bool viewMode;
        private int viewId;
        private DataGridViewRow globalRow;

        public DealerCatalogForm()
        {
            InitializeComponent();

            ds1 = new DataSet();
            formColumns = new List<string>();
            formFilters = new List<string>();

            viewMode = false;
            viewId = -1;
        }

        private void DealerCatalogForm_Load(object sender, EventArgs e)
        {
            loadCars();
            loadFilter(brandFilterComboBox, "car_brand");
            loadFilter(typeFilterComboBox, "car_type");
            loadFilter(transmissionFilterComboBox, "car_transmission");
        }

        /**
         * Loads the target data that are going to be displayed at the filter
         */
        private void loadFilter(ComboBox comboBox, string targetColumn)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("");

            // Prepares query
            string query = $"SELECT DISTINCT {targetColumn} FROM cars;";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());

            MySqlDataReader reader = cmd.ExecuteReader(); // Execute query

            // Add the result to the combobox
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        /**
         * Loads all car data if no filter is selected, and loads only those who satisfy the filter if there is any/
         */
        private void loadCars()
        {
            ds1.Clear();

            // Adds the filter into the loadString
            string filterString = "WHERE";
            if (formColumns != null && formFilters != null)
            {
                // The length of the columns and filter should be the same, otherwise skip the filtering
                if (formColumns.Count > 0 && formFilters.Count > 0 && formColumns.Count == formFilters.Count)
                {
                    int i = 0;
                    do
                    {
                        if (formColumns[i] != null && formFilters[i] != null)
                        {
                            filterString += $" {formColumns[i]} = '{formFilters[i]}' AND";
                        }
                        i++;
                    } while (i < formColumns.Count);
                }
            }
            // Only select the available cars
            filterString += " car_status = 'available' ";
            
            // Prepares the query
            string query = $"SELECT * FROM cars {filterString}ORDER BY LENGTH(id_car), id_car";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());

            MySqlDataAdapter adt = new MySqlDataAdapter(cmd);

            // Catches an error occured while the operation is running
            try
            {
                adt.Fill(ds1);

                carDataGridView.DataSource = null;
                carDataGridView.DataSource = ds1.Tables[0];
            } catch (Exception ex)
            {
                MessageBox.Show("Error mengambil data: " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTextbox.Texts))
                loadCars(); // Loads all the data if no search input is inputted
            else
            {
                // Prepares the query string
                string searchString = $"%{searchTextbox.Texts}%";

                string query = "SELECT * FROM cars WHERE car_brand LIKE @search OR car_model LIKE @search OR car_type LIKE @search OR car_name LIKE @search OR car_transmission LIKE @search OR car_location LIKE @search OR car_status LIKE @search OR fuel LIKE @search OR color LIKE @search OR registration_date LIKE @search OR registration_type LIKE @search OR sparekey LIKE @search OR service_book LIKE @search OR warranty LIKE @search OR period LIKE @search";

                // Checks if the searchInput is number only or contains letters
                int output;
                bool valid = int.TryParse(searchTextbox.Texts, out output);
                if (valid)
                    query += " OR id_car = @intSearch OR id_dealer = @intSearch OR car_year = @intSearch OR car_kilometer = @intSearch OR car_price = @intSearch OR seat = @intSearch OR kilometer_driven = @intSearch";
                
                // Adds the filter into the search query
                string filterString = "";
                if (formColumns.Count == formFilters.Count)
                {
                    int i = 0;
                    while (i < formColumns.Count)
                    {
                        if (filterString == "") filterString += " AND";

                        filterString += $" {formColumns[i]} = '{formFilters[i]}'";

                        if (i + 1 < formColumns.Count) filterString += " AND";

                        ++i;
                    }
                }
                filterString += ";";
                query += filterString;

                // Prepares to execute the query
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

        /**
         * Sets the form filter and immedietly load the result
         */
        private void setFilter(ComboBox comboBox, string column)
        {
            int index = formColumns.IndexOf(column); // Get the index of existing filter

            // Remove existing column filter
            if (index >= 0)
            {
                formColumns.Remove(column);
                formFilters.RemoveAt(index);
            }

            if (comboBox.SelectedIndex > 0)
            {
                // Add new Filter
                string filter = comboBox.Items[comboBox.SelectedIndex].ToString();
                formColumns.Add(column);
                formFilters.Add(filter);
            }

            loadCars();
        }

        private void brandFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFilter((ComboBox)sender, "car_brand");
        }

        private void typeFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFilter((ComboBox)sender, "car_type");
        }

        private void transmissionFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFilter((ComboBox)sender, "car_transmission");
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // If the user hasnt selected a car to view, return to the browsing tab
            if (viewId < 0)
                tabControl1.SelectedIndex = 0;
        }

        private void carDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            globalRow = carDataGridView.Rows[e.RowIndex];
            viewId = Convert.ToInt32(globalRow.Cells[0].Value);
            viewMode = true;

            tabControl1.SelectedIndex = 1;

            // Load the fetched data
            idLabel.Text = globalRow.Cells[0].Value.ToString();
            brandLabel.Text = globalRow.Cells[2].Value.ToString();
            modelLabel.Text = globalRow.Cells[3].Value.ToString();
            carTypeLabel.Text = globalRow.Cells[4].Value.ToString();
            nameLabel.Text = globalRow.Cells[5].Value.ToString();
            carTransmissionLabel.Text = globalRow.Cells[6].Value.ToString();
            yearLabel.Text = globalRow.Cells[7].Value.ToString();
            kilometerLabel.Text = globalRow.Cells[8].Value.ToString();
            carPriceLabel.Text = "Rp. " + globalRow.Cells[9].Value.ToString();
            carLocationLabel.Text = globalRow.Cells[10].Value.ToString();
            statusLabel.Text = globalRow.Cells[11].Value.ToString();
            fuelLabel.Text = globalRow.Cells[12].Value.ToString();
            colorLabel.Text = globalRow.Cells[13].Value.ToString();
            seatLabel.Text = globalRow.Cells[14].Value.ToString();
            dateLabel.Text = globalRow.Cells[15].Value.ToString();
            registrationLabel.Text = globalRow.Cells[16].Value.ToString();
            drivenLabel.Text = globalRow.Cells[17].Value.ToString();
            spareKeyLabel.Text = globalRow.Cells[18].Value.ToString();
            bookLabel.Text = globalRow.Cells[19].Value.ToString();
            warrantyLabel.Text = globalRow.Cells[20].Value.ToString();
            periodLabel.Text = globalRow.Cells[21].Value.ToString();

            // Get Inspector
            MySqlCommand cmd = new MySqlCommand("SELECT username FROM users WHERE id_user = @id", DbConnection.getConn());
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(globalRow.Cells[1].Value));
            string username = cmd.ExecuteScalar().ToString();
            inspectorLabel.Text = username;

            // Load the associated picture and display an error if failed
            try {
                string currentDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                string picLocation = Directory.GetParent(currentDir).Parent.FullName;
                picLocation += $@"\Assets\Cars\car_{viewId}.jpg";
                carPictureBox.Image = Image.FromFile(picLocation);
            } catch (Exception ex) {
                MessageBox.Show("Error menampilkan gambar: " + ex.Message, "Error fetching picture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * The called event when adding to cart occured
         */
        private void cartButton_Click(object sender, EventArgs e)
        {
            string id_car = globalRow.Cells[0].Value.ToString();
            string query = $"insert into cart(id_user,id_car) values({LoginForm.userID},{id_car})";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil menambahkan ke cart!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void carDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
