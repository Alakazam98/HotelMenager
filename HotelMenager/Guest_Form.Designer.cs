namespace HotelMenager
{
    partial class Guest_Form
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.hotelmanagerdatabaseDS = new HotelMenager.hotelmanagerdatabaseDS();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new HotelMenager.hotelmanagerdatabaseDSTableAdapters.guestsTableAdapter();
            this.tableAdapterManager = new HotelMenager.hotelmanagerdatabaseDSTableAdapters.TableAdapterManager();
            this.hotelmanagerdatabaseDS1 = new HotelMenager.hotelmanagerdatabaseDS();
            this.guestsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.cmbBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerdatabaseDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerdatabaseDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(9, 422);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(173, 58);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(306, 414);
            this.txtbxName.Multiline = true;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(467, 66);
            this.txtbxName.TabIndex = 2;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(306, 549);
            this.txtbxSurname.Multiline = true;
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(467, 66);
            this.txtbxSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.Location = new System.Drawing.Point(12, 557);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(243, 58);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(306, 688);
            this.txtbxPhone.Multiline = true;
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(467, 66);
            this.txtbxPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(12, 696);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(184, 58);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(19, 810);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(748, 108);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(22, 981);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(748, 108);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "EDIT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(22, 1149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(748, 108);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // hotelmanagerdatabaseDS
            // 
            this.hotelmanagerdatabaseDS.DataSetName = "hotelmanagerdatabaseDS";
            this.hotelmanagerdatabaseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "guests";
            this.guestsBindingSource.DataSource = this.hotelmanagerdatabaseDS;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.guestsTableAdapter = this.guestsTableAdapter;
            this.tableAdapterManager.reservationsTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelMenager.hotelmanagerdatabaseDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotelmanagerdatabaseDS1
            // 
            this.hotelmanagerdatabaseDS1.DataSetName = "hotelmanagerdatabaseDS";
            this.hotelmanagerdatabaseDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsDataGridView
            // 
            this.guestsDataGridView.AllowUserToAddRows = false;
            this.guestsDataGridView.AllowUserToDeleteRows = false;
            this.guestsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsDataGridView.Location = new System.Drawing.Point(22, 106);
            this.guestsDataGridView.MinimumSize = new System.Drawing.Size(1251, 1176);
            this.guestsDataGridView.Name = "guestsDataGridView";
            this.guestsDataGridView.ReadOnly = true;
            this.guestsDataGridView.RowHeadersWidth = 102;
            this.guestsDataGridView.RowTemplate.Height = 40;
            this.guestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guestsDataGridView.Size = new System.Drawing.Size(1301, 1215);
            this.guestsDataGridView.TabIndex = 10;
            this.guestsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsDataGridView_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(25, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(748, 108);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR FORM";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(1001, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(290, 66);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbxSearch.Location = new System.Drawing.Point(516, 18);
            this.txtbxSearch.Multiline = true;
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(460, 66);
            this.txtbxSearch.TabIndex = 13;
            // 
            // cmbBoxSearch
            // 
            this.cmbBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxSearch.FormattingEnabled = true;
            this.cmbBoxSearch.ItemHeight = 46;
            this.cmbBoxSearch.Items.AddRange(new object[] {
            "search by Id",
            "search by Name",
            "search by Surname",
            "search by Phone"});
            this.cmbBoxSearch.Location = new System.Drawing.Point(22, 30);
            this.cmbBoxSearch.Name = "cmbBoxSearch";
            this.cmbBoxSearch.Size = new System.Drawing.Size(460, 54);
            this.cmbBoxSearch.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(983, 1356);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(290, 59);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guestsDataGridView);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cmbBoxSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtbxSearch);
            this.panel1.Location = new System.Drawing.Point(897, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 1438);
            this.panel1.TabIndex = 16;
            // 
            // Guest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2246, 1493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblName);
            this.MinimumSize = new System.Drawing.Size(2278, 1537);
            this.Name = "Guest_Form";
            this.Text = "Guest_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Guest_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerdatabaseDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelmanagerdatabaseDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private hotelmanagerdatabaseDS hotelmanagerdatabaseDS;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private hotelmanagerdatabaseDSTableAdapters.guestsTableAdapter guestsTableAdapter;
        private hotelmanagerdatabaseDSTableAdapters.TableAdapterManager tableAdapterManager;
        private hotelmanagerdatabaseDS hotelmanagerdatabaseDS1;
        private System.Windows.Forms.DataGridView guestsDataGridView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.ComboBox cmbBoxSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
    }
}