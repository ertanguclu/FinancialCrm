using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var spendings = db.Spendings.Select(s => new
            {
                s.SpendingId,
                s.SpendingTitle,
                s.SpendingAmount,
                s.SpendingDate,
                CategoryName = s.Categories.CategoryName
            })
                      .ToList();
            dataGridView1.DataSource = spendings;
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var spendings = db.Spendings.ToList();
            dataGridView1.DataSource = spendings;
        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string spendingTitle = txtSpendingTitle.Text;
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime spendingDate = DateTime.Parse(txtSpendingDate.Text);
            Spendings spendings = new Spendings();
            spendings.SpendingTitle = spendingTitle;
            spendings.CategoryId = categoryId;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = spendingDate;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde eklendi.", "Harcama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeSpending = db.Spendings.Find(id);
            db.Spendings.Remove(removeSpending);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde silindi.");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            string spendingTitle = txtSpendingTitle.Text;
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime spendingDate = DateTime.Parse(txtSpendingDate.Text);
            int id = int.Parse(txtSpendingId.Text);
            var spendings = db.Spendings.Find(id);
            spendings.SpendingTitle = spendingTitle;
            spendings.CategoryId = categoryId;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = spendingDate;
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde güncellendi.");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten giderler sayfasındasınız..", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }
    }
}
