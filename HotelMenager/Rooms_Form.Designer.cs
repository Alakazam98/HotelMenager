namespace HotelMenager
{
    partial class Rooms_Form
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
            this.lstbxAvailableRooms = new System.Windows.Forms.ListBox();
            this.lstbxTakenRooms = new System.Windows.Forms.ListBox();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTakeRoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoomSize = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxAvailableRooms
            // 
            this.lstbxAvailableRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstbxAvailableRooms.FormattingEnabled = true;
            this.lstbxAvailableRooms.ItemHeight = 31;
            this.lstbxAvailableRooms.Location = new System.Drawing.Point(12, 89);
            this.lstbxAvailableRooms.Name = "lstbxAvailableRooms";
            this.lstbxAvailableRooms.Size = new System.Drawing.Size(315, 593);
            this.lstbxAvailableRooms.TabIndex = 0;
            // 
            // lstbxTakenRooms
            // 
            this.lstbxTakenRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lstbxTakenRooms.FormattingEnabled = true;
            this.lstbxTakenRooms.ItemHeight = 31;
            this.lstbxTakenRooms.Location = new System.Drawing.Point(345, 89);
            this.lstbxTakenRooms.Name = "lstbxTakenRooms";
            this.lstbxTakenRooms.Size = new System.Drawing.Size(315, 593);
            this.lstbxTakenRooms.TabIndex = 2;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAvailableRooms.Location = new System.Drawing.Point(13, 32);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(233, 32);
            this.lblAvailableRooms.TabIndex = 3;
            this.lblAvailableRooms.Text = "Available rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(339, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taken rooms";
            // 
            // lblTakeRoom
            // 
            this.lblTakeRoom.AutoSize = true;
            this.lblTakeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTakeRoom.Location = new System.Drawing.Point(748, 191);
            this.lblTakeRoom.Name = "lblTakeRoom";
            this.lblTakeRoom.Size = new System.Drawing.Size(296, 46);
            this.lblTakeRoom.TabIndex = 5;
            this.lblTakeRoom.Text = "Room number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(748, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "How many days:";
            // 
            // lblRoomSize
            // 
            this.lblRoomSize.AutoSize = true;
            this.lblRoomSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRoomSize.Location = new System.Drawing.Point(748, 89);
            this.lblRoomSize.Name = "lblRoomSize";
            this.lblRoomSize.Size = new System.Drawing.Size(231, 46);
            this.lblRoomSize.TabIndex = 7;
            this.lblRoomSize.Text = "Room size:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(1104, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 53);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(1104, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 53);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(1104, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 53);
            this.textBox3.TabIndex = 10;
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReserve.Location = new System.Drawing.Point(756, 527);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(584, 70);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnPeek
            // 
            this.btnPeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPeek.Location = new System.Drawing.Point(756, 395);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(584, 70);
            this.btnPeek.TabIndex = 12;
            this.btnPeek.Text = "PEEK";
            this.btnPeek.UseVisualStyleBackColor = true;
            // 
            // Rooms_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 788);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRoomSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTakeRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvailableRooms);
            this.Controls.Add(this.lstbxTakenRooms);
            this.Controls.Add(this.lstbxAvailableRooms);
            this.Name = "Rooms_Form";
            this.Text = "Rooms_Form";
            this.Load += new System.EventHandler(this.Rooms_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxAvailableRooms;
        private System.Windows.Forms.ListBox lstbxTakenRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTakeRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoomSize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnPeek;
    }
}