using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ADBMSpro01
{
    public partial class Dashboard : Form
    {
        public static string user = null;
        public static string privilage = null;

        //set empty
        private Form activeForm = null;
        public Dashboard()
        {
            InitializeComponent();
            custermizeDesign();
        }

        //set non-visiblility of sub menu.
        private void custermizeDesign()
        {
            SalesSubPanel.Visible = false;
            EmployeeSubPanel.Visible = false;
            MarketingSubPanel.Visible = false;
        }

        //set hide sub menu.
        private void hideSubMenu()
        {
            if (SalesSubPanel.Visible == true)
                SalesSubPanel.Visible = false;
            if (EmployeeSubPanel.Visible == true)
                EmployeeSubPanel.Visible = false;
            if (MarketingSubPanel.Visible == true)
                MarketingSubPanel.Visible = false;
        }

        //set show sub menu.
        private void showSubMenu(Panel SubPanel)
        {
            if (SubPanel.Visible == false)
            {
                hideSubMenu();
                SubPanel.Visible = true;
            }
            else
            {
                SubPanel.Visible = false;
            }
        }

        //set forms to panel.
        private void openFormPanel(Form formPanel)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formPanel;
            formPanel.TopLevel = false;
            formPanel.FormBorderStyle = FormBorderStyle.None;
            formPanel.Dock = DockStyle.Fill;
            FormLoadPanel.Controls.Add(formPanel);
            FormLoadPanel.Tag = formPanel;
            formPanel.BringToFront();
            formPanel.Show();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //get name and privilage from login.
            user = Login.Uname;
            privilage = Login.Uprivilage;
            //get date.
            DateTime today = DateTime.Today;

            //set user name and date
            UserNamelbl.Text = user;
            Datelbl.Text = today.ToString("dd/MM/yyyy");

            openFormPanel(new DashboardForm());
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void RevenuePBox_Click(object sender, EventArgs e)
        {

        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(SalesSubPanel);
        }

        private void RevenueBtn_Click(object sender, EventArgs e)
        {
            openFormPanel(new RevenueForm());
            hideSubMenu();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(EmployeeSubPanel);
        }

        private void MarketingBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(MarketingSubPanel);
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            openFormPanel(new DashboardForm());
            hideSubMenu();
        }

        private void SalesDetailsBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "sales" || privilage == "marketing")
            {
                openFormPanel(new SalesDetailsForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
        }

        private void AddSalesBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "sales")
            {
                openFormPanel(new SalesAddForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }

        private void EmployeeDetailsBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "sales" || privilage == "marketing" || privilage == "hr")
            {
                openFormPanel(new EmployeeDetailsForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }

        private void DeactivateBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "hr")
            {
                openFormPanel(new EmployeeDeacvtivateForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "hr")
            {
                openFormPanel(new EmployeeAddForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }

        private void MarketingDetailsBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "sales" || privilage == "marketing")
            {
                openFormPanel(new MarketingDetailsForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }

        private void AddMarketingBtn_Click(object sender, EventArgs e)
        {
            if (privilage == "admin" || privilage == "marketing")
            {
                openFormPanel(new MarketingAddForm());
            }
            else
            {
                MessageBox.Show("You have no Authorization");
            }
            
        }
    }
}
