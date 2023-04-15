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

    public partial class DealerReportsForm : Form
    {
        
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adap;

        public DealerReportsForm()
        {
            InitializeComponent();
            conn = DbConnection.getConn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string brmobil, nmmobil, tpmobil, mdmobil, hargamobil;
                transaksimobil crystalreport = new transaksimobil();
                crystalreport.SetDatabaseLogon(DbConnection.userId, DbConnection.password, DbConnection.server, DbConnection.db);
                //brand mobil
                if (cmbnamabrand.SelectedIndex == -1 || cmbnamabrand.Text == "")
                {
                    crystalreport.SetParameterValue("Brand_Mobil", "");
                }
                else
                {
                    brmobil = cmbnamabrand.Text;
                    crystalreport.SetParameterValue("Brand_Mobil", brmobil);
                }

                //nama mobil
                if (cmbnamamobil.SelectedIndex == -1 ||cmbnamamobil.Text == "")
                {
                    crystalreport.SetParameterValue("Nama_Mobil", "");
                }
                else
                {
                    nmmobil = cmbnamamobil.Text;
                    crystalreport.SetParameterValue("Nama_Mobil", nmmobil);
                }
                //tipe mobil
                if (cmbtipemobil.SelectedIndex == -1 || cmbtipemobil.Text=="")
                {
                    crystalreport.SetParameterValue("Tipe_Mobil", "");
                }
                else
                {
                    tpmobil = cmbtipemobil.Text;
                    crystalreport.SetParameterValue("Tipe_Mobil", tpmobil);
                }

                //model mobil
                if (cmbmodelmobil.SelectedIndex == -1)
                {
                    crystalreport.SetParameterValue("Model_Mobil", "");
                }
                else
                {
                    mdmobil = cmbmodelmobil.Text;
                    crystalreport.SetParameterValue("Model_Mobil", mdmobil);
                }
                if (tbharga.Text == "")
                {
                    crystalreport.SetParameterValue("harga_mobil", 0 );
                }
                else
                {
                    crystalreport.SetParameterValue("harga_mobil", tbharga.Text);
                }
                crystalReportViewer1.ReportSource = crystalreport;
                crystalReportViewer1.Refresh();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public void loadcmb()
        {
            loadbrands();
            loadtype();
            loadcar();
            loadmodel();
        }
        public void loadmodel()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct car_model from cars";
            MySqlDataReader reader = cmd.ExecuteReader();
            cmbmodelmobil.DisplayMember = "Text";
            cmbmodelmobil.ValueMember = "Value";
            while (reader.Read())
            {
                cmbmodelmobil.Items.Add(new { text = reader.GetString(0), value = reader.GetString(0) });
            }
            reader.Close();
        }
        public void loadcar()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct car_name from cars";
            MySqlDataReader reader = cmd.ExecuteReader();
            cmbnamamobil.DisplayMember = "Text";
            cmbnamamobil.ValueMember = "Value";
            while (reader.Read())
            {
                cmbnamamobil.Items.Add(new { text = reader.GetString(0), value = reader.GetString(0) });
            }
            reader.Close();
        }
        public void loadbrands()
        {
            DbConnection.openConn();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id_brand, brand_name from brands";
            MySqlDataReader reader = cmd.ExecuteReader();
            cmbnamabrand.DisplayMember = "Text";
            cmbnamabrand.ValueMember = "Value";
            while (reader.Read())
            {
                cmbnamabrand.Items.Add(new { Text = reader.GetString(1), value = reader.GetString(0) });
            }
            reader.Close();
        }
        public void loadtype()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select type_name from types";
            MySqlDataReader reader = cmd.ExecuteReader();
            cmbtipemobil.DisplayMember = "Text";
            cmbtipemobil.ValueMember = "Value";
            while (reader.Read())
            {
                cmbtipemobil.Items.Add(new { text = reader.GetString(0), value = reader.GetString(0) });
            }
            reader.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contentHeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            loadcmb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id_order, id_user, order_date, subtotal, hargamobil;
                reporttransaksi crystalreport = new reporttransaksi();
                crystalreport.SetDatabaseLogon(DbConnection.userId, DbConnection.password, DbConnection.server, DbConnection.db);
                //brand mobil
                if (tbidpengguna.Text == "")
                {
                    crystalreport.SetParameterValue("id_user", "");
                }
                else
                {
                    crystalreport.SetParameterValue("id_user", tbidpengguna.Text);
                }
                if (tbjumlahorder.Text == "")
                {
                    crystalreport.SetParameterValue("id_order", "");
                }
                else
                {
                    crystalreport.SetParameterValue("id_order", tbjumlahorder.Text);
                }
                if (tbSubtotal.Text == "")
                {
                    crystalreport.SetParameterValue("order_subtotal", 0);
                }
                else
                {
                    crystalreport.SetParameterValue("order_subtotal", tbSubtotal.Text);
                }
                
                
                   crystalreport.SetParameterValue("order_date", dateTimePicker1.Value.ToString("yyyy,MM,dd"));
                   crystalreport.SetParameterValue("oder_date1", dateTimePicker2.Value.ToString("yyyy,MM,dd"));

                crystalReportViewer2.ReportSource = crystalreport;
                crystalReportViewer2.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
