namespace HotelHelper
{
    partial class frmMain
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTimeMorning = new System.Windows.Forms.Label();
            this.lblTimeLunch = new System.Windows.Forms.Label();
            this.lblTimeNoon = new System.Windows.Forms.Label();
            this.lblTimeEvening = new System.Windows.Forms.Label();
            this.lblTimeLateEvening = new System.Windows.Forms.Label();
            this.cmbActivityMorning = new System.Windows.Forms.ComboBox();
            this.cmbActivityLunch = new System.Windows.Forms.ComboBox();
            this.cmbActivityNoon = new System.Windows.Forms.ComboBox();
            this.cmbActivityEvening = new System.Windows.Forms.ComboBox();
            this.cmbActivityLateEvening = new System.Windows.Forms.ComboBox();
            this.lblActivities = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrentTIme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRoomService = new System.Windows.Forms.Button();
            this.btnRestaurantBooking = new System.Windows.Forms.Button();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.lstFoodOrdered = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblFoodDeliveryStatus = new System.Windows.Forms.Label();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(836, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(132, 37);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblTimeMorning
            // 
            this.lblTimeMorning.AutoSize = true;
            this.lblTimeMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMorning.ForeColor = System.Drawing.Color.White;
            this.lblTimeMorning.Location = new System.Drawing.Point(12, 148);
            this.lblTimeMorning.Name = "lblTimeMorning";
            this.lblTimeMorning.Size = new System.Drawing.Size(49, 20);
            this.lblTimeMorning.TabIndex = 3;
            this.lblTimeMorning.Text = "09:00";
            // 
            // lblTimeLunch
            // 
            this.lblTimeLunch.AutoSize = true;
            this.lblTimeLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLunch.ForeColor = System.Drawing.Color.White;
            this.lblTimeLunch.Location = new System.Drawing.Point(12, 190);
            this.lblTimeLunch.Name = "lblTimeLunch";
            this.lblTimeLunch.Size = new System.Drawing.Size(49, 20);
            this.lblTimeLunch.TabIndex = 4;
            this.lblTimeLunch.Text = "12:30";
            // 
            // lblTimeNoon
            // 
            this.lblTimeNoon.AutoSize = true;
            this.lblTimeNoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNoon.ForeColor = System.Drawing.Color.White;
            this.lblTimeNoon.Location = new System.Drawing.Point(12, 235);
            this.lblTimeNoon.Name = "lblTimeNoon";
            this.lblTimeNoon.Size = new System.Drawing.Size(49, 20);
            this.lblTimeNoon.TabIndex = 5;
            this.lblTimeNoon.Text = "17:30";
            // 
            // lblTimeEvening
            // 
            this.lblTimeEvening.AutoSize = true;
            this.lblTimeEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEvening.ForeColor = System.Drawing.Color.White;
            this.lblTimeEvening.Location = new System.Drawing.Point(12, 285);
            this.lblTimeEvening.Name = "lblTimeEvening";
            this.lblTimeEvening.Size = new System.Drawing.Size(49, 20);
            this.lblTimeEvening.TabIndex = 6;
            this.lblTimeEvening.Text = "20:00";
            // 
            // lblTimeLateEvening
            // 
            this.lblTimeLateEvening.AutoSize = true;
            this.lblTimeLateEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLateEvening.ForeColor = System.Drawing.Color.White;
            this.lblTimeLateEvening.Location = new System.Drawing.Point(12, 336);
            this.lblTimeLateEvening.Name = "lblTimeLateEvening";
            this.lblTimeLateEvening.Size = new System.Drawing.Size(49, 20);
            this.lblTimeLateEvening.TabIndex = 7;
            this.lblTimeLateEvening.Text = "21:00";
            // 
            // cmbActivityMorning
            // 
            this.cmbActivityMorning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbActivityMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivityMorning.ForeColor = System.Drawing.Color.White;
            this.cmbActivityMorning.FormattingEnabled = true;
            this.cmbActivityMorning.Location = new System.Drawing.Point(107, 147);
            this.cmbActivityMorning.Name = "cmbActivityMorning";
            this.cmbActivityMorning.Size = new System.Drawing.Size(194, 28);
            this.cmbActivityMorning.TabIndex = 8;
            // 
            // cmbActivityLunch
            // 
            this.cmbActivityLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbActivityLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivityLunch.ForeColor = System.Drawing.Color.White;
            this.cmbActivityLunch.FormattingEnabled = true;
            this.cmbActivityLunch.Location = new System.Drawing.Point(107, 189);
            this.cmbActivityLunch.Name = "cmbActivityLunch";
            this.cmbActivityLunch.Size = new System.Drawing.Size(194, 28);
            this.cmbActivityLunch.TabIndex = 9;
            // 
            // cmbActivityNoon
            // 
            this.cmbActivityNoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbActivityNoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivityNoon.ForeColor = System.Drawing.Color.White;
            this.cmbActivityNoon.FormattingEnabled = true;
            this.cmbActivityNoon.Location = new System.Drawing.Point(107, 234);
            this.cmbActivityNoon.Name = "cmbActivityNoon";
            this.cmbActivityNoon.Size = new System.Drawing.Size(194, 28);
            this.cmbActivityNoon.TabIndex = 10;
            // 
            // cmbActivityEvening
            // 
            this.cmbActivityEvening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbActivityEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivityEvening.ForeColor = System.Drawing.Color.White;
            this.cmbActivityEvening.FormattingEnabled = true;
            this.cmbActivityEvening.Location = new System.Drawing.Point(107, 284);
            this.cmbActivityEvening.Name = "cmbActivityEvening";
            this.cmbActivityEvening.Size = new System.Drawing.Size(194, 28);
            this.cmbActivityEvening.TabIndex = 11;
            // 
            // cmbActivityLateEvening
            // 
            this.cmbActivityLateEvening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbActivityLateEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivityLateEvening.ForeColor = System.Drawing.Color.White;
            this.cmbActivityLateEvening.FormattingEnabled = true;
            this.cmbActivityLateEvening.Location = new System.Drawing.Point(107, 335);
            this.cmbActivityLateEvening.Name = "cmbActivityLateEvening";
            this.cmbActivityLateEvening.Size = new System.Drawing.Size(194, 28);
            this.cmbActivityLateEvening.TabIndex = 12;
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.ForeColor = System.Drawing.Color.White;
            this.lblActivities.Location = new System.Drawing.Point(11, 112);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(196, 25);
            this.lblActivities.TabIndex = 13;
            this.lblActivities.Text = "Activities available:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(187, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCurrentTIme
            // 
            this.lblCurrentTIme.AutoSize = true;
            this.lblCurrentTIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTIme.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTIme.Location = new System.Drawing.Point(357, 182);
            this.lblCurrentTIme.Name = "lblCurrentTIme";
            this.lblCurrentTIme.Size = new System.Drawing.Size(60, 24);
            this.lblCurrentTIme.TabIndex = 15;
            this.lblCurrentTIme.Text = "_____";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(356, 136);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 25);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "_____";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRoomService
            // 
            this.btnRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomService.ForeColor = System.Drawing.Color.White;
            this.btnRoomService.Location = new System.Drawing.Point(2, 3);
            this.btnRoomService.Name = "btnRoomService";
            this.btnRoomService.Size = new System.Drawing.Size(132, 41);
            this.btnRoomService.TabIndex = 17;
            this.btnRoomService.Text = "Room Service";
            this.btnRoomService.UseVisualStyleBackColor = true;
            this.btnRoomService.Click += new System.EventHandler(this.btnRoomService_Click);
            // 
            // btnRestaurantBooking
            // 
            this.btnRestaurantBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurantBooking.ForeColor = System.Drawing.Color.White;
            this.btnRestaurantBooking.Location = new System.Drawing.Point(140, 3);
            this.btnRestaurantBooking.Name = "btnRestaurantBooking";
            this.btnRestaurantBooking.Size = new System.Drawing.Size(132, 41);
            this.btnRestaurantBooking.TabIndex = 18;
            this.btnRestaurantBooking.Text = "Restaurant booking";
            this.btnRestaurantBooking.UseVisualStyleBackColor = true;
            this.btnRestaurantBooking.Click += new System.EventHandler(this.btnRestaurantBooking_Click);
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFullName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerFullName.Location = new System.Drawing.Point(356, 88);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(78, 29);
            this.lblCustomerFullName.TabIndex = 19;
            this.lblCustomerFullName.Text = "_____";
            // 
            // lstFoodOrdered
            // 
            this.lstFoodOrdered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lstFoodOrdered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstFoodOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFoodOrdered.ForeColor = System.Drawing.Color.White;
            this.lstFoodOrdered.Location = new System.Drawing.Point(634, 182);
            this.lstFoodOrdered.Name = "lstFoodOrdered";
            this.lstFoodOrdered.Size = new System.Drawing.Size(334, 221);
            this.lstFoodOrdered.TabIndex = 20;
            this.lstFoodOrdered.UseCompatibleStateImageBehavior = false;
            this.lstFoodOrdered.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Ordered";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 90;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.ForeColor = System.Drawing.Color.White;
            this.lblOrderStatus.Location = new System.Drawing.Point(808, 97);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(160, 20);
            this.lblOrderStatus.TabIndex = 21;
            this.lblOrderStatus.Text = "Food Order status:";
            // 
            // lblFoodDeliveryStatus
            // 
            this.lblFoodDeliveryStatus.AutoSize = true;
            this.lblFoodDeliveryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodDeliveryStatus.ForeColor = System.Drawing.Color.Red;
            this.lblFoodDeliveryStatus.Location = new System.Drawing.Point(809, 128);
            this.lblFoodDeliveryStatus.Name = "lblFoodDeliveryStatus";
            this.lblFoodDeliveryStatus.Size = new System.Drawing.Size(159, 20);
            this.lblFoodDeliveryStatus.TabIndex = 22;
            this.lblFoodDeliveryStatus.Text = "_______________";
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnAnalysis.Location = new System.Drawing.Point(278, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(132, 41);
            this.btnAnalysis.TabIndex = 23;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(980, 434);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.lblFoodDeliveryStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lstFoodOrdered);
            this.Controls.Add(this.lblCustomerFullName);
            this.Controls.Add(this.btnRestaurantBooking);
            this.Controls.Add(this.btnRoomService);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCurrentTIme);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.cmbActivityLateEvening);
            this.Controls.Add(this.cmbActivityEvening);
            this.Controls.Add(this.cmbActivityNoon);
            this.Controls.Add(this.cmbActivityLunch);
            this.Controls.Add(this.cmbActivityMorning);
            this.Controls.Add(this.lblTimeLateEvening);
            this.Controls.Add(this.lblTimeEvening);
            this.Controls.Add(this.lblTimeNoon);
            this.Controls.Add(this.lblTimeLunch);
            this.Controls.Add(this.lblTimeMorning);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblTimeMorning;
        private System.Windows.Forms.Label lblTimeLunch;
        private System.Windows.Forms.Label lblTimeNoon;
        private System.Windows.Forms.Label lblTimeEvening;
        private System.Windows.Forms.Label lblTimeLateEvening;
        private System.Windows.Forms.ComboBox cmbActivityMorning;
        private System.Windows.Forms.ComboBox cmbActivityLunch;
        private System.Windows.Forms.ComboBox cmbActivityNoon;
        private System.Windows.Forms.ComboBox cmbActivityEvening;
        private System.Windows.Forms.ComboBox cmbActivityLateEvening;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCurrentTIme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnRoomService;
        private System.Windows.Forms.Button btnRestaurantBooking;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.ListView lstFoodOrdered;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblFoodDeliveryStatus;
        private System.Windows.Forms.Button btnAnalysis;
    }
}