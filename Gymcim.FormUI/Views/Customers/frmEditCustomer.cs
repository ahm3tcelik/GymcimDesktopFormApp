using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Customers
{
    public partial class frmEditCustomer : MetroFramework.Forms.MetroForm
    {
        private Customer customer;
        private List<Statistic> stats;
        private List<Schedule> schedules;
        private IScheduleService scheduleService;
        private IStatisticService statisticService;
        private ICustomerService customerService;
        public frmEditCustomer(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            scheduleService = InstanceFactory.GetInstance<IScheduleService>();
            statisticService = InstanceFactory.GetInstance<IStatisticService>();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            BlockUnauthorizedViews();

        }
        private void BlockUnauthorizedViews()
        {
            btnDelete.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editCustomer);
            btnEdit.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editCustomer);
            btnAdd.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editCustomer);
        }
        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void SetData()
        {
            // Customer
            tbxName.Text = customer.CustomerName;
            tbxSurname.Text = customer.CustomerSurname;
            tbxGsm.Text = customer.CustomerGsm;
            tbxDuration.Text = Convert.ToString(customer.Duration);

            // Schedule
            cbxSchedules.DataSource = schedules;
            cbxSchedules.DisplayMember = "ScheduleName";
            cbxSchedules.ValueMember = "ScheduleID";
            cbxSchedules.SelectedValue = customer.ScheduleID;

            // Statistic
            lvlStats.Items.Clear();
            foreach (Statistic st in stats)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(st.StatisticID));
                item.SubItems.Add(st.StatisticDesc);
                item.SubItems.Add(st.StatisticDate.ToShortDateString());
                item.SubItems.Add(Convert.ToString(st.Height));
                item.SubItems.Add(Convert.ToString(st.Kilo));
                item.SubItems.Add(Convert.ToString(st.Shoulder));
                item.SubItems.Add(Convert.ToString(st.Chest));
                item.SubItems.Add(Convert.ToString(st.Arm));
                item.SubItems.Add(Convert.ToString(st.Waist));
                item.SubItems.Add(Convert.ToString(st.Hip));
                item.SubItems.Add(Convert.ToString(st.Calf));
                lvlStats.Items.Add(item);
            }
        }

        private void LoadData()
        {
            stats = statisticService.GetAllByCustomerId(customer.CustomerID);
            schedules = scheduleService.GetAllDistinct();
            customer.Schedule = schedules.Find(e => e.ScheduleID == customer.ScheduleID);

            SetData();
        }
        private void lvlStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationTool.OpenNewTab(new frmAddStats(customer));
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvlStats.SelectedItems.Count < 1)
                return;
            NavigationTool.OpenNewTab(new frmAddStats(customer, stats[lvlStats.SelectedItems[0].Index]));
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvlStats.SelectedItems.Count < 1)
                return;

            Statistic st = stats[lvlStats.SelectedItems[0].Index];
            DialogResult dialogResult = MessageBox.Show(st.StatisticDate.ToShortDateString() + 
                " Tarihli istatistiği silmek istediğinizden emin misiniz?", "İstatistik Sil", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    statisticService.Delete(st, Session.currentUser);
                    lvlStats.Items.RemoveAt(lvlStats.SelectedItems[0].Index);
                    MessageBox.Show("İstatistik başarıyla silindi!", "Başarılı!");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata!");
                }
            }
        }

        private void metroPanel1_Leave(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetDataFromViews();
            try
            {
                ValidationTool.Validate(new CustomerValidator(), customer);
                customerService.Update(customer, Session.currentUser);
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Başarılı!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri güncellenemedi:  " + ex.Message, "Hata!");
            }
        }

        private void GetDataFromViews()
        {
            // Customer
            customer.CustomerName = tbxName.Text.Trim();
            customer.CustomerSurname = tbxSurname.Text.Trim();
            customer.CustomerGsm = tbxGsm.Text.Trim();
            customer.Duration = Convert.ToInt32(tbxDuration.Text.Trim());
            customer.ScheduleID = Convert.ToInt32(cbxSchedules.SelectedValue);
            customer.Schedule = null;
            customer.StarterDate = dtStarter.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
