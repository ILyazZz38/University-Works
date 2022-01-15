
namespace MSSQLClientContractsForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.BossSearch = new System.Windows.Forms.TextBox();
            this.AddressSearch = new System.Windows.Forms.TextBox();
            this.OrgNameSearch = new System.Windows.Forms.TextBox();
            this.SumSearch = new System.Windows.Forms.TextBox();
            this.DateSearch = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.BossLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.OrgNameLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientData = new System.Windows.Forms.DataGridView();
            this.ContractData = new System.Windows.Forms.DataGridView();
            this.AddChangePage = new System.Windows.Forms.TabPage();
            this.ChangeContractButton = new System.Windows.Forms.Button();
            this.AddContractButton = new System.Windows.Forms.Button();
            this.ChangeClientButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.DateEdit = new System.Windows.Forms.DateTimePicker();
            this.DateEditLabel = new System.Windows.Forms.Label();
            this.SumEditLabel = new System.Windows.Forms.Label();
            this.BossEdit = new System.Windows.Forms.TextBox();
            this.AddressEdit = new System.Windows.Forms.TextBox();
            this.OrgNameEdit = new System.Windows.Forms.TextBox();
            this.BossEditLabel = new System.Windows.Forms.Label();
            this.AddressEditLabel = new System.Windows.Forms.Label();
            this.OrgNameEditLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContractDataEdit = new System.Windows.Forms.DataGridView();
            this.ClientDataEdit = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractData)).BeginInit();
            this.AddChangePage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SearchPage);
            this.tabControl.Controls.Add(this.AddChangePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 681);
            this.tabControl.TabIndex = 0;
            // 
            // SearchPage
            // 
            this.SearchPage.BackColor = System.Drawing.Color.Transparent;
            this.SearchPage.Controls.Add(this.BossSearch);
            this.SearchPage.Controls.Add(this.AddressSearch);
            this.SearchPage.Controls.Add(this.OrgNameSearch);
            this.SearchPage.Controls.Add(this.SumSearch);
            this.SearchPage.Controls.Add(this.DateSearch);
            this.SearchPage.Controls.Add(this.DateLabel);
            this.SearchPage.Controls.Add(this.SumLabel);
            this.SearchPage.Controls.Add(this.BossLabel);
            this.SearchPage.Controls.Add(this.AddressLabel);
            this.SearchPage.Controls.Add(this.OrgNameLable);
            this.SearchPage.Controls.Add(this.tableLayoutPanel1);
            this.SearchPage.Location = new System.Drawing.Point(4, 22);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchPage.Size = new System.Drawing.Size(1256, 655);
            this.SearchPage.TabIndex = 0;
            this.SearchPage.Text = "Поиск";
            // 
            // BossSearch
            // 
            this.BossSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BossSearch.Location = new System.Drawing.Point(190, 579);
            this.BossSearch.Name = "BossSearch";
            this.BossSearch.Size = new System.Drawing.Size(304, 29);
            this.BossSearch.TabIndex = 10;
            this.BossSearch.TextChanged += new System.EventHandler(this.BossSearch_TextChanged);
            // 
            // AddressSearch
            // 
            this.AddressSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressSearch.Location = new System.Drawing.Point(190, 544);
            this.AddressSearch.Name = "AddressSearch";
            this.AddressSearch.Size = new System.Drawing.Size(304, 29);
            this.AddressSearch.TabIndex = 9;
            this.AddressSearch.TextChanged += new System.EventHandler(this.AddressSearch_TextChanged);
            // 
            // OrgNameSearch
            // 
            this.OrgNameSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgNameSearch.Location = new System.Drawing.Point(190, 509);
            this.OrgNameSearch.Name = "OrgNameSearch";
            this.OrgNameSearch.Size = new System.Drawing.Size(304, 29);
            this.OrgNameSearch.TabIndex = 8;
            this.OrgNameSearch.TextChanged += new System.EventHandler(this.OrgNameSearch_TextChanged);
            // 
            // SumSearch
            // 
            this.SumSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumSearch.Location = new System.Drawing.Point(705, 509);
            this.SumSearch.Name = "SumSearch";
            this.SumSearch.ReadOnly = true;
            this.SumSearch.Size = new System.Drawing.Size(243, 29);
            this.SumSearch.TabIndex = 7;
            this.SumSearch.TextChanged += new System.EventHandler(this.SumSearch_TextChanged);
            // 
            // DateSearch
            // 
            this.DateSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateSearch.Location = new System.Drawing.Point(705, 544);
            this.DateSearch.Name = "DateSearch";
            this.DateSearch.Size = new System.Drawing.Size(243, 29);
            this.DateSearch.TabIndex = 6;
            this.DateSearch.ValueChanged += new System.EventHandler(this.DateSearch_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(627, 547);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(47, 21);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Дата";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(627, 512);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(64, 21);
            this.SumLabel.TabIndex = 4;
            this.SumLabel.Text = "Сумма";
            // 
            // BossLabel
            // 
            this.BossLabel.AutoSize = true;
            this.BossLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BossLabel.Location = new System.Drawing.Point(8, 582);
            this.BossLabel.Name = "BossLabel";
            this.BossLabel.Size = new System.Drawing.Size(120, 21);
            this.BossLabel.TabIndex = 3;
            this.BossLabel.Text = "Руководитель";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(8, 547);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 21);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Адрес";
            // 
            // OrgNameLable
            // 
            this.OrgNameLable.AutoSize = true;
            this.OrgNameLable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgNameLable.Location = new System.Drawing.Point(8, 512);
            this.OrgNameLable.Name = "OrgNameLable";
            this.OrgNameLable.Size = new System.Drawing.Size(115, 21);
            this.OrgNameLable.TabIndex = 1;
            this.OrgNameLable.Text = "Организация";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ClientData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContractData, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClientData
            // 
            this.ClientData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientData.Location = new System.Drawing.Point(3, 3);
            this.ClientData.Name = "ClientData";
            this.ClientData.Size = new System.Drawing.Size(619, 448);
            this.ClientData.TabIndex = 0;
            this.ClientData.Click += new System.EventHandler(this.ClientData_Click);
            // 
            // ContractData
            // 
            this.ContractData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContractData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractData.Location = new System.Drawing.Point(628, 3);
            this.ContractData.Name = "ContractData";
            this.ContractData.Size = new System.Drawing.Size(619, 448);
            this.ContractData.TabIndex = 1;
            // 
            // AddChangePage
            // 
            this.AddChangePage.BackColor = System.Drawing.Color.Transparent;
            this.AddChangePage.Controls.Add(this.ChangeContractButton);
            this.AddChangePage.Controls.Add(this.AddContractButton);
            this.AddChangePage.Controls.Add(this.ChangeClientButton);
            this.AddChangePage.Controls.Add(this.AddClientButton);
            this.AddChangePage.Controls.Add(this.SumEdit);
            this.AddChangePage.Controls.Add(this.DateEdit);
            this.AddChangePage.Controls.Add(this.DateEditLabel);
            this.AddChangePage.Controls.Add(this.SumEditLabel);
            this.AddChangePage.Controls.Add(this.BossEdit);
            this.AddChangePage.Controls.Add(this.AddressEdit);
            this.AddChangePage.Controls.Add(this.OrgNameEdit);
            this.AddChangePage.Controls.Add(this.BossEditLabel);
            this.AddChangePage.Controls.Add(this.AddressEditLabel);
            this.AddChangePage.Controls.Add(this.OrgNameEditLabel);
            this.AddChangePage.Controls.Add(this.tableLayoutPanel2);
            this.AddChangePage.Location = new System.Drawing.Point(4, 22);
            this.AddChangePage.Name = "AddChangePage";
            this.AddChangePage.Padding = new System.Windows.Forms.Padding(3);
            this.AddChangePage.Size = new System.Drawing.Size(1256, 655);
            this.AddChangePage.TabIndex = 1;
            this.AddChangePage.Text = "Добавить/Изменить";
            // 
            // ChangeContractButton
            // 
            this.ChangeContractButton.Enabled = false;
            this.ChangeContractButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeContractButton.Location = new System.Drawing.Point(1147, 601);
            this.ChangeContractButton.Name = "ChangeContractButton";
            this.ChangeContractButton.Size = new System.Drawing.Size(101, 32);
            this.ChangeContractButton.TabIndex = 24;
            this.ChangeContractButton.Text = "Change";
            this.ChangeContractButton.UseVisualStyleBackColor = true;
            this.ChangeContractButton.Click += new System.EventHandler(this.ChangeContractButton_Click);
            // 
            // AddContractButton
            // 
            this.AddContractButton.Enabled = false;
            this.AddContractButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddContractButton.Location = new System.Drawing.Point(1147, 563);
            this.AddContractButton.Name = "AddContractButton";
            this.AddContractButton.Size = new System.Drawing.Size(101, 32);
            this.AddContractButton.TabIndex = 23;
            this.AddContractButton.Text = "Add";
            this.AddContractButton.UseVisualStyleBackColor = true;
            this.AddContractButton.Click += new System.EventHandler(this.AddContractButton_Click);
            // 
            // ChangeClientButton
            // 
            this.ChangeClientButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeClientButton.Location = new System.Drawing.Point(500, 601);
            this.ChangeClientButton.Name = "ChangeClientButton";
            this.ChangeClientButton.Size = new System.Drawing.Size(101, 32);
            this.ChangeClientButton.TabIndex = 22;
            this.ChangeClientButton.Text = "Change";
            this.ChangeClientButton.UseVisualStyleBackColor = true;
            this.ChangeClientButton.Click += new System.EventHandler(this.ChangeClientButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClientButton.Location = new System.Drawing.Point(393, 601);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(101, 32);
            this.AddClientButton.TabIndex = 21;
            this.AddClientButton.Text = "Add";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // SumEdit
            // 
            this.SumEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumEdit.Location = new System.Drawing.Point(705, 483);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(326, 29);
            this.SumEdit.TabIndex = 20;
            // 
            // DateEdit
            // 
            this.DateEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEdit.Location = new System.Drawing.Point(705, 518);
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.Size = new System.Drawing.Size(326, 29);
            this.DateEdit.TabIndex = 19;
            // 
            // DateEditLabel
            // 
            this.DateEditLabel.AutoSize = true;
            this.DateEditLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEditLabel.Location = new System.Drawing.Point(627, 521);
            this.DateEditLabel.Name = "DateEditLabel";
            this.DateEditLabel.Size = new System.Drawing.Size(47, 21);
            this.DateEditLabel.TabIndex = 18;
            this.DateEditLabel.Text = "Дата";
            // 
            // SumEditLabel
            // 
            this.SumEditLabel.AutoSize = true;
            this.SumEditLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumEditLabel.Location = new System.Drawing.Point(627, 486);
            this.SumEditLabel.Name = "SumEditLabel";
            this.SumEditLabel.Size = new System.Drawing.Size(64, 21);
            this.SumEditLabel.TabIndex = 17;
            this.SumEditLabel.Text = "Сумма";
            // 
            // BossEdit
            // 
            this.BossEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BossEdit.Location = new System.Drawing.Point(190, 553);
            this.BossEdit.Name = "BossEdit";
            this.BossEdit.Size = new System.Drawing.Size(304, 29);
            this.BossEdit.TabIndex = 16;
            // 
            // AddressEdit
            // 
            this.AddressEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressEdit.Location = new System.Drawing.Point(190, 518);
            this.AddressEdit.Name = "AddressEdit";
            this.AddressEdit.Size = new System.Drawing.Size(304, 29);
            this.AddressEdit.TabIndex = 15;
            // 
            // OrgNameEdit
            // 
            this.OrgNameEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgNameEdit.Location = new System.Drawing.Point(190, 483);
            this.OrgNameEdit.Name = "OrgNameEdit";
            this.OrgNameEdit.Size = new System.Drawing.Size(304, 29);
            this.OrgNameEdit.TabIndex = 14;
            // 
            // BossEditLabel
            // 
            this.BossEditLabel.AutoSize = true;
            this.BossEditLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BossEditLabel.Location = new System.Drawing.Point(8, 556);
            this.BossEditLabel.Name = "BossEditLabel";
            this.BossEditLabel.Size = new System.Drawing.Size(120, 21);
            this.BossEditLabel.TabIndex = 13;
            this.BossEditLabel.Text = "Руководитель";
            // 
            // AddressEditLabel
            // 
            this.AddressEditLabel.AutoSize = true;
            this.AddressEditLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressEditLabel.Location = new System.Drawing.Point(8, 521);
            this.AddressEditLabel.Name = "AddressEditLabel";
            this.AddressEditLabel.Size = new System.Drawing.Size(60, 21);
            this.AddressEditLabel.TabIndex = 12;
            this.AddressEditLabel.Text = "Адрес";
            // 
            // OrgNameEditLabel
            // 
            this.OrgNameEditLabel.AutoSize = true;
            this.OrgNameEditLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgNameEditLabel.Location = new System.Drawing.Point(8, 486);
            this.OrgNameEditLabel.Name = "OrgNameEditLabel";
            this.OrgNameEditLabel.Size = new System.Drawing.Size(115, 21);
            this.OrgNameEditLabel.TabIndex = 11;
            this.OrgNameEditLabel.Text = "Организация";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ContractDataEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClientDataEdit, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1250, 416);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ContractDataEdit
            // 
            this.ContractDataEdit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContractDataEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractDataEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractDataEdit.Location = new System.Drawing.Point(628, 3);
            this.ContractDataEdit.Name = "ContractDataEdit";
            this.ContractDataEdit.Size = new System.Drawing.Size(619, 410);
            this.ContractDataEdit.TabIndex = 2;
            this.ContractDataEdit.Click += new System.EventHandler(this.ContractDataEdit_Click);
            // 
            // ClientDataEdit
            // 
            this.ClientDataEdit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientDataEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientDataEdit.Location = new System.Drawing.Point(3, 3);
            this.ClientDataEdit.Name = "ClientDataEdit";
            this.ClientDataEdit.ReadOnly = true;
            this.ClientDataEdit.Size = new System.Drawing.Size(619, 410);
            this.ClientDataEdit.TabIndex = 1;
            this.ClientDataEdit.Click += new System.EventHandler(this.ClientDataEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractData)).EndInit();
            this.AddChangePage.ResumeLayout(false);
            this.AddChangePage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage AddChangePage;
        private System.Windows.Forms.DataGridView ContractData;
        private System.Windows.Forms.DataGridView ClientData;
        private System.Windows.Forms.TextBox BossSearch;
        private System.Windows.Forms.TextBox AddressSearch;
        private System.Windows.Forms.TextBox OrgNameSearch;
        private System.Windows.Forms.TextBox SumSearch;
        private System.Windows.Forms.DateTimePicker DateSearch;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label BossLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label OrgNameLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ClientDataEdit;
        private System.Windows.Forms.DataGridView ContractDataEdit;
        private System.Windows.Forms.TextBox BossEdit;
        private System.Windows.Forms.TextBox AddressEdit;
        private System.Windows.Forms.TextBox OrgNameEdit;
        private System.Windows.Forms.Label BossEditLabel;
        private System.Windows.Forms.Label AddressEditLabel;
        private System.Windows.Forms.Label OrgNameEditLabel;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.DateTimePicker DateEdit;
        private System.Windows.Forms.Label DateEditLabel;
        private System.Windows.Forms.Label SumEditLabel;
        private System.Windows.Forms.Button ChangeContractButton;
        private System.Windows.Forms.Button AddContractButton;
        private System.Windows.Forms.Button ChangeClientButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

