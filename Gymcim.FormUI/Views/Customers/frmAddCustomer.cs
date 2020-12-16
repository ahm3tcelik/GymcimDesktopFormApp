using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Customers
{
    public partial class frmAddCustomer : MetroFramework.Forms.MetroForm
    {
        private ICustomerService customerService;
        private IScheduleService scheduleService;
        private List<Schedule> schedules;

        public frmAddCustomer()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            scheduleService = InstanceFactory.GetInstance<IScheduleService>();

        }
        private void LoadSchedules()
        {
            schedules = scheduleService.GetAllDistinct();
            cbxSchedules.DataSource = schedules;
            cbxSchedules.DisplayMember = "ScheduleName";
            cbxSchedules.ValueMember = "ScheduleID";
        }

        private void clearForm()
        {
            tbxName.Text = "";
            tbxSurname.Text = "";
            tbxGsm.Text = "";
            tbxDuration.Text = "";
            dtStarter.Value = DateTime.Now;
        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                Customer customer = new Customer {
                    CustomerName = tbxName.Text.Trim(),
                    CustomerSurname = tbxSurname.Text.Trim(),
                    CustomerGsm = tbxGsm.Text.Trim(),
                    Duration = Convert.ToInt32(tbxDuration.Text.Trim()),
                    StarterDate = dtStarter.Value,
                    ScheduleID = Convert.ToInt32(cbxSchedules.SelectedValue)
                };
                ValidationTool.Validate(new CustomerValidator(), customer);
                clearForm();
                customerService.Add(customer, Session.currentUser);
                MessageBox.Show("'" + customer.CustomerName + " " + customer.CustomerSurname + "' başarıyla eklendi.", "Başarılı!");

            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
