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

namespace OP_Car_Dealer.DealerFormPanels
{
    public partial class DealerOrdersForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        List<PictureBox> listPhoto = new List<PictureBox>();
        List<Label> listName = new List<Label>();
        List<Button> btnDecline = new List<Button>();

        public DealerOrdersForm()
        {
            InitializeComponent();
            ShowCart();
        }
        public void ShowCart()
        {
            string query = "SELECT CONCAT(crs.car_brand,' ',crs.car_model,' ',car_type,' ',car_name),crt.id_cart,crs.id_car,concat('Rp. ',format(crs.car_price,0))" +
                           "FROM cart crt "+
                           "JOIN cars crs ON crt.id_car = crs.id_car " +
                           "JOIN users us ON crt.id_user = us.id_user " +
                           $"where us.id_user = {LoginForm.userID}";
            MySqlCommand cmd = new MySqlCommand(query,DbConnection.getConn());
            MySqlDataReader reader = cmd.ExecuteReader();
            int i=0;
            while (reader.Read())
            {
                // ==Flow Panel Value==
                // *Panel Container v
                // *Picture Box v
                // *Label Name v
                // *Button Approve v
                // *Button Decline v
                // ====================

                // Declare Panel Container
                Panel tempP = new Panel();
                tempP.Size = tempPanel.Size;
                if (i % 2 == 0)
                {
                    tempP.BackColor = tempPanel.BackColor;
                }
                else
                {
                    tempP.BackColor = Color.Linen;
                }
                int x = tempPanel.Location.X;
                int y = tempPanel.Location.Y;
                tempP.Location = new Point(x, y+(i * y)+10);
                tempP.Anchor = tempPanel.Anchor;
                tempP.Visible = true;
                // Declare PictureBox Value (Photo)
                {
                    PictureBox tempL = new PictureBox();
                    tempL.Size = pictureBox1.Size;
                    tempL.BackColor = pictureBox1.BackColor;
                    tempL.Visible = true;
                    x = pictureBox1.Location.X;
                    y = pictureBox1.Location.Y;
                    string currentDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                    string picLocation = Directory.GetParent(currentDir).Parent.FullName;
                    picLocation += $@"\Assets\Cars\car_{reader.GetString(2)}.jpg";
                    tempL.Image = Image.FromFile(picLocation);
                    tempL.SizeMode = PictureBoxSizeMode.StretchImage;
                    tempL.Location = new Point(x, y);
                    listPhoto.Add(tempL);
                    tempP.Controls.Add(tempL);
                }
                // Declare Name Label Value
                {
                    Label tempLab = new Label();
                    tempLab.AutoSize = true;
                    tempLab.BackColor = tempP.BackColor;
                    x = name.Location.X;
                    y = name.Location.Y;
                    tempLab.Text = reader.GetString(0);
                    tempLab.Font = name.Font;
                    tempLab.Location = new Point(x, y);
                    tempLab.Anchor = name.Anchor;
                    tempLab.Visible = true;
                    listName.Add(tempLab);
                    tempP.Controls.Add(tempLab);
                }
                // Declare Decline Button
                {
                    Button tempB = new Button();
                    tempB.Size = decline.Size;
                    tempB.BackColor = decline.BackColor;
                    tempB.BackgroundImageLayout = decline.BackgroundImageLayout;
                    x = decline.Location.X;
                    y = decline.Location.Y;
                    tempB.Font = decline.Font;
                    tempB.Text = decline.Text;
                    tempB.Location = new Point(x, y);
                    tempB.Anchor = decline.Anchor;
                    tempB.BackgroundImage = decline.BackgroundImage;
                    tempB.Visible = true;
                    tempB.Click += new EventHandler(this.decline_Click);
                    tempB.Tag = reader.GetString(2);
                    btnDecline.Add(tempB);
                    tempP.Controls.Add(tempB);
                }
                // Declare Price Label
                {
                    Label tempLab = new Label();
                    tempLab.Text = reader.GetString(3);
                    x = label2.Location.X;
                    y = label2.Location.Y;
                    tempLab.Location = new Point(x, y);
                    tempLab.Size = label2.Size;
                    tempLab.Font = label2.Font;
                    tempLab.AutoSize = true;
                    tempP.Controls.Add(tempLab);
                }
                listPanel.Add(tempP);
                flowPanel.Controls.Add(tempP);
                i++;
            }
            reader.Close();
            if (i == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }
        
        private void decline_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id_car = btn.Tag.ToString();
            string query = $"DELETE FROM cart WHERE id_car = {id_car} and id_user = {LoginForm.userID}";
            
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.ExecuteNonQuery();
            flowPanel.Controls.Clear();
            flowPanel.Invalidate();
            flowPanel.Refresh();
            ShowCart();

        }

        private void approve_Click(object sender, EventArgs e)
        {
            string query = $"SELECT COUNT(*) FROM orders";
            MySqlCommand cmd = new MySqlCommand(query, DbConnection.getConn());
            int id_order = int.Parse(cmd.ExecuteScalar().ToString())+1;
            int subtotal = 0;
            for (int i = 0; i < btnDecline.Count; i++)
            {
                query = $"DELETE FROM cart WHERE id_car = {btnDecline[i].Tag}";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.ExecuteNonQuery();
                query = $"UPDATE cars SET car_status = 'Sold' WHERE id_car = {btnDecline[i].Tag}";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.ExecuteNonQuery();
                query = $"INSERT INTO order_item (id_order,id_car) VALUES({id_order},{btnDecline[i].Tag})";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                cmd.ExecuteNonQuery();
                query = $"select car_price from cars where id_car = {btnDecline[i].Tag}";
                cmd = new MySqlCommand(query, DbConnection.getConn());
                subtotal += int.Parse(cmd.ExecuteScalar().ToString());
            }
            DateTime varDateTime = DateTime.Now;
            string date = varDateTime.ToString("yyyy-MM-dd");
            query = $"INSERT INTO orders(id_order,id_user,order_date,order_note,order_subtotal) " +
                    $"VALUES({id_order},{LoginForm.userID},'{date}','{textBox1.Text}',{subtotal})";
            cmd = new MySqlCommand(query, DbConnection.getConn());
            cmd.ExecuteNonQuery();

            flowPanel.Controls.Clear();
            flowPanel.Invalidate();
            MessageBox.Show("Barang sudah berhasil di approve!!!");
        }
    }
}
