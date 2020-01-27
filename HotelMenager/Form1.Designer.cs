namespace HotelMenager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlstrpbtnGuests = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnRooms = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnReservations = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpbtnGuests,
            this.tlstrpbtnRooms,
            this.tlstrpbtnReservations});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1277, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlstrpbtnGuests
            // 
            this.tlstrpbtnGuests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrpbtnGuests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlstrpbtnGuests.Image = ((System.Drawing.Image)(resources.GetObject("tlstrpbtnGuests.Image")));
            this.tlstrpbtnGuests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnGuests.Name = "tlstrpbtnGuests";
            this.tlstrpbtnGuests.Size = new System.Drawing.Size(237, 45);
            this.tlstrpbtnGuests.Text = "Manage Guests";
            this.tlstrpbtnGuests.Click += new System.EventHandler(this.tlstrpbtnGuests_Click);
            // 
            // tlstrpbtnRooms
            // 
            this.tlstrpbtnRooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrpbtnRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlstrpbtnRooms.Image = ((System.Drawing.Image)(resources.GetObject("tlstrpbtnRooms.Image")));
            this.tlstrpbtnRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnRooms.Name = "tlstrpbtnRooms";
            this.tlstrpbtnRooms.Size = new System.Drawing.Size(239, 45);
            this.tlstrpbtnRooms.Text = "Manage Rooms";
            this.tlstrpbtnRooms.Click += new System.EventHandler(this.tlstrpbtnRooms_Click);
            // 
            // tlstrpbtnReservations
            // 
            this.tlstrpbtnReservations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrpbtnReservations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlstrpbtnReservations.Image = ((System.Drawing.Image)(resources.GetObject("tlstrpbtnReservations.Image")));
            this.tlstrpbtnReservations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnReservations.Name = "tlstrpbtnReservations";
            this.tlstrpbtnReservations.Size = new System.Drawing.Size(323, 45);
            this.tlstrpbtnReservations.Text = "Manage Reservations";
            this.tlstrpbtnReservations.Click += new System.EventHandler(this.tlstrpbtnReservations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 1315);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlstrpbtnGuests;
        private System.Windows.Forms.ToolStripButton tlstrpbtnRooms;
        private System.Windows.Forms.ToolStripButton tlstrpbtnReservations;
    }
}

