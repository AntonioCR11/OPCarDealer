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
    public partial class AdminInboxForm : Form
    {
        // VARIABLE
        DataTable DT_inbox;
        string lastQuery = "";

        public AdminInboxForm()
        {
            InitializeComponent();
            searchByComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;

            // Load DataGridView
            loadDG_Inbox();
            inboxDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inboxDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // DataGridView Related
        public void loadDGHeader()
        {
            // DataGridView Dummy
            string query = $@"
                SELECT id_car, id_car, id_dealer,CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) as 'Nama Mobil', 
                car_status, registration_date, period, registration_type, car_name as 'Nama Dealer'
                FROM cars where id_dealer = -1
            ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getConn());
            DT_inbox = new DataTable();
            adapter.Fill(DT_inbox);
            inboxDataGridView.DataSource = DT_inbox;
        }
        public void loadDataToDGV(string query)
        {
            // CREATE READER
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = DbConnection.getConn();

            // EXECUTE READER
            int id,dealer;
            string name, status, reg_date, period, reg_type, username;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                dealer = reader.GetInt32(1);
                name = reader.GetString(2);
                status = reader.GetString(3);
                reg_date = reader.GetString(4);
                period = reader.GetString(5);
                reg_type = reader.GetString(6);
                username = reader.GetString(7);

                // INSERT KE DGV (ID tidak bole sama dengan yang login)
                if (dealer != LoginForm.userID) { 
                    DT_inbox.Rows.Add(id, DT_inbox.Rows.Count + 1, dealer, name, status, reg_date, period, reg_type, username);
                }
            }
            reader.Close();

            inboxDataGridView.Columns[0].Visible = false;
            inboxDataGridView.Columns[2].Visible = false;
            inboxDataGridView.Columns[1].HeaderText = "No";
            inboxDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            inboxDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public void loadDG_Inbox()
        {
            try
            {
                lastQuery = $@"
                    SELECT id_car, id_dealer, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year), 
                    car_status, registration_date, period, registration_type, username
                    FROM cars
                    JOIN users ON cars.id_dealer = users.id_user
                    ORDER BY 1;
                ";

                loadDGHeader();
                loadDataToDGV(lastQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // SEARCH
        private void searchButton_Click(object sender, EventArgs e)
        {
            inboxDataGridView.DataSource = null;
            if (lastQuery.IndexOf("WHERE car_status") > -1)
            {
                lastQuery = lastQuery.Substring(0, lastQuery.IndexOf("ORDER"));
                if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 0)
                {
                    lastQuery += $@" AND CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 1)
                {
                    lastQuery += $@" AND registration_date like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 2)
                {
                    lastQuery += $@" AND period like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 3)
                {
                    lastQuery += $@" AND registration_type like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 4)
                {
                    lastQuery += $@" AND username like '%{searchTextbox.Texts}%' ";
                }
            }
            else if (lastQuery.IndexOf("AND car_status") > -1) {
                string firstQuery = lastQuery.Substring(0, lastQuery.IndexOf("WHERE"));
                string secondQuery = lastQuery.Substring(lastQuery.IndexOf("AND"), lastQuery.IndexOf("ORDER"));

                lastQuery = firstQuery; 
                if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 0)
                {
                    lastQuery += $@"WHERE CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 1)
                {
                    lastQuery += $@"WHERE registration_date like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 2)
                {
                    lastQuery += $@"WHERE period like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 3)
                {
                    lastQuery += $@"WHERE registration_type like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 4)
                {
                    lastQuery += $@"WHERE username like '%{searchTextbox.Texts}%' ";
                }
                lastQuery += secondQuery;
            }
            else{
                lastQuery = $@"
                    SELECT id_car, id_dealer, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year), 
                    car_status, registration_date, period, registration_type, username
                    FROM cars
                    JOIN users ON cars.id_dealer = users.id_user
                ";
                if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 0)
                {
                    lastQuery += $@"WHERE CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 1)
                {
                    lastQuery += $@"WHERE registration_date like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 2)
                {
                    lastQuery += $@"WHERE period like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 3)
                {
                    lastQuery += $@"WHERE registration_type like '%{searchTextbox.Texts}%' ";
                }
                else if (searchTextbox.Texts != "" && searchByComboBox.SelectedIndex == 4)
                {
                    lastQuery += $@"WHERE username like '%{searchTextbox.Texts}%' ";
                }
            }

            lastQuery += $@"
                    ORDER BY 1;
            ";
            loadDGHeader();
            loadDataToDGV(lastQuery);

        }
        private void inboxDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                DataRow selectedRow = DT_inbox.Rows[inboxDataGridView.CurrentRow.Index];
                int car_id = Convert.ToInt32(selectedRow[0].ToString());

                Inbox.InboxDetail form = new Inbox.InboxDetail(car_id);
                form.ShowDialog();

                loadDGHeader();
                loadDataToDGV(lastQuery);
            }
        }
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inboxDataGridView.DataSource = null;
            if (lastQuery.IndexOf("WHERE") > 0 && lastQuery.IndexOf("WHERE car_status") == -1)
            {
                // Jika ada filter tapi belum ada car_status
                if (lastQuery.IndexOf("AND") > 0) { lastQuery = lastQuery.Substring(0, lastQuery.IndexOf("AND")); }
                else { lastQuery = lastQuery.Substring(0, lastQuery.IndexOf("ORDER")); }

                // STATUS
                if (statusComboBox.SelectedIndex == 1){lastQuery += $@" AND car_status = 'Available'";}
                else if (statusComboBox.SelectedIndex == 2){lastQuery += $@" AND car_status = 'Pending'";}
                else if (statusComboBox.SelectedIndex == 3){lastQuery += $@" AND car_status = 'Declined'";}
            }
            else
            {
                // Jika tidak ada filter dan belum ada car_status
                lastQuery = $@"
                        SELECT id_car, id_dealer, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year), 
                        car_status, registration_date, period, registration_type, username
                        FROM cars
                        JOIN users ON cars.id_dealer = users.id_user
                ";

                if (statusComboBox.SelectedIndex == 1){lastQuery += $@"WHERE car_status = 'Available'";}
                else if (statusComboBox.SelectedIndex == 2){lastQuery += $@"WHERE car_status = 'Pending'";}
                else if (statusComboBox.SelectedIndex == 3){ lastQuery += $@"WHERE car_status = 'Declined'"; }
            }

            lastQuery += $@"
                        ORDER BY 1;
            ";
            loadDGHeader();
            loadDataToDGV(lastQuery);
        }

        private void AdminInboxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
