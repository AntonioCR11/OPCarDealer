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
    public partial class DealerTransactionsForm : Form
    {
        DataTable transData;
        public DealerTransactionsForm()
        {
            InitializeComponent();
            setDGV();
        }
        public void setDGV()
        {
            transData = new DataTable();
            string query = "select id_order, order_date as 'Date',order_note as 'Note',concat('Rp ',format(order_subtotal,0)) as 'Subtotal' from orders " +
                           $"where id_user = {LoginForm.userID}";
            MySqlCommand cmd = new MySqlCommand(query,DbConnection.getConn());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(transData);
            transDataGridView.DataSource = null;
            transDataGridView.DataSource = transData;
        }

        private void transDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = transDataGridView.Rows[e.RowIndex];
            Order_Item.OrderedItem gimang = new Order_Item.OrderedItem(dgvr.Cells[0].Value.ToString());
            gimang.ShowDialog();
        }
    }
}
