namespace bLaserTag
{
    partial class PendingOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHelpText = new System.Windows.Forms.Label();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalOrdersLabel = new System.Windows.Forms.Label();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.lstPendingOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHelpText);
            this.panel1.Controls.Add(this.lblPendingOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblHelpText
            // 
            this.lblHelpText.AutoSize = true;
            this.lblHelpText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelpText.Location = new System.Drawing.Point(22, 16);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(195, 13);
            this.lblHelpText.TabIndex = 1;
            this.lblHelpText.Text = "Right click on an order for more options.";
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(3, 0);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(116, 16);
            this.lblPendingOrders.TabIndex = 0;
            this.lblPendingOrders.Text = "Pending Orders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalOrders);
            this.panel2.Controls.Add(this.lblTotalOrdersLabel);
            this.panel2.Controls.Add(this.btnTransmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 31);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(68, 10);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(13, 13);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "0";
            // 
            // lblTotalOrdersLabel
            // 
            this.lblTotalOrdersLabel.AutoSize = true;
            this.lblTotalOrdersLabel.Location = new System.Drawing.Point(3, 10);
            this.lblTotalOrdersLabel.Name = "lblTotalOrdersLabel";
            this.lblTotalOrdersLabel.Size = new System.Drawing.Size(68, 13);
            this.lblTotalOrdersLabel.TabIndex = 1;
            this.lblTotalOrdersLabel.Text = "Total Orders:";
            // 
            // btnTransmit
            // 
            this.btnTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransmit.Enabled = false;
            this.btnTransmit.Location = new System.Drawing.Point(177, 5);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(98, 23);
            this.btnTransmit.TabIndex = 0;
            this.btnTransmit.Text = "Process Batch";
            this.btnTransmit.UseVisualStyleBackColor = true;
            // 
            // lstPendingOrders
            // 
            this.lstPendingOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPendingOrders.FullRowSelect = true;
            this.lstPendingOrders.Location = new System.Drawing.Point(0, 36);
            this.lstPendingOrders.Name = "lstPendingOrders";
            this.lstPendingOrders.Size = new System.Drawing.Size(278, 510);
            this.lstPendingOrders.TabIndex = 2;
            this.lstPendingOrders.UseCompatibleStateImageBehavior = false;
            this.lstPendingOrders.View = System.Windows.Forms.View.Details;
            this.lstPendingOrders.SelectedIndexChanged += new System.EventHandler(this.lstPendingOrders_SelectedIndexChanged);
            this.lstPendingOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPendingOrders_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Purchase Order #";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 99;
            // 
            // PendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstPendingOrders);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PendingOrders";
            this.Size = new System.Drawing.Size(278, 577);
            this.Load += new System.EventHandler(this.PendingOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransmit;
        private System.Windows.Forms.ListView lstPendingOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblHelpText;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersLabel;
    }
}
