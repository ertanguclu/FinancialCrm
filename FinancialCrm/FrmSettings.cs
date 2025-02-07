using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                var userUpdate = db.Users.SingleOrDefault(x => x.Username == userName);
                if (userUpdate != null)
                {
                    if (txtPassword.Text == txtPasswordAgain.Text)
                    {
                        userUpdate.Password = txtPasswordAgain.Text;
                        db.SaveChanges();
                        MessageBox.Show("Güncelleme Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtPasswordAgain.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz şifreler eşleşmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Clear();
                        txtPasswordAgain.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistemsel Bir Hata Oluştu! Lütfen sistem yöneticisine başvurunuz" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
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

        private void btnBillsForms_Click(object sender, EventArgs e)
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
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
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
            MessageBox.Show("Zaten ayarlar sayfasındasınız.", "Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
