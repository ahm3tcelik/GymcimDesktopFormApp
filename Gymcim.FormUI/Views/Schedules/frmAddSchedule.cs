using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class frmAddSchedule : MetroFramework.Forms.MetroForm
    {
        private Schedule schedule = new Schedule();
        private IScheduleService scheduleService;
        public frmAddSchedule()
        {
            InitializeComponent();
            scheduleService = InstanceFactory.GetInstance<IScheduleService>();
        }

        private void frmAddSchedule_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            schedule.ScheduleName = tbxName.Text.Trim();
            schedule.ScheduleDesc = rTbxDesc.Text.Trim();
            try
            {
                ValidationTool.Validate(new ScheduleValidator(), schedule);
                scheduleService.Add(schedule, Session.currentUser);
                MessageBox.Show("Çalışma Programı başarıyla oluşturuldu.", "Başarılı!");
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
