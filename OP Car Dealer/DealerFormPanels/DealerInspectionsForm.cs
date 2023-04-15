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

namespace OP_Car_Dealer.DealerFormPanels
{
    public partial class DealerInspectionsForm : Form
    {
        // VARIABLES
        DataTable DT_inspection;
        string lastQuery = "";

        public DealerInspectionsForm()
        {
            InitializeComponent();

            // Load DataGridView
            loadDG_Inspection();
            inspectionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inspectionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // DataGridView Related
        public void loadDGHeader() {
            // DataGridView Dummy
            string query = $"SELECT id_car, id_car, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) as 'Nama Mobil', car_status, registration_date, period, registration_type  FROM cars where id_dealer = -1;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DbConnection.getConn());
            DT_inspection = new DataTable();
            adapter.Fill(DT_inspection);
            inspectionDataGridView.DataSource = DT_inspection;
        }
        public void loadDataToDGV(string query) {
            // CREATE READER
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = DbConnection.getConn();

            // EXECUTE READER
            int id;
            string name, status, reg_date, period, reg_type;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                name = reader.GetString(1);
                status = reader.GetString(2);
                reg_date = reader.GetString(3);
                period = reader.GetString(4);
                reg_type = reader.GetString(5);

                // INSERT KE DGV
                DT_inspection.Rows.Add(id, DT_inspection.Rows.Count + 1, name, status, reg_date, period, reg_type);
            }
            reader.Close();

            inspectionDataGridView.Columns[0].Visible = false;
            inspectionDataGridView.Columns[1].HeaderText = "No";
            inspectionDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            inspectionDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public void loadDG_Inspection()
        {
            try
            {
                lastQuery = $"SELECT id_car, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year), car_status, registration_date, period, registration_type  FROM cars where id_dealer = {LoginForm.userID};";
                
                loadDGHeader();
                loadDataToDGV(lastQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            inspectionDataGridView.DataSource = null;
            lastQuery = $@"
                SELECT id_car, CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) as 'Nama Mobil', car_status, registration_date, period, registration_type 
                FROM cars 
                WHERE id_dealer = {LoginForm.userID}
            ";
            if (searchTextbox.Texts!="") { 
                lastQuery += $@"
                    AND CONCAT(car_brand,' ',car_model,' ',car_name,' ',car_year) like '%{searchTextbox.Texts}%' 
                    OR car_status like '%{searchTextbox.Texts}%'
                    OR registration_date like '%{searchTextbox.Texts}%'
                    OR period like '%{searchTextbox.Texts}%'
                    OR registration_type like '%{searchTextbox.Texts}%';
                ";
            }
            loadDGHeader();
            loadDataToDGV(lastQuery);
        }

        private void inspectionDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex > -1)
            {
                DataRow selectedRow = DT_inspection.Rows[inspectionDataGridView.CurrentRow.Index];
                int car_id = Convert.ToInt32(selectedRow[0].ToString());

                Inspection.InspectionDetail form = new Inspection.InspectionDetail(car_id);
                form.ShowDialog();

                loadDGHeader();
                loadDataToDGV(lastQuery);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Inspection.InspectionCreate form = new Inspection.InspectionCreate();
            form.ShowDialog();

            loadDGHeader();
            loadDataToDGV(lastQuery);
        }

        private void searchTextbox__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
