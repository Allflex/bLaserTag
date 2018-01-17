using System;
using System.Windows.Forms;

namespace bLaserTag
{
    static class Program
    {
        public static string DefaultOrder;

        public static string APIKey;

        public static string OrdersDirectory;
        public static string PendingOrdersDirectory;
        public static string SentOrdersDirectory;
        public static string ErrorOrdersDirectory;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OrderHeader, AllfleXML.FlexOrder.OrderHeader>();
                cfg.CreateMap<OrderLineHeader, AllfleXML.FlexOrder.OrderLineHeader>();
                cfg.CreateMap<OrderLineMarkingDetail, AllfleXML.FlexOrder.OrderLineMarkingDetail>();
                cfg.CreateMap<Variable, AllfleXML.FlexOrder.Variable>();
            });

            ReloadConfiguration();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static void ReloadConfiguration()
        {
            DefaultOrder = System.Configuration.ConfigurationManager.AppSettings["DefaultOrder"];

            APIKey = System.Configuration.ConfigurationManager.AppSettings["APIKey"];

            OrdersDirectory = System.Configuration.ConfigurationManager.AppSettings["OrdersDirectory"];
            PendingOrdersDirectory = System.IO.Path.Combine(OrdersDirectory, "Pending");
            SentOrdersDirectory = System.IO.Path.Combine(OrdersDirectory, "Sent");
            ErrorOrdersDirectory = System.IO.Path.Combine(OrdersDirectory, "Error");

            SetupFilesystem();
        }

        static void SetupFilesystem()
        {
            if (!System.IO.Directory.Exists(OrdersDirectory))
            {
                System.IO.Directory.CreateDirectory(OrdersDirectory);
            }
            if (!System.IO.Directory.Exists(PendingOrdersDirectory))
            {
                System.IO.Directory.CreateDirectory(PendingOrdersDirectory);
            }
            if (!System.IO.Directory.Exists(SentOrdersDirectory))
            {
                System.IO.Directory.CreateDirectory(SentOrdersDirectory);
            }
            if (!System.IO.Directory.Exists(ErrorOrdersDirectory))
            {
                System.IO.Directory.CreateDirectory(ErrorOrdersDirectory);
            }
        }

        public static void UpdateDefaultOrder(OrderHeader order)
        {
            var doc = new AllfleXML.FlexOrder.Document
            {
                OrderHeaders = new System.Collections.Generic.List<AllfleXML.FlexOrder.OrderHeader>
                {
                    AutoMapper.Mapper.Map<OrderHeader, AllfleXML.FlexOrder.OrderHeader>(order)
                }
            };

            var tmp = AllfleXML.FlexOrder.Parser.Export(doc);
            tmp.Save(DefaultOrder);
        }
    }
}
