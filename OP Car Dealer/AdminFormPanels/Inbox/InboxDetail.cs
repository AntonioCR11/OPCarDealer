using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Car_Dealer.AdminFormPanels.Inbox
{
    public partial class InboxDetail : Form
    {
        // VARIABLE
        int car_id;
        public InboxDetail(int car_id)
        {
            InitializeComponent();
            this.car_id = car_id;

            declineButton.FlatStyle = FlatStyle.Flat;
            declineButton.FlatAppearance.BorderSize = 0;

            loadBrandCB();
            loadTypeCB();
            updateComponent();
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
        public void loadBrandCB()
        {
            brandComboBox.Items.Clear();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT brand_name from brands GROUP BY 1 ORDER BY 1";
            cmd.Connection = DbConnection.getConn();

            // EXECUTE READER
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                brandComboBox.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
        }
        public void loadTypeCB()
        {
            typeComboBox.Items.Clear();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT type_name from types GROUP BY 1 ORDER BY 1";
            cmd.Connection = DbConnection.getConn();

            // EXECUTE READER
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                typeComboBox.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
        }
        public void updateComponent() {
            // GAMBAR MOBIL
            string currentDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string picLocation = Directory.GetParent(currentDir).Parent.FullName;
            picLocation += $@"\Assets\Cars\car_{car_id}.jpg";
            pictureBox1.Image = Image.FromFile(picLocation);

            // COMPONENT
            /*
                Column cars: 
                1. id_car	            11. car_location	    21. warranty	
                2. id_dealer	        12. car_status	        22. period
                3. car_brand	        13. fuel	
                4. car_model	        14. color	
                5. car_type	            15. seat	
                6. car_name	            16. registration_date	
                7. car_transmission	    17. registration_type	
                8. car_year	            18. kilometer_driven	
                9. car_kilometer	    19. sparekey	
                10. car_price	        20. service_book	
             */

            // CREATE READER
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT * FROM cars where id_car = {car_id};";
            cmd.Connection = DbConnection.getConn();

            // EXECUTE READER
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime warranty = DateTime.Parse(reader.GetString(20));
                DateTime period = DateTime.Parse(reader.GetString(21));

                brandComboBox.Text = reader.GetString(2);
                modelTextbox.Texts = reader.GetString(3);
                typeComboBox.Text = reader.GetString(4);
                nameTextbox.Texts = reader.GetString(5);
                transmisiComboBox.Text = reader.GetString(6);
                yearNumericUpDown.Texts = reader.GetInt32(7).ToString();
                kmNumericUpDown.Texts = reader.GetInt32(8).ToString();
                priceNumericUpDown.Texts = reader.GetInt32(9).ToString();
                locationTextbox.Texts = reader.GetString(10);
                fuelComboBox.Text = reader.GetString(12);
                colorTextbox.Texts = reader.GetString(13);
                seatNumericUpDown.Texts = reader.GetInt32(14).ToString();
                regTypeComboBox.Text = reader.GetString(16);
                spareKeyComboBox.Text = reader.GetString(18);
                serviceBookComboBox.Text = reader.GetString(19);
                warrantyDateTimePicker.Value = warranty;
                periodDateTimePicker.Value = period;

                brandComboBox.Enabled = false;
                modelTextbox.Enabled = false;
                typeComboBox.Enabled = false;
                nameTextbox.Enabled = false;
                transmisiComboBox.Enabled = false;
                yearNumericUpDown.Enabled = false;
                kmNumericUpDown.Enabled = false;
                priceNumericUpDown.Enabled = false;
                locationTextbox.Enabled = false;
                fuelComboBox.Enabled = false;
                colorTextbox.Enabled = false;
                seatNumericUpDown.Enabled = false;
                regTypeComboBox.Enabled = false;
                spareKeyComboBox.Enabled = false;
                serviceBookComboBox.Enabled = false;
                warrantyDateTimePicker.Enabled = false;
                periodDateTimePicker.Enabled = false;

                if (reader.GetString(11) == "Available" || reader.GetString(11) == "Declined" || reader.GetString(11) == "Sold") {
                    acceptButton.Enabled = false;
                    declineButton.Enabled = false;
                }
            }
            reader.Close();
        }

        // ACCEPT DECLINE BUTTON
        private void acceptButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to accept this Inspection?";
            string title = "Accept Inspection";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // UPDATE QUERY
                MySqlCommand cmd = new MySqlCommand();
                string query = $@"UPDATE cars SET car_status = @status WHERE id_car = @id";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                // UPDATE VALUE
                cmd.Parameters.AddWithValue("@id", car_id);
                cmd.Parameters.AddWithValue("@status", "Available");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil menerima inspeksi mobil", "Succes tambah mobil!");

                exitButton.PerformClick();
            }
        }
        private void declineButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to decline this Inspection?";
            string title = "Decline Inspection";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // UPDATE QUERY
                MySqlCommand cmd = new MySqlCommand();
                string query = $@"UPDATE cars SET car_status = @status WHERE id_car = @id";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                // UPDATE VALUE
                cmd.Parameters.AddWithValue("@id", car_id);
                cmd.Parameters.AddWithValue("@status", "Declined");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inspeksi mobil berhasil ditolak", "Inspeksi ditolak!");

                exitButton.PerformClick();
            }

        }
        // EXIT BUTTON
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
