using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Customers
{
    public partial class frmCustomers : MetroFramework.Forms.MetroForm
    {
        ICustomerService customerService;
        List<Customer> customers;
        public frmCustomers()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            BlockUnauthorizedViews();
        }
        private void BlockUnauthorizedViews()
        {
            btnAdd.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.addCustomer);
            dgvCustomers.Columns["Edit"].Visible = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editCustomer);
            dgvCustomers.Columns["Delete"].Visible = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editCustomer);
        }
        public void LoadCustomers(List<Customer> newList)
        {
            customers = newList;
            tbxCounter.Text = "Satır: " + customers.Count;
            dgvCustomers.Rows.Clear();
            
            foreach (var c in customers)
            {
                var index = dgvCustomers.Rows.Add();
                dgvCustomers.Rows[index].Cells["CustomerID"].Value = c.CustomerID;
                dgvCustomers.Rows[index].Cells["CustomerName"].Value = c.CustomerName;
                dgvCustomers.Rows[index].Cells["CustomerSurname"].Value = c.CustomerSurname;
                dgvCustomers.Rows[index].Cells["CustomerGsm"].Value = c.CustomerGsm;
                dgvCustomers.Rows[index].Cells["DaysLeft"].Value = c.DaysLeft;
                dgvCustomers.Rows[index].Cells["Duration"].Value = c.Duration;
                dgvCustomers.Rows[index].Cells["StarterDate"].Value = c.StarterDate.ToShortDateString();
                dgvCustomers.Rows[index].Cells["EndDate"].Value = c.EndDate.ToShortDateString();
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers(customerService.GetAll(Session.currentUser));
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(customerService.SearchByName(tbxSearch.Text.Trim()));
        }

        private void tbxHome_Click(object sender, EventArgs e)
        {
            NavigationTool.Open(this, new frmHome());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationTool.OpenNewTab(new frmAddCustomer());
            LoadCustomers(customerService.GetAll(Session.currentUser));
        }

        private void dgvCustomers_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCustomers.Columns["Show"].Index && e.RowIndex != -1)
            {
                NavigationTool.OpenNewTab(new frmCustomerDetail(customers[e.RowIndex]));
            }
            else if (e.ColumnIndex == dgvCustomers.Columns["Edit"].Index && e.RowIndex != -1)
            {
                NavigationTool.OpenNewTab(new frmEditCustomer(customers[e.RowIndex]));
                LoadCustomers(customerService.GetAll(Session.currentUser));
            }
            else if (e.ColumnIndex == dgvCustomers.Columns["Delete"].Index && e.RowIndex != -1)
            {
                Customer customer = customers[e.RowIndex];

                DialogResult dialogResult = MessageBox.Show(customer.CustomerName + " " + customer.CustomerSurname +
                    " adlı müşteriyi silmek istediğinizden emin misiniz?", "Müşteri Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Müşteri başarıyla silindi!", "Başarılı!");
                    customerService.Delete(customer, Session.currentUser);
                    customers.Remove(customer);
                    LoadCustomers(customers);
                }
            }
        }
    }
}