using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var values = (from bp in db.BankProcesses
                          join b in db.Banks on bp.BankId equals b.BankaId
                          select new
                          {
                              bp.BankProcessId,
                              bp.Description,
                              BankName = b.BankTitle,
                              bp.Amount,
                              bp.ProcessDate
                          }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Banka İşlemleri sayfasındasınız.", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
    }
}
