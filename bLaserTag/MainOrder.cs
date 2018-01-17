using System;
using System.Linq;
using System.Windows.Forms;

namespace bLaserTag
{
    public partial class MainOrder : UserControl
    {
        private readonly OrderHeader order = new OrderHeader();

        public event EventHandler<OrderHeader> OrderCompleted;
        public event EventHandler OrderCanceled;

        public MainOrder()
        {
            InitializeComponent();
        }
        
        private void MainOrder_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadComboBox();
            SetDataBindings();
            LoadDefaultOrder();
        }
        
        public void LoadDefaultOrder()
        {
            if (!System.IO.File.Exists(Program.DefaultOrder))
            {
                order.Reset();
            }
            else
            {
                var doc = AllfleXML.FlexOrder.Parser.Import(Program.DefaultOrder);
                AutoMapper.Mapper.Map(doc.OrderHeaders.SingleOrDefault(), order);
            }

            txtPONumber.Select();
        }

        public void LoadOrder(AllfleXML.FlexOrder.OrderHeader orderHeader)
        {
            AutoMapper.Mapper.Map(orderHeader, order);
        }

        public void SetDataBindings()
        {
            // Reminder - These bindings are only valid for the current instance of this.order
            // if this.order is set to a new instance, then these bindings will have to be setup again.
            txtPONumber.DataBindings.Clear();
            chkRush.DataBindings.Clear();
            txtPremise.DataBindings.Clear();
            txtComments.DataBindings.Clear();
            cmbShippingMethods.DataBindings.Clear();
            txtShipperNumber.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtAddress1.DataBindings.Clear();
            txtAddress2.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtState.DataBindings.Clear();
            txtPostal.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            txtPONumber.DataBindings.Add("Text", order, "PO", false, DataSourceUpdateMode.OnPropertyChanged);
            chkRush.DataBindings.Add("Checked", order, "IsRush", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPremise.DataBindings.Add("Text", order, "PremiseID", false, DataSourceUpdateMode.OnPropertyChanged);
            txtComments.DataBindings.Add("Text", order, "Comments", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbShippingMethods.DataBindings.Add("SelectedValue", order, "ShipMethod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtShipperNumber.DataBindings.Add("Text", order, "ShippingAccountNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", order, "ShipToName", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAddress1.DataBindings.Add("Text", order, "ShipToAddress1", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAddress2.DataBindings.Add("Text", order, "ShipToAddress2", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCity.DataBindings.Add("Text", order, "ShipToCity", false, DataSourceUpdateMode.OnPropertyChanged);
            txtState.DataBindings.Add("Text", order, "ShipToState", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPostal.DataBindings.Add("Text", order, "ShipToPostalCode", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCountry.DataBindings.Add("Text", order, "ShipToCountry", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add("Text", order, "ShipToPhone", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", order, "EmailListError", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadComboBox()
        {
            cmbShippingMethods.DisplayMember = "Name";
            cmbShippingMethods.ValueMember = "Code";
            cmbShippingMethods.DataSource = ShippingMethod.GetShippingMethods().ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderCanceled?.Invoke(this, EventArgs.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderCompleted?.Invoke(this, order);
            LoadDefaultOrder();
        }

        private void lstOrderLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstOrderLines.SelectedItems.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Implement Method
            MessageBox.Show("Method not Implemented.");

            var orderLineModifier = new MainOrderLine();

            var window = new Form();
            window.Controls.Add(orderLineModifier);
            orderLineModifier.Dock = DockStyle.Fill;
            window.Size = new System.Drawing.Size(orderLineModifier.MinimumSize.Width + 25, orderLineModifier.MinimumSize.Height + 50);
            orderLineModifier.LineCompleted += (s, line) =>
            {
                throw new NotImplementedException();
                window.Close();
            };
            orderLineModifier.LineCanceled += (s, evt) => {
                window.DialogResult = DialogResult.Cancel;
                window.Close();
            };

            window.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // TODO: Implement Method
            MessageBox.Show("Method not Implemented.");
        }
    }
}
