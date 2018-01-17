using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace bLaserTag
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            mainOrder1.OrderCompleted += (sender, order) => MainOrder1_OrderCompleted(order);
        }

        private void MainOrder1_OrderCompleted(OrderHeader order)
        {
            var doc = new AllfleXML.FlexOrder.Document
            {
                OrderHeaders = new List<AllfleXML.FlexOrder.OrderHeader>
                {
                    AutoMapper.Mapper.Map<OrderHeader, AllfleXML.FlexOrder.OrderHeader>(order)
                }
            };

            var tmp = AllfleXML.FlexOrder.Parser.Export(doc);
            var fileName = System.IO.Path.GetRandomFileName();
            fileName = System.IO.Path.ChangeExtension(fileName, "xml");
            fileName = System.IO.Path.Combine(Program.PendingOrdersDirectory, fileName);
            tmp.Save(fileName);

            //MessageBox.Show("Method not implemented\n" + fileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
