using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace bLaserTag
{
    public partial class MainOrder : UserControl
    {
        AllfleXML.FlexOrder.OrderHeader order;

        public MainOrder()
        {
            InitializeComponent();
            LoadComboBox();
            LoadDefaultOrder();

            //TODO: Add premise
            txtPONumber.DataBindings.Add("Text", order, "PO");
            chkRush.DataBindings.Add("Checked", order, "IsRush");
            txtComments.DataBindings.Add("Text", order, "Comments");
            cmbShippingMethods.DataBindings.Add("SelectedValue", order, "ShipMethod");
            txtShipperNumber.DataBindings.Add("Text", order, "ShippingAccountNumber");
            txtName.DataBindings.Add("Text", order, "ShipToName");
            txtAddress1.DataBindings.Add("Text", order, "ShipToAddress1");
            txtAddress2.DataBindings.Add("Text", order, "ShipToAddress2");
            txtCity.DataBindings.Add("Text", order, "ShipToCity");
            txtState.DataBindings.Add("Text", order, "ShipToState");
            txtPostal.DataBindings.Add("Text", order, "ShipToPostalCode");
            txtCountry.DataBindings.Add("Text", order, "ShipToCountry");
            txtPhone.DataBindings.Add("Text", order, "ShipToPhone");
            txtEmail.DataBindings.Add("Text", order, "EmailListError");
        }

        private void LoadDefaultOrder()
        {
            string defaultOrder = ConfigurationManager.AppSettings["DefaultOrder"];
            if (!System.IO.File.Exists(defaultOrder))
            {
                order = new AllfleXML.FlexOrder.OrderHeader();
            }
            else
            {
                var doc = AllfleXML.FlexOrder.Parser.Import(defaultOrder);
                order = doc.OrderHeaders.SingleOrDefault();
            }

            order.PO = order.PO ?? string.Empty;
            order.Comments = order.Comments ?? string.Empty;
            order.ShipMethod = order.ShipMethod ?? string.Empty;
            order.ShippingAccountNumber = order.ShippingAccountNumber ?? string.Empty;
            order.ShipToName = order.ShipToName ?? string.Empty;
            order.ShipToAddress1 = order.ShipToAddress1 ?? string.Empty;
            order.ShipToAddress2 = order.ShipToAddress2 ?? string.Empty;
            order.ShipToCity = order.ShipToCity ?? string.Empty;
            order.ShipToState = order.ShipToState ?? string.Empty;
            order.ShipToPostalCode = order.ShipToPostalCode ?? string.Empty;
            order.ShipToCountry = order.ShipToCountry ?? string.Empty;
            order.ShipToPhone = order.ShipToPhone ?? string.Empty;
            order.EmailListError = order.EmailListError ?? string.Empty;
        }

        public void LoadOrder(AllfleXML.FlexOrder.OrderHeader orderHeader)
        {
            order = orderHeader;
        }

        private void LoadComboBox()
        {
            cmbShippingMethods.DisplayMember = "Name";
            cmbShippingMethods.ValueMember = "Code";
            cmbShippingMethods.DataSource = ShippingMethod.GetShippingMethods().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
        }
    }
}
