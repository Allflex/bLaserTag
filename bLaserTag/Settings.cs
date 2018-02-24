using System;
using System.Linq;
using System.Windows.Forms;

namespace bLaserTag
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var defaultOrder = AllfleXML.FlexOrder.Parser.Import(Program.DefaultOrder).OrderHeaders.SingleOrDefault();
            txtCustomerNumber.Text = defaultOrder.CustomerNumber;

            txtApiKey.Text = Program.APIKey;
            txtDefaultOrder.Text = Program.DefaultOrder;
            txtOrdersDirectory.Text = Program.OrdersDirectory;

            var shippingMethods = ShippingMethod.GetShippingMethods();
            lstShippingMethods.BeginUpdate();
            lstShippingMethods.Items.Clear();
            foreach(var method in shippingMethods)
            {
                var item = new ListViewItem(method.Name);
                item.SubItems.Add(method.Code);
                item.Tag = method;

                lstShippingMethods.Items.Add(item);
            }
            lstShippingMethods.EndUpdate();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void Save()
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            config.AppSettings.Settings["APIKey"].Value = txtApiKey.Text.ToString();
            config.AppSettings.Settings["DefaultOrder"].Value = txtDefaultOrder.Text.ToString();
            config.AppSettings.Settings["OrdersDirectory"].Value = txtOrdersDirectory.Text.ToString();

            config.Save(System.Configuration.ConfigurationSaveMode.Modified, true);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");

            Program.ReloadConfiguration();

            // TODO: Shipping Methods

            var defaultOrder = AllfleXML.FlexOrder.Parser.Import(Program.DefaultOrder).OrderHeaders.SingleOrDefault();
            defaultOrder.CustomerNumber = txtCustomerNumber.Text.ToString();
            var doc = AllfleXML.FlexOrder.Parser.Export(defaultOrder);
            doc.Save(Program.DefaultOrder);
        }

        private void btnBrowseOrdersDirectory_Click(object sender, EventArgs e)
        {
            // TODO: Implement;
            MessageBox.Show("Method not implemented");
        }

        private void btnDefaultOrderBrowse_Click(object sender, EventArgs e)
        {
            // TODO: Implement;
            MessageBox.Show("Method not implemented");
        }

        private void btnModifyDefaultOrder_Click(object sender, EventArgs e)
        {
            var orderModifier = new MainOrder();
            
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            var window = new Form
            {
                Parent = this.Parent,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Default Order",
                Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")))
            };

            window.Controls.Add(orderModifier);
            orderModifier.Dock = DockStyle.Fill;
            window.MinimumSize = new System.Drawing.Size(orderModifier.MinimumSize.Width + 25, orderModifier.MinimumSize.Height + 50);
            window.Size = window.MinimumSize;


            orderModifier.OrderCompleted += (s, order) =>
            {
                Program.UpdateDefaultOrder(order);
                window.Close();
            };
            orderModifier.OrderCanceled += (s, evt) => {
                window.DialogResult = DialogResult.Cancel;
                window.Close();
            };

            window.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Implement;
            MessageBox.Show("Method not implemented");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // TODO: Implement;
            MessageBox.Show("Method not implemented");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: Check for changes and prompt confirmation.

            Close();
        }
    }
}
