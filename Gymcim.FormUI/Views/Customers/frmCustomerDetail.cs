using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Customers
{
    public partial class frmCustomerDetail : MetroFramework.Forms.MetroForm
    {
        private Customer customer;
        private List<Statistic> stats;
        private IScheduleService scheduleService;
        private IStatisticService statisticService;
        public frmCustomerDetail(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            scheduleService = InstanceFactory.GetInstance<IScheduleService>();
            statisticService = InstanceFactory.GetInstance<IStatisticService>();
        }
        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            LoadData();
            SetData();
        }
        private void LoadData()
        {
            stats = statisticService.GetAllByCustomerId(customer.CustomerID);
            customer.Schedule = scheduleService.GetById(customer.ScheduleID);
        }
        private void SetData()
        {
            // Customer
            tbxName.Text = customer.CustomerName;
            tbxSurname.Text = customer.CustomerSurname;
            tbxGsm.Text = customer.CustomerGsm;
            tbxDaysLeft.Text = Convert.ToString(customer.DaysLeft);
            tbxDuration.Text = Convert.ToString(customer.Duration);

            // Schedule
            tbxScheduleID.Text = Convert.ToString(customer.Schedule.ScheduleID);
            tbxScheduleName.Text = customer.Schedule.ScheduleName;
            rtbxScheduleDesc.Text = customer.Schedule.ScheduleDesc;

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
    }
}
