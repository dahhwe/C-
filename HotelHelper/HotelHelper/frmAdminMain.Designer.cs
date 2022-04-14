namespace HotelHelper
{
    partial class frmAdminMain
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
            this.lblAdminsFullName = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cmbCustomersOrdered = new System.Windows.Forms.ComboBox();
            this.lblCustomersOrdered = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lstCustomersOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdminsFullName
            // 
            this.lblAdminsFullName.AutoSize = true;
            this.lblAdminsFullName.BackColor = System.Drawing.Color.Coral;
            this.lblAdminsFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminsFullName.ForeColor = System.Drawing.Color.Black;
            this.lblAdminsFullName.Location = new System.Drawing.Point(23, 27);
            this.lblAdminsFullName.Name = "lblAdminsFullName";
            this.lblAdminsFullName.Size = new System.Drawing.Size(111, 29);
            this.lblAdminsFullName.TabIndex = 0;
            this.lblAdminsFullName.Text = "_______";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(743, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(135, 34);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cmbCustomersOrdered
            // 
            this.cmbCustomersOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomersOrdered.FormattingEnabled = true;
            this.cmbCustomersOrdered.Location = new System.Drawing.Point(32, 141);
            this.cmbCustomersOrdered.Name = "cmbCustomersOrdered";
            this.cmbCustomersOrdered.Size = new System.Drawing.Size(254, 28);
            this.cmbCustomersOrdered.TabIndex = 5;
            this.cmbCustomersOrdered.SelectedIndexChanged += new System.EventHandler(this.cmbCustomersOrdered_SelectedIndexChanged);
            // 
            // lblCustomersOrdered
            // 
            this.lblCustomersOrdered.AutoSize = true;
            this.lblCustomersOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersOrdered.ForeColor = System.Drawing.Color.Black;
            this.lblCustomersOrdered.Location = new System.Drawing.Point(28, 106);
            this.lblCustomersOrdered.Name = "lblCustomersOrdered";
            this.lblCustomersOrdered.Size = new System.Drawing.Size(258, 20);
            this.lblCustomersOrdered.TabIndex = 6;
            this.lblCustomersOrdered.Text = "List of customers who ordered food";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.Coral;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCost.Location = new System.Drawing.Point(380, 210);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalCost.Size = new System.Drawing.Size(93, 20);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "Total cost is";
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Black;
            this.btnMain.Location = new System.Drawing.Point(743, 51);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(135, 34);
            this.btnMain.TabIndex = 8;
            this.btnMain.Text = "View as customer";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.Coral;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentMethod.Location = new System.Drawing.Point(380, 245);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaymentMethod.Size = new System.Drawing.Size(129, 20);
            this.lblPaymentMethod.TabIndex = 9;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // lstCustomersOrder
            // 
            this.lstCustomersOrder.BackColor = System.Drawing.Color.Coral;
            this.lstCustomersOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstCustomersOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomersOrder.Location = new System.Drawing.Point(32, 210);
            this.lstCustomersOrder.Name = "lstCustomersOrder";
            this.lstCustomersOrder.Size = new System.Drawing.Size(324, 316);
            this.lstCustomersOrder.TabIndex = 10;
            this.lstCustomersOrder.UseCompatibleStateImageBehavior = false;
            this.lstCustomersOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food name";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 80;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(479, 210);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "_______";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(515, 245);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(81, 20);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "________";
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(890, 661);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lstCustomersOrder);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCustomersOrdered);
            this.Controls.Add(this.cmbCustomersOrdered);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblAdminsFullName);
            this.Name = "frmAdminMain";
            this.Text = "frmAdminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminsFullName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox cmbCustomersOrdered;
        private System.Windows.Forms.Label lblCustomersOrdered;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ListView lstCustomersOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPayment;
    }
}