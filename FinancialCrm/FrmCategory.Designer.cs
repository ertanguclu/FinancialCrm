namespace FinancialCrm
{
    partial class FrmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingForms = new System.Windows.Forms.Button();
            this.btnDashboardForms = new System.Windows.Forms.Button();
            this.btnBankProcessForms = new System.Windows.Forms.Button();
            this.btnSpendingForms = new System.Windows.Forms.Button();
            this.btnBillForms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(273, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1110, 371);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.btnRemoveCategory);
            this.panel3.Controls.Add(this.btnCreateCategory);
            this.panel3.Controls.Add(this.btnCategoryList);
            this.panel3.Controls.Add(this.txtCategoryName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCategoryId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(273, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 294);
            this.panel3.TabIndex = 7;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(819, 131);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(185, 52);
            this.btnUpdateCategory.TabIndex = 11;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCategory.Location = new System.Drawing.Point(608, 131);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(185, 52);
            this.btnRemoveCategory.TabIndex = 10;
            this.btnRemoveCategory.Text = " Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(379, 131);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(185, 52);
            this.btnCreateCategory.TabIndex = 9;
            this.btnCreateCategory.Text = "Kategori Ekle";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.Silver;
            this.btnCategoryList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryList.Location = new System.Drawing.Point(151, 131);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(185, 52);
            this.btnCategoryList.TabIndex = 8;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(120, 64);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(965, 32);
            this.txtCategoryName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Adı:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryId.Location = new System.Drawing.Point(120, 13);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(965, 32);
            this.txtCategoryId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 75);
            this.panel2.TabIndex = 6;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(47, 100);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(168, 47);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(47, 28);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(168, 47);
            this.btnCategoryForm.TabIndex = 0;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingForms);
            this.panel1.Controls.Add(this.btnDashboardForms);
            this.panel1.Controls.Add(this.btnBankProcessForms);
            this.panel1.Controls.Add(this.btnSpendingForms);
            this.panel1.Controls.Add(this.btnBillForms);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 695);
            this.panel1.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(47, 516);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 47);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettingForms
            // 
            this.btnSettingForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingForms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingForms.ForeColor = System.Drawing.Color.White;
            this.btnSettingForms.Location = new System.Drawing.Point(47, 447);
            this.btnSettingForms.Name = "btnSettingForms";
            this.btnSettingForms.Size = new System.Drawing.Size(168, 47);
            this.btnSettingForms.TabIndex = 6;
            this.btnSettingForms.Text = "Ayarlar";
            this.btnSettingForms.UseVisualStyleBackColor = true;
            this.btnSettingForms.Click += new System.EventHandler(this.btnSettingForms_Click);
            // 
            // btnDashboardForms
            // 
            this.btnDashboardForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForms.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForms.Location = new System.Drawing.Point(47, 378);
            this.btnDashboardForms.Name = "btnDashboardForms";
            this.btnDashboardForms.Size = new System.Drawing.Size(168, 47);
            this.btnDashboardForms.TabIndex = 5;
            this.btnDashboardForms.Text = "Dashboard";
            this.btnDashboardForms.UseVisualStyleBackColor = true;
            this.btnDashboardForms.Click += new System.EventHandler(this.btnDashboardForms_Click);
            // 
            // btnBankProcessForms
            // 
            this.btnBankProcessForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessForms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForms.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessForms.Location = new System.Drawing.Point(47, 307);
            this.btnBankProcessForms.Name = "btnBankProcessForms";
            this.btnBankProcessForms.Size = new System.Drawing.Size(168, 47);
            this.btnBankProcessForms.TabIndex = 4;
            this.btnBankProcessForms.Text = "Banka Haraketleri";
            this.btnBankProcessForms.UseVisualStyleBackColor = true;
            this.btnBankProcessForms.Click += new System.EventHandler(this.btnBankProcessForms_Click);
            // 
            // btnSpendingForms
            // 
            this.btnSpendingForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingForms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingForms.ForeColor = System.Drawing.Color.White;
            this.btnSpendingForms.Location = new System.Drawing.Point(47, 238);
            this.btnSpendingForms.Name = "btnSpendingForms";
            this.btnSpendingForms.Size = new System.Drawing.Size(168, 47);
            this.btnSpendingForms.TabIndex = 3;
            this.btnSpendingForms.Text = "Giderler";
            this.btnSpendingForms.UseVisualStyleBackColor = true;
            this.btnSpendingForms.Click += new System.EventHandler(this.btnSpendingForms_Click);
            // 
            // btnBillForms
            // 
            this.btnBillForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForms.ForeColor = System.Drawing.Color.White;
            this.btnBillForms.Location = new System.Drawing.Point(47, 168);
            this.btnBillForms.Name = "btnBillForms";
            this.btnBillForms.Size = new System.Drawing.Size(168, 47);
            this.btnBillForms.TabIndex = 2;
            this.btnBillForms.Text = "Faturalar";
            this.btnBillForms.UseVisualStyleBackColor = true;
            this.btnBillForms.Click += new System.EventHandler(this.btnBillForms_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 748);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingForms;
        private System.Windows.Forms.Button btnDashboardForms;
        private System.Windows.Forms.Button btnBankProcessForms;
        private System.Windows.Forms.Button btnSpendingForms;
        private System.Windows.Forms.Button btnBillForms;
    }
}