using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OP_Car_Dealer.DealerFormPanels;

namespace OP_Car_Dealer
{
    public partial class DealerForm : Form
    {
        private Form activeForm;
        private List<Control> navButtonList;
        private int activeNavButton = -1;

        public DealerForm()
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
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            if (activeForm != null) activeForm.Close();
            activeForm = childForm;

            mainPanel.Controls.Add(activeForm);
            mainPanel.Tag = activeForm;

            childForm.BringToFront();
            activeForm.Show();
            mainPanel.Refresh();
        }

        private void catalogNavButton_Click(object sender, EventArgs e)
        {
            DealerCatalogForm catalogForm = new DealerCatalogForm();
            showChildForm(catalogForm);
            activateNavButton(sender);
        }

        private void ordersNavButton_Click(object sender, EventArgs e)
        {
            DealerOrdersForm ordersForm = new DealerOrdersForm();
            showChildForm(ordersForm);
            activateNavButton(sender);
        }

        private void transactionsNavButton_Click(object sender, EventArgs e)
        {
            DealerTransactionsForm transactionsForm = new DealerTransactionsForm();
            showChildForm(transactionsForm);
            activateNavButton(sender);
        }

        private void inspectionsNavButton_Click(object sender, EventArgs e)
        {
            DealerInspectionsForm inspectionsForm = new DealerInspectionsForm();
            showChildForm(inspectionsForm);
            activateNavButton(sender);
        }

        private void reportsNavButton_Click(object sender, EventArgs e)
        {
            DealerReportsForm reportsForm = new DealerReportsForm();
            showChildForm(reportsForm);
            activateNavButton(sender);
        }
    }
}
