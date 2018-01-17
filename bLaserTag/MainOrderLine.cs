using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bLaserTag
{
    public partial class MainOrderLine : UserControl
    {
        private readonly OrderLineHeader order = new OrderLineHeader();

        public event EventHandler<OrderLineHeader> LineCompleted;
        public event EventHandler LineCanceled;

        public MainOrderLine()
        {
            InitializeComponent();
        }

        private void MainOrderLine_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadComboBox();
            SetDataBindings();
        }
        

        private void LoadLine(AllfleXML.FlexOrder.OrderLineHeader line)
        {
            throw new NotImplementedException();
        }

        private void SetDataBindings()
        {
            throw new NotImplementedException();
        }

        private void LoadComboBox()
        {
            throw new NotImplementedException();
        }
    }
}
