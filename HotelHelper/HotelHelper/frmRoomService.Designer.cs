namespace HotelHelper
{
    partial class frmRoomService
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOrderStart = new System.Windows.Forms.Button();
            this.lblcouponAccepted = new System.Windows.Forms.Label();
            this.lblFoodService = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.cmbRoomService = new System.Windows.Forms.ComboBox();
            this.lblTodayRoomService = new System.Windows.Forms.Label();
            this.btnSaveRoomTidy = new System.Windows.Forms.Button();
            this.pnlFoodOrder = new System.Windows.Forms.Panel();
            this.cmbPayingMethod = new System.Windows.Forms.ComboBox();
            this.cmbFoodAvailable = new System.Windows.Forms.ComboBox();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblPayingMethod = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFoodOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Food ordered";
            columnHeader2.Width = 240;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btnOrderStart
            // 
            this.btnOrderStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStart.ForeColor = System.Drawing.Color.White;
            this.btnOrderStart.Location = new System.Drawing.Point(16, 276);
            this.btnOrderStart.Name = "btnOrderStart";
            this.btnOrderStart.Size = new System.Drawing.Size(289, 63);
            this.btnOrderStart.TabIndex = 41;
            this.btnOrderStart.Text = "Press to start";
            this.btnOrderStart.UseVisualStyleBackColor = false;
            this.btnOrderStart.Click += new System.EventHandler(this.btnOrderStart_Click);
            // 
            // lblcouponAccepted
            // 
            this.lblcouponAccepted.AutoSize = true;
            this.lblcouponAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcouponAccepted.ForeColor = System.Drawing.Color.White;
            this.lblcouponAccepted.Location = new System.Drawing.Point(511, 296);
            this.lblcouponAccepted.Name = "lblcouponAccepted";
            this.lblcouponAccepted.Size = new System.Drawing.Size(0, 20);
            this.lblcouponAccepted.TabIndex = 40;
            // 
            // lblFoodService
            // 
            this.lblFoodService.AutoSize = true;
            this.lblFoodService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodService.ForeColor = System.Drawing.Color.White;
            this.lblFoodService.Location = new System.Drawing.Point(12, 237);
            this.lblFoodService.Name = "lblFoodService";
            this.lblFoodService.Size = new System.Drawing.Size(200, 24);
            this.lblFoodService.TabIndex = 25;
            this.lblFoodService.Text = "Food  delivery service:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(339, 536);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(20, 24);
            this.lblTotalCost.TabIndex = 34;
            this.lblTotalCost.Text = "0";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(329, 42);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(107, 28);
            this.btnAddToOrder.TabIndex = 27;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // cmbRoomService
            // 
            this.cmbRoomService.FormattingEnabled = true;
            this.cmbRoomService.Location = new System.Drawing.Point(16, 67);
            this.cmbRoomService.Name = "cmbRoomService";
            this.cmbRoomService.Size = new System.Drawing.Size(203, 21);
            this.cmbRoomService.TabIndex = 44;
            // 
            // lblTodayRoomService
            // 
            this.lblTodayRoomService.AutoSize = true;
            this.lblTodayRoomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayRoomService.ForeColor = System.Drawing.Color.White;
            this.lblTodayRoomService.Location = new System.Drawing.Point(12, 18);
            this.lblTodayRoomService.Name = "lblTodayRoomService";
            this.lblTodayRoomService.Size = new System.Drawing.Size(207, 24);
            this.lblTodayRoomService.TabIndex = 42;
            this.lblTodayRoomService.Text = "Room service for today:";
            // 
            // btnSaveRoomTidy
            // 
            this.btnSaveRoomTidy.BackColor = System.Drawing.Color.Indigo;
            this.btnSaveRoomTidy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoomTidy.Location = new System.Drawing.Point(16, 101);
            this.btnSaveRoomTidy.Name = "btnSaveRoomTidy";
            this.btnSaveRoomTidy.Size = new System.Drawing.Size(99, 44);
            this.btnSaveRoomTidy.TabIndex = 43;
            this.btnSaveRoomTidy.Text = "Save";
            this.btnSaveRoomTidy.UseVisualStyleBackColor = false;
            // 
            // pnlFoodOrder
            // 
            this.pnlFoodOrder.Controls.Add(this.btnClearOrder);
            this.pnlFoodOrder.Controls.Add(this.cmbPayingMethod);
            this.pnlFoodOrder.Controls.Add(this.btnAddToOrder);
            this.pnlFoodOrder.Controls.Add(this.cmbFoodAvailable);
            this.pnlFoodOrder.Controls.Add(this.lstOrder);
            this.pnlFoodOrder.Controls.Add(this.lblTotal);
            this.pnlFoodOrder.Controls.Add(this.label2);
            this.pnlFoodOrder.Controls.Add(this.lblCurrentOrder);
            this.pnlFoodOrder.Controls.Add(this.btnCancelOrder);
            this.pnlFoodOrder.Controls.Add(this.lblPayingMethod);
            this.pnlFoodOrder.Controls.Add(this.lblTotalCost);
            this.pnlFoodOrder.Controls.Add(this.btnCompleteOrder);
            this.pnlFoodOrder.Location = new System.Drawing.Point(324, 12);
            this.pnlFoodOrder.Name = "pnlFoodOrder";
            this.pnlFoodOrder.Size = new System.Drawing.Size(439, 651);
            this.pnlFoodOrder.TabIndex = 45;
            this.pnlFoodOrder.Visible = false;
            // 
            // cmbPayingMethod
            // 
            this.cmbPayingMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbPayingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayingMethod.ForeColor = System.Drawing.Color.White;
            this.cmbPayingMethod.FormattingEnabled = true;
            this.cmbPayingMethod.Items.AddRange(new object[] {
            "visa",
            "mastercard"});
            this.cmbPayingMethod.Location = new System.Drawing.Point(275, 483);
            this.cmbPayingMethod.Name = "cmbPayingMethod";
            this.cmbPayingMethod.Size = new System.Drawing.Size(150, 28);
            this.cmbPayingMethod.TabIndex = 31;
            // 
            // cmbFoodAvailable
            // 
            this.cmbFoodAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbFoodAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFoodAvailable.ForeColor = System.Drawing.Color.White;
            this.cmbFoodAvailable.FormattingEnabled = true;
            this.cmbFoodAvailable.Location = new System.Drawing.Point(150, 3);
            this.cmbFoodAvailable.Name = "cmbFoodAvailable";
            this.cmbFoodAvailable.Size = new System.Drawing.Size(286, 33);
            this.cmbFoodAvailable.TabIndex = 26;
            // 
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.ForeColor = System.Drawing.Color.White;
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(21, 123);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(404, 257);
            this.lstOrder.TabIndex = 35;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(257, 536);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Food available:";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrder.ForeColor = System.Drawing.Color.White;
            this.lblCurrentOrder.Location = new System.Drawing.Point(17, 97);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(127, 24);
            this.lblCurrentOrder.TabIndex = 28;
            this.lblCurrentOrder.Text = "Current order:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Red;
            this.btnCancelOrder.Location = new System.Drawing.Point(329, 96);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(96, 23);
            this.btnCancelOrder.TabIndex = 36;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lblPayingMethod
            // 
            this.lblPayingMethod.AutoSize = true;
            this.lblPayingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayingMethod.ForeColor = System.Drawing.Color.White;
            this.lblPayingMethod.Location = new System.Drawing.Point(109, 483);
            this.lblPayingMethod.Name = "lblPayingMethod";
            this.lblPayingMethod.Size = new System.Drawing.Size(133, 20);
            this.lblPayingMethod.TabIndex = 30;
            this.lblPayingMethod.Text = "Payment method:";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.BackColor = System.Drawing.Color.Indigo;
            this.btnCompleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnCompleteOrder.Location = new System.Drawing.Point(202, 594);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(223, 48);
            this.btnCompleteOrder.TabIndex = 33;
            this.btnCompleteOrder.Text = "Complete order";
            this.btnCompleteOrder.UseVisualStyleBackColor = false;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Location = new System.Drawing.Point(329, 385);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(96, 23);
            this.btnClearOrder.TabIndex = 37;
            this.btnClearOrder.Text = "Clear order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // frmRoomService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(765, 666);
            this.Controls.Add(this.btnOrderStart);
            this.Controls.Add(this.pnlFoodOrder);
            this.Controls.Add(this.cmbRoomService);
            this.Controls.Add(this.lblTodayRoomService);
            this.Controls.Add(this.btnSaveRoomTidy);
            this.Controls.Add(this.lblcouponAccepted);
            this.Controls.Add(this.lblFoodService);
            this.Name = "frmRoomService";
            this.Load += new System.EventHandler(this.frmRoomService_Load);
            this.pnlFoodOrder.ResumeLayout(false);
            this.pnlFoodOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOrderStart;
        private System.Windows.Forms.Label lblcouponAccepted;
        private System.Windows.Forms.Label lblFoodService;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ComboBox cmbRoomService;
        private System.Windows.Forms.Label lblTodayRoomService;
        private System.Windows.Forms.Button btnSaveRoomTidy;
        private System.Windows.Forms.Panel pnlFoodOrder;
        private System.Windows.Forms.ComboBox cmbPayingMethod;
        private System.Windows.Forms.ComboBox cmbFoodAvailable;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblPayingMethod;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.Button btnClearOrder;
    }
}