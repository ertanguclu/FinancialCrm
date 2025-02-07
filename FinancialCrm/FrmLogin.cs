using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var user = db.Users.FirstOrDefault(x => x.Username == txtUserName.Text && x.Password == txtPassword.Text);
                    if (user != null)
                    {
                        FrmBanks frmBank = new FrmBanks();
                        frmBank.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaştık.Lütfen sistem yöneticisi ile görüşünüz." + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
