using Gymcim.Business.Concrete;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Views.Logs
{
    public partial class frmLogs : MetroFramework.Forms.MetroForm
    {
        List<Log> logs;

        public frmLogs()
        {
            InitializeComponent();
        }
        private void LoadLogEvents()
        {
            cbxEvents.Items.Clear();
            cbxEvents.Items.Add("Tümü");
            LogManager.GetEvents().ForEach(e => cbxEvents.Items.Add(e));
        }

        private void LoadLogs(List<Log> newLogs)
        {
            logs = newLogs;
            tbxCounter.Text = "Satır: " + logs.Count;
            lvLogs.Items.Clear();

            foreach (Log log in logs) {

                ListViewItem item = new ListViewItem(Convert.ToString(log.LogID));
                item.SubItems.Add(log.LogMessage);
                item.SubItems.Add(log.LogDate.ToString());
                item.SubItems.Add(log.LogEvent);
                lvLogs.Items.Add(item);
            }
            lvLogs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            LoadLogs(LogManager.GetAll(Session.currentUser));
            LoadLogEvents();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLogs(LogManager.SearchByMessage(tbxSearch.Text.Trim(), Session.currentUser));
        }

        private void tbxHome_Click(object sender, EventArgs e)
        {
            NavigationTool.Open(this, new frmHome());
        }

        private void cbxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxEvents.Text != "Tümü")
            {
                LoadLogs(LogManager.GetByEvent(cbxEvents.Text, Session.currentUser));
            }
            else
            {
                LoadLogs(LogManager.GetAll(Session.currentUser));
            }

        }
    }
}
