using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.Business.Utilities;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class frmSchedules : MetroFramework.Forms.MetroForm
    {
        IScheduleService scheduleService;
        List<Schedule> schedules;
        public frmSchedules()
        {
            InitializeComponent();
            scheduleService = InstanceFactory.GetInstance<IScheduleService>();
            BlockUnauthorizedViews();
        }
        private void BlockUnauthorizedViews()
        {
            btnAdd.Enabled = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.addSchedule);
            dgvSchedules.Columns["Edit"].Visible = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.editSchedule);
            dgvSchedules.Columns["Delete"].Visible = PermissionHelper.CheckPermission(Session.currentUser, PermissionHelper.delSchedule);
        }
        public void LoadSchedules(List<Schedule> newList)
        {
            schedules = newList;
            tbxCounter.Text = "Satır: " + schedules.Count;
            dgvSchedules.Rows.Clear();

            foreach (var s in schedules)
            {
                var index = dgvSchedules.Rows.Add();
                dgvSchedules.Rows[index].Cells["ScheduleID"].Value = s.ScheduleID;
                dgvSchedules.Rows[index].Cells["ScheduleName"].Value = s.ScheduleName;
                dgvSchedules.Rows[index].Cells["ScheduleDesc"].Value = s.ScheduleDesc;
            }
        }

        private void frmSchedules_Load(object sender, System.EventArgs e)
        {
            LoadSchedules(scheduleService.GetAll(Session.currentUser));
        }
        private void tbxHome_Click(object sender, System.EventArgs e)
        {
            NavigationTool.Open(this, new frmHome());
        }

        private void tbxSearch_TextChanged(object sender, System.EventArgs e)
        {
            if(tbxSearch.Text.Trim() == "")
            {
                LoadSchedules(scheduleService.GetAll(Session.currentUser));
            }
            else
            {
                LoadSchedules(scheduleService.SearchByNameAndDesc(tbxSearch.Text.Trim()));
            }
        }

        private void dgvSchedules_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSchedules.Columns["Show"].Index && e.RowIndex != -1)
            {
                NavigationTool.OpenNewTab(new frmScheduleDetail(schedules[e.RowIndex]));
            }
            else if (e.ColumnIndex == dgvSchedules.Columns["Edit"].Index && e.RowIndex != -1)
            {
                NavigationTool.OpenNewTab(new frmEditSchedule(schedules[e.RowIndex]));
                LoadSchedules(scheduleService.GetAll(Session.currentUser));
            }
            else if (e.ColumnIndex == dgvSchedules.Columns["Delete"].Index && e.RowIndex != -1)
            {
                Schedule schedule = schedules[e.RowIndex];

                DialogResult dialogResult = MessageBox.Show(schedule.ScheduleName +
                    " adlı programı silmek istediğinizden emin misiniz?", "Programı Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        scheduleService.Delete(schedule, Session.currentUser);
                        MessageBox.Show("Program başarıyla silindi!", "Başarılı!");
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata!");
                    }
                    schedules.Remove(schedule);
                    LoadSchedules(schedules);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavigationTool.OpenNewTab(new frmAddSchedule());
            LoadSchedules(scheduleService.GetAll(Session.currentUser));
        }
    }
}
