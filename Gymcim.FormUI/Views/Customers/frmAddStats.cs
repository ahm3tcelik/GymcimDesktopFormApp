using Gymcim.Business.Abstract;
using Gymcim.Business.DependencyResolvers.Ninject;
using Gymcim.DataAccess.ValidationRules.FluentValidation;
using Gymcim.Entities.Concrete;
using Gymcim.FormUI.Utilities;
using System;

namespace Gymcim.FormUI.Views.Customers
{
    public partial class frmAddStats : MetroFramework.Forms.MetroForm
    {
        private Statistic statistic;
        private Customer customer;
        private IStatisticService statisticService;
        public frmAddStats(Customer customer, Statistic statistic = null)
        {
            InitializeComponent();
            statisticService = InstanceFactory.GetInstance<IStatisticService>();
            this.statistic = statistic;
            this.customer = customer;
        }
        private void frmAddStats_Load(object sender, EventArgs e)
        {
            if(statistic != null)
            {
                SetData();
            }
        }
        private void SetData()
        {
            //statistic.Customer = customer;
            statistic.CustomerID = customer.CustomerID;
            tbxStatisticDesc.Text = statistic.StatisticDesc;
            dtStatistic.Value = statistic.StatisticDate;
            nudHeight.Value = statistic.Height;
            nudKilo.Value = statistic.Kilo;
            nudChest.Value = statistic.Chest;
            nudShoulder.Value = statistic.Shoulder;
            nudWaist.Value = statistic.Waist;
            nudArm.Value = statistic.Arm;
            nudHip.Value = statistic.Hip;
            nudCalf.Value = statistic.Calf;
        }
        private void GetDataFromViews()
        {
            statistic.StatisticDesc = tbxStatisticDesc.Text.Trim();
            statistic.StatisticDate = dtStatistic.Value;
            statistic.Height = Convert.ToInt32(nudHeight.Value);
            statistic.Kilo = Convert.ToInt32(nudKilo.Value);
            statistic.Chest = Convert.ToInt32(nudChest.Value);
            statistic.Shoulder = Convert.ToInt32(nudShoulder.Value);
            statistic.Waist = Convert.ToInt32(nudWaist.Value);
            statistic.Arm = Convert.ToInt32(nudArm.Value);
            statistic.Hip = Convert.ToInt32(nudHip.Value);
            statistic.Calf = Convert.ToInt32(nudCalf.Value);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(statistic != null) // UPDATE OPERATION
            {
                GetDataFromViews();
                updateStatistic();
            }
            else // CREATE Operation
            {
                statistic = new Statistic { CustomerID = customer.CustomerID };
                GetDataFromViews();
                createStatistic();
            }

        }

        private void updateStatistic()
        {
            try
            {
                ValidationTool.Validate(new StatisticValidator(), statistic);
                statisticService.Update(statistic, Session.currentUser);
                System.Windows.Forms.MessageBox.Show("İstatistik başarıyla güncellendi!", "Başarılı!");
                this.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("İstatistik güncellenirken bir hata oluştu. '" + ex.Message + "'", "Hata!");
            }
        }

        private void createStatistic()
        {
            try
            {
                statistic.Customer = null;
                ValidationTool.Validate(new StatisticValidator(), statistic);
                statisticService.Add(statistic, Session.currentUser);
                System.Windows.Forms.MessageBox.Show("İstatistik başarıyla eklendi!", "Başarılı!");
                this.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("İstatistik eklenirken bir hata oluştu. '" + ex.Message + "'", "Hata!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
