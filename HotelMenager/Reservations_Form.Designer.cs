namespace HotelMenager
{
    partial class Reservations_Form
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
            this.grdViewReservations = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.dtTmPickArrival = new System.Windows.Forms.DateTimePicker();
            this.dtTmPickDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaysCount = new System.Windows.Forms.Label();
            this.txtDaysAmount = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbBxRoomSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewReservations
            // 
            this.grdViewReservations.AllowUserToAddRows = false;
            this.grdViewReservations.AllowUserToDeleteRows = false;
            this.grdViewReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdViewReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViewReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewReservations.Location = new System.Drawing.Point(524, 12);
            this.grdViewReservations.Name = "grdViewReservations";
            this.grdViewReservations.ReadOnly = true;
            this.grdViewReservations.RowHeadersWidth = 102;
            this.grdViewReservations.RowTemplate.Height = 40;
            this.grdViewReservations.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewReservations.ShowEditingIcon = false;
            this.grdViewReservations.Size = new System.Drawing.Size(1545, 1033);
            this.grdViewReservations.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(24, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 46);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Arrival:";
            // 
            // dtTmPickArrival
            // 
            this.dtTmPickArrival.Location = new System.Drawing.Point(32, 101);
            this.dtTmPickArrival.Name = "dtTmPickArrival";
            this.dtTmPickArrival.Size = new System.Drawing.Size(475, 38);
            this.dtTmPickArrival.TabIndex = 3;
            // 
            // dtTmPickDeparture
            // 
            this.dtTmPickDeparture.Location = new System.Drawing.Point(32, 247);
            this.dtTmPickDeparture.Name = "dtTmPickDeparture";
            this.dtTmPickDeparture.Size = new System.Drawing.Size(475, 38);
            this.dtTmPickDeparture.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Departure:";
            // 
            // lblDaysCount
            // 
            this.lblDaysCount.AutoSize = true;
            this.lblDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDaysCount.Location = new System.Drawing.Point(24, 304);
            this.lblDaysCount.Name = "lblDaysCount";
            this.lblDaysCount.Size = new System.Drawing.Size(278, 46);
            this.lblDaysCount.TabIndex = 6;
            this.lblDaysCount.Text = "Days amount:";
            // 
            // txtDaysAmount
            // 
            this.txtDaysAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDaysAmount.Location = new System.Drawing.Point(32, 383);
            this.txtDaysAmount.Name = "txtDaysAmount";
            this.txtDaysAmount.Size = new System.Drawing.Size(475, 53);
            this.txtDaysAmount.TabIndex = 7;
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxName.Location = new System.Drawing.Point(32, 537);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(475, 53);
            this.txtBxName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(24, 458);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 46);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxSurname.Location = new System.Drawing.Point(32, 695);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(475, 53);
            this.txtBxSurname.TabIndex = 11;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.Location = new System.Drawing.Point(24, 616);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(200, 46);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Surname:";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxPhone.Location = new System.Drawing.Point(32, 850);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(475, 53);
            this.txtBxPhone.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(24, 771);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(153, 46);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddReservation.Location = new System.Drawing.Point(32, 1098);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(475, 60);
            this.btnAddReservation.TabIndex = 14;
            this.btnAddReservation.Text = "ADD";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRoomType.Location = new System.Drawing.Point(24, 931);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(231, 46);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room size:";
            // 
            // cmbBxRoomSize
            // 
            this.cmbBxRoomSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxRoomSize.FormattingEnabled = true;
            this.cmbBxRoomSize.Items.AddRange(new object[] {
            "single",
            "double",
            "triple",
            "quadruple"});
            this.cmbBxRoomSize.Location = new System.Drawing.Point(32, 991);
            this.cmbBxRoomSize.Name = "cmbBxRoomSize";
            this.cmbBxRoomSize.Size = new System.Drawing.Size(475, 54);
            this.cmbBxRoomSize.TabIndex = 16;
            // 
            // Reservations_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2081, 1193);
            this.Controls.Add(this.cmbBxRoomSize);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDaysAmount);
            this.Controls.Add(this.lblDaysCount);
            this.Controls.Add(this.dtTmPickDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTmPickArrival);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.grdViewReservations);
            this.Name = "Reservations_Form";
            this.Text = "Reservations_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reservations_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewReservations;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtTmPickArrival;
        private System.Windows.Forms.DateTimePicker dtTmPickDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaysCount;
        private System.Windows.Forms.TextBox txtDaysAmount;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbBxRoomSize;
    }
}