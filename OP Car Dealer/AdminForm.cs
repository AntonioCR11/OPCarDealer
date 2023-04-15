using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OP_Car_Dealer.AdminFormPanels;
using OP_Car_Dealer.DealerFormPanels;

namespace OP_Car_Dealer
{
    public partial class AdminForm : Form
    {
        private Form activeForm;
        private List<Control> navButtonList;
        private int activeNavButton = -1;
        public AdminForm()
        {
            InitializeComponent();
            // Add navigation effect
            navButtonList = new List<Control>();
            foreach (Control navButton in sidebarPanel.Controls)
            {
                if (navButton is Button) navButtonList.Add(navButton);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activateNavButton(object sender)
        {
            // Reset the active nav Button
            if (activeNavButton >= 0)
                navButtonList[activeNavButton].BackColor = navButtonList[activeNavButton].Parent.BackColor;

            // Get the pressed button index
            int index = navButtonList.IndexOf((Control)sender);
            navButtonList[index].BackColor = Color.FromArgb(120, 120, 120);

            activeNavButton = index;
        }

        private void showChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;

            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            activeForm.Show();

            contentPanel.Controls.Add(activeForm);
            contentPanel.Refresh();
        }

        private void registerNavButton_Click(object sender, EventArgs e)
        {
            AdminRegisterForm registerForm = new AdminRegisterForm();
            showChildForm(registerForm);
            activateNavButton(sender);
        }

        private void brandNavButton_Click(object sender, EventArgs e)
        {
            AdminBrandForm brandForm = new AdminBrandForm();
            showChildForm(brandForm);
            activateNavButton(sender);
        }

        private void mobilNavButton_Click(object sender, EventArgs e)
        {
            AdminCarsForm carsForm = new AdminCarsForm();
            showChildForm(carsForm);
            activateNavButton(sender);
        }

        private void transactionsNavButton_Click(object sender, EventArgs e)
        {
            AdminTransactionsForm transactionsForm = new AdminTransactionsForm();
            showChildForm(transactionsForm);
            activateNavButton(sender);
        }

        private void ordersNavButton_Click(object sender, EventArgs e)
        {
            AdminOrdersForm pesananForm = new AdminOrdersForm();
            showChildForm(pesananForm);
            activateNavButton(sender);
        }

        private void reportNavButton_Click(object sender, EventArgs e)
        {
            DealerReportsForm reportsForm = new DealerReportsForm();
            showChildForm(reportsForm);
            activateNavButton(sender);
        }

        private void inboxButton_Click(object sender, EventArgs e)
        {
            AdminInboxForm inboxForm = new AdminInboxForm();
            showChildForm(inboxForm);
            activateNavButton(sender);
        }
    }
}
