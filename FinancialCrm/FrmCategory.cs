using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBillForms_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnDashboardForms_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var categories = db.Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = CategoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde eklendi.", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeCategory = db.Categories.Find(id);
            db.Categories.Remove(removeCategory);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sistemden silindi.");
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);
            var categories = db.Categories.Find(id);
            categories.CategoryName = CategoryName;
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde güncellendi.");
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten kategoriler sayfasındasınız.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void btnSpendingForms_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnBankProcessForms_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void btnSettingForms_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
