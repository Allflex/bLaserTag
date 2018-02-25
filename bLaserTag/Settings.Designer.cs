namespace bLaserTag
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.txtDefaultOrder = new System.Windows.Forms.TextBox();
            this.lblDefaultOrder = new System.Windows.Forms.Label();
            this.txtOrdersDirectory = new System.Windows.Forms.TextBox();
            this.lblOrdersDirectory = new System.Windows.Forms.Label();
            this.btnDefaultOrderBrowse = new System.Windows.Forms.Button();
            this.btnBrowseOrdersDirectory = new System.Windows.Forms.Button();
            this.btnModifyDefaultOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpShippingMethods = new System.Windows.Forms.GroupBox();
            this.lstShippingMethods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpShippingMethods.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(8, 15);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerNumber.TabIndex = 0;
            this.lblCustomerNumber.Text = "Customer Number";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(105, 12);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(79, 20);
            this.txtCustomerNumber.TabIndex = 1;
            // 
            // txtApiKey
            // 
            this.txtApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApiKey.Location = new System.Drawing.Point(59, 38);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(236, 20);
            this.txtApiKey.TabIndex = 2;
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(8, 41);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblAPIKey.TabIndex = 2;
            this.lblAPIKey.Text = "API Key";
            // 
            // txtDefaultOrder
            // 
            this.txtDefaultOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultOrder.Location = new System.Drawing.Point(87, 93);
            this.txtDefaultOrder.Name = "txtDefaultOrder";
            this.txtDefaultOrder.Size = new System.Drawing.Size(246, 20);
            this.txtDefaultOrder.TabIndex = 5;
            // 
            // lblDefaultOrder
            // 
            this.lblDefaultOrder.AutoSize = true;
            this.lblDefaultOrder.Location = new System.Drawing.Point(8, 96);
            this.lblDefaultOrder.Name = "lblDefaultOrder";
            this.lblDefaultOrder.Size = new System.Drawing.Size(73, 13);
            this.lblDefaultOrder.TabIndex = 4;
            this.lblDefaultOrder.Text = "Default Order:";
            // 
            // txtOrdersDirectory
            // 
            this.txtOrdersDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrdersDirectory.Location = new System.Drawing.Point(97, 64);
            this.txtOrdersDirectory.Name = "txtOrdersDirectory";
            this.txtOrdersDirectory.Size = new System.Drawing.Size(236, 20);
            this.txtOrdersDirectory.TabIndex = 3;
            // 
            // lblOrdersDirectory
            // 
            this.lblOrdersDirectory.AutoSize = true;
            this.lblOrdersDirectory.Location = new System.Drawing.Point(8, 67);
            this.lblOrdersDirectory.Name = "lblOrdersDirectory";
            this.lblOrdersDirectory.Size = new System.Drawing.Size(83, 13);
            this.lblOrdersDirectory.TabIndex = 6;
            this.lblOrdersDirectory.Text = "Orders Directory";
            // 
            // btnDefaultOrderBrowse
            // 
            this.btnDefaultOrderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultOrderBrowse.Location = new System.Drawing.Point(339, 91);
            this.btnDefaultOrderBrowse.Name = "btnDefaultOrderBrowse";
            this.btnDefaultOrderBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultOrderBrowse.TabIndex = 6;
            this.btnDefaultOrderBrowse.Text = "Browse";
            this.btnDefaultOrderBrowse.UseVisualStyleBackColor = true;
            this.btnDefaultOrderBrowse.Click += new System.EventHandler(this.btnDefaultOrderBrowse_Click);
            // 
            // btnBrowseOrdersDirectory
            // 
            this.btnBrowseOrdersDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOrdersDirectory.Location = new System.Drawing.Point(339, 62);
            this.btnBrowseOrdersDirectory.Name = "btnBrowseOrdersDirectory";
            this.btnBrowseOrdersDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOrdersDirectory.TabIndex = 4;
            this.btnBrowseOrdersDirectory.Text = "Browse";
            this.btnBrowseOrdersDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOrdersDirectory.Click += new System.EventHandler(this.btnBrowseOrdersDirectory_Click);
            // 
            // btnModifyDefaultOrder
            // 
            this.btnModifyDefaultOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyDefaultOrder.Location = new System.Drawing.Point(286, 120);
            this.btnModifyDefaultOrder.Name = "btnModifyDefaultOrder";
            this.btnModifyDefaultOrder.Size = new System.Drawing.Size(128, 23);
            this.btnModifyDefaultOrder.TabIndex = 7;
            this.btnModifyDefaultOrder.Text = "Modify Default Order";
            this.btnModifyDefaultOrder.UseVisualStyleBackColor = true;
            this.btnModifyDefaultOrder.Click += new System.EventHandler(this.btnModifyDefaultOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModifyDefaultOrder);
            this.panel1.Controls.Add(this.txtCustomerNumber);
            this.panel1.Controls.Add(this.btnBrowseOrdersDirectory);
            this.panel1.Controls.Add(this.lblCustomerNumber);
            this.panel1.Controls.Add(this.btnDefaultOrderBrowse);
            this.panel1.Controls.Add(this.lblAPIKey);
            this.panel1.Controls.Add(this.txtOrdersDirectory);
            this.panel1.Controls.Add(this.txtApiKey);
            this.panel1.Controls.Add(this.lblOrdersDirectory);
            this.panel1.Controls.Add(this.lblDefaultOrder);
            this.panel1.Controls.Add(this.txtDefaultOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 150);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 50);
            this.panel2.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(262, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(343, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpShippingMethods);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 252);
            this.panel3.TabIndex = 13;
            // 
            // grpShippingMethods
            // 
            this.grpShippingMethods.Controls.Add(this.lstShippingMethods);
            this.grpShippingMethods.Controls.Add(this.panel4);
            this.grpShippingMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShippingMethods.Location = new System.Drawing.Point(0, 0);
            this.grpShippingMethods.Name = "grpShippingMethods";
            this.grpShippingMethods.Size = new System.Drawing.Size(430, 252);
            this.grpShippingMethods.TabIndex = 0;
            this.grpShippingMethods.TabStop = false;
            this.grpShippingMethods.Text = "Shipping Methods";
            // 
            // lstShippingMethods
            // 
            this.lstShippingMethods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstShippingMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstShippingMethods.Location = new System.Drawing.Point(3, 52);
            this.lstShippingMethods.Name = "lstShippingMethods";
            this.lstShippingMethods.Size = new System.Drawing.Size(424, 197);
            this.lstShippingMethods.TabIndex = 10;
            this.lstShippingMethods.UseCompatibleStateImageBehavior = false;
            this.lstShippingMethods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Shipping Method";
            this.columnHeader1.Width = 252;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            this.columnHeader2.Width = 166;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 36);
            this.panel4.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::bLaserTag.Properties.Resources.delete;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Location = new System.Drawing.Point(38, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::bLaserTag.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(9, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(446, 400);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grpShippingMethods.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.TextBox txtDefaultOrder;
        private System.Windows.Forms.Label lblDefaultOrder;
        private System.Windows.Forms.TextBox txtOrdersDirectory;
        private System.Windows.Forms.Label lblOrdersDirectory;
        private System.Windows.Forms.Button btnDefaultOrderBrowse;
        private System.Windows.Forms.Button btnBrowseOrdersDirectory;
        private System.Windows.Forms.Button btnModifyDefaultOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpShippingMethods;
        private System.Windows.Forms.ListView lstShippingMethods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}