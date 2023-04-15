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

namespace OP_Car_Dealer.DealerFormPanels.Order_Item
{
    public partial class OrderedItem : Form
    {
        public OrderedItem(string id_order)
        {
            InitializeComponent();
            initFlowPanel(id_order);
        }

        public void initFlowPanel(string id_order)
        {
            int i = 0;
            string query = "SELECT CONCAT(crs.car_brand,' ',crs.car_model,' ',car_type,' ',car_name),crs.id_car, " +
                           "concat('Rp. ',format(crs.car_price,0))" +
                           "FROM order_item o "+
                           "JOIN cars crs ON crs.id_car = o.id_car "+
                           $"WHERE o.id_order = {id_order}";
            MySqlCommand cmd = new MySqlCommand(query,DbConnection.getConn());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
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
                tempP.Location = new Point(x, y + (i * y) + 10);
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
                    picLocation += $@"\Assets\Cars\car_{reader.GetString(1)}.jpg";
                    tempL.Image = Image.FromFile(picLocation);
                    tempL.SizeMode = PictureBoxSizeMode.StretchImage;
                    tempL.Location = new Point(x, y);
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
                    tempP.Controls.Add(tempLab);
                }
                // Declare Price Label
                {
                    Label tempLab = new Label();
                    tempLab.Text = reader.GetString(2);
                    x = label1.Location.X;
                    y = label1.Location.Y;
                    tempLab.Location = new Point(x, y);
                    tempLab.Size = label1.Size;
                    tempLab.Font = label1.Font;
                    tempLab.AutoSize = true;
                    tempP.Controls.Add(tempLab);
                }
                flowPanel.Controls.Add(tempP);
            }
            reader.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
