using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace bLaserTag
{
    public partial class PendingOrders : UserControl
    {
        private AllfleXML.FlexOrder.OrderHeader SelectedOrder;
        private readonly ContextMenu _contextMenu;
        private Dictionary<string, AllfleXML.FlexOrder.OrderHeader> pendingOrders = new Dictionary<string, AllfleXML.FlexOrder.OrderHeader>();

        public PendingOrders()
        {
            InitializeComponent();

            #region Setup Context Menu

            _contextMenu = new ContextMenu();

            var i0 = new MenuItem("View/Modify");
            var i1 = new MenuItem("Delete");

            i0.Click += i0_Clicked;
            i1.Click += i1_Clicked;

            _contextMenu.MenuItems.Add(i0);
            _contextMenu.MenuItems.Add(i1);

            #endregion
        }

        private void PendingOrders_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var watcher = new FileSystemWatcher(Program.PendingOrdersDirectory, "*.xml");
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += delegate (object s, FileSystemEventArgs evt) { LoadFiles(); };
            watcher.Created += delegate (object s, FileSystemEventArgs evt) { LoadFiles(); };
            watcher.Deleted += delegate (object s, FileSystemEventArgs evt) { LoadFiles(); };
            watcher.Renamed += delegate (object s, RenamedEventArgs evt) { LoadFiles(); };

            watcher.EnableRaisingEvents = true;

            LoadFiles();
        }
        
        private void LoadFiles()
        {
            pendingOrders = new Dictionary<string, AllfleXML.FlexOrder.OrderHeader>();
            foreach (var file in Directory.EnumerateFiles(Program.PendingOrdersDirectory, "*.xml"))
            {
                try
                {
                    var document = AllfleXML.FlexOrder.Parser.Import(file);
                    foreach(var orderHeader in document.OrderHeaders)
                    {
                        pendingOrders.Add(file, orderHeader);
                    }
                }
                catch (Exception ex)
                {
                    var msg = $"Could not load file `{file}`: {ex.Message}";
                    Debug.WriteLine(msg);
                }
            }

            LoadList();
        }

        private void LoadList()
        {
            if (lstPendingOrders.InvokeRequired)
            {
                lstPendingOrders.Invoke(new Action(LoadList));
                return;
            }

            lstPendingOrders.BeginUpdate();
            lstPendingOrders.Items.Clear();
            foreach(var order in pendingOrders)
            {
                var item = new ListViewItem(order.Value.PO);
                item.SubItems.Add("Pending");
                item.Tag = order.Value;

                lstPendingOrders.Items.Add(item);
            }
            lstPendingOrders.EndUpdate();

            lblTotalOrders.Text = lstPendingOrders.Items.Count.ToString();
            btnTransmit.Enabled = pendingOrders.Any();
        }

        private void lstPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOrder = lstPendingOrders.SelectedItems.Cast<ListViewItem>().FirstOrDefault()?.Tag as AllfleXML.FlexOrder.OrderHeader;

            /*
            MessageBox.Show($"File: {file}\nPurchase Order: {SelectedOrder.PO}");
            */
        }

        private void lstPendingOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // left click handler
            }
            if (e.Button == MouseButtons.Right)
            {
                if (SelectedOrder == null) return;

                _contextMenu.MenuItems[0].Enabled = true;//(!string.IsNullOrWhiteSpace(SelectedOrder.First));
                _contextMenu.MenuItems[1].Enabled = true;//(!string.IsNullOrWhiteSpace(SelectedItem.CUSTNMBR));
                _contextMenu.Show((ListView)sender, new Point(e.X, e.Y));
            }
        }

        private void LoadSelectedOrderFile()
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedOrderFile()
        {
            if (SelectedOrder == null) return;
            var file = pendingOrders.SingleOrDefault(o => o.Value == SelectedOrder).Key;
            if(pendingOrders.Count(o => o.Key == file) != 1)
            {
                throw new Exception($"PO {SelectedOrder.PO} is included in a file that contains multiple orders.");
            }

            File.Delete(file);
        }

        #region Context Menu Events

        private void i0_Clicked(object sender, EventArgs e)
        {
            LoadSelectedOrderFile();
        }

        private void i1_Clicked(object sender, EventArgs e)
        {
            DeleteSelectedOrderFile();
        }

        #endregion
    }
}
