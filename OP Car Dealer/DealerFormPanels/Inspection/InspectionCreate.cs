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

namespace OP_Car_Dealer.DealerFormPanels.Inspection
{
    public partial class InspectionCreate : Form
    {
        // VARIABLE
        int last_id;
        public InspectionCreate()
        {
            InitializeComponent();
            loadBrandCB();
            loadTypeCB();
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
        // IMAGE UPLOAD RELATED
        private void imageNameLabel_Click(object sender, EventArgs e)
        {
            // OPEN FILE DIALOG
            string currentDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string initialDir = Directory.GetParent(currentDir).Parent.FullName;
            openFileDialog1.InitialDirectory = initialDir; 
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3, 3) == "jpg"){
                    imageNameLabel.Location = new Point(85, 58);
                    imageNameLabel.Size = new Size(428, 17);
                    imageNameLabel.Text = openFileDialog1.FileName;
                }
                else {
                    MessageBox.Show("Format Image harus berupa .jpg", "Error : File format not supported!");
                }
            }
        }
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // DRAG DROP IMAGE
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) { 
                var filename = data as string[];
                if (filename.Length>0) {
                    if (filename[0].Substring(filename[0].Length - 3, 3) == "jpg")
                    {
                        imageNameLabel.Location = new Point(85, 58);
                        imageNameLabel.Size = new Size(428, 17);
                        imageNameLabel.Text = filename[0];
                    }
                    else{
                        MessageBox.Show("Format Image harus berupa .jpg", "Error : File format not supported!");
                    }
                }
            }
        }
        private void InspectionCreate_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void copyToProjectDirectory() {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT MAX(id_car) from cars";
            cmd.Connection = DbConnection.getConn();

            // EXECUTE SCALAR
            last_id = Convert.ToInt32(cmd.ExecuteScalar().ToString())+1;

            // PINDAH FILE GAMBAR
            string currentDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string picLocation = Directory.GetParent(currentDir).Parent.FullName;
            picLocation += $@"\Assets\Cars\";
            string str = picLocation+"car_"+last_id+".jpg";
            if (!File.Exists(str)){
                File.Copy(imageNameLabel.Text, str);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isFieldEmpty())
            {
                // GAMBAR
                copyToProjectDirectory();

                // INSERT QUERY
                MySqlCommand cmd = new MySqlCommand();
                string query = $@"
                    INSERT INTO cars (id_car,id_dealer,car_brand,car_model,car_type,car_name,car_transmission,car_year,car_kilometer,car_price,car_location,car_status,fuel,color,seat,registration_date,registration_type, kilometer_driven,sparekey,service_book,warranty,PERIOD) 
                    VALUES (@idcar,@dealer,@brand,@model,@type,@name,@transmission,@year,@km,@price,@location,@status,@fuel,@color,@seat,@reg_date,@reg_type,@kilometer_driven,@sparekey,@book,@warranty,@period)
                ";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                // INSERT VALUE
                cmd.Parameters.AddWithValue("@idcar", last_id);
                cmd.Parameters.AddWithValue("@dealer", LoginForm.userID);
                cmd.Parameters.AddWithValue("@brand", brandComboBox.Text);
                cmd.Parameters.AddWithValue("@model", modelTextbox.Texts);
                cmd.Parameters.AddWithValue("@type", typeComboBox.Text);
                cmd.Parameters.AddWithValue("@name", nameTextbox.Texts);
                cmd.Parameters.AddWithValue("@transmission", transmisiComboBox.Text);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(yearNumericUpDown.Texts));
                cmd.Parameters.AddWithValue("@km", Convert.ToInt32(kmNumericUpDown.Texts));
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(priceNumericUpDown.Texts));
                cmd.Parameters.AddWithValue("@location", locationTextbox.Texts);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.Parameters.AddWithValue("@fuel", fuelComboBox.Text);
                cmd.Parameters.AddWithValue("@color", colorTextbox.Texts);
                cmd.Parameters.AddWithValue("@seat", Convert.ToInt32(seatNumericUpDown.Texts));
                cmd.Parameters.AddWithValue("@reg_date", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@reg_type", regTypeComboBox.Text);
                cmd.Parameters.AddWithValue("@kilometer_driven", Convert.ToInt32(kmNumericUpDown.Texts));
                cmd.Parameters.AddWithValue("@sparekey", spareKeyComboBox.Text);
                cmd.Parameters.AddWithValue("@book", serviceBookComboBox.Text);
                cmd.Parameters.AddWithValue("@warranty", warrantyDateTimePicker.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@period", periodDateTimePicker.Value.ToShortDateString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Insert mobil!", "Succes Insert Mobil!");
                exitButton.PerformClick();
            }
        }
        public bool isFieldEmpty()
        {
            if (modelTextbox.Texts != "" && nameTextbox.Texts != "" && locationTextbox.Texts != "" && colorTextbox.Texts != "")
            {
                if (brandComboBox.SelectedIndex>-1 && typeComboBox.SelectedIndex>-1
                    && transmisiComboBox.SelectedIndex>-1 && fuelComboBox.SelectedIndex>-1
                    && regTypeComboBox.SelectedIndex>-1 && spareKeyComboBox.SelectedIndex>-1
                    && serviceBookComboBox.SelectedIndex>-1) { 
                        return true;
                }
                else { MessageBox.Show("Semua field harus terisi!", "Error : Field Kosong!"); }
            }
            else { MessageBox.Show("Semua field harus terisi!", "Error : Field Kosong!"); }
            return false;
        }
    }
}
