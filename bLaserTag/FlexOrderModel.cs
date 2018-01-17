using System.Collections.Generic;
using System.ComponentModel;

namespace bLaserTag
{
    public class OrderHeader : INotifyPropertyChanged
    {
        private string customerNumber = string.Empty;
        public string CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value == customerNumber) return;
                customerNumber = value;
                NotifyPropertyChanged(nameof(CustomerNumber));
            }
        }

        private string premiseId = string.Empty;
        public string PremiseID
        {
            get { return premiseId; }
            set
            {
                if (value == premiseId) return;
                premiseId = value;
                NotifyPropertyChanged(nameof(PremiseID));
            }
        }

        private string comments = string.Empty;
        public string Comments
        {
            get { return comments; }
            set
            {
                if (value == comments) return;
                comments = value;
                NotifyPropertyChanged(nameof(Comments));
            }
        }

        private string po = string.Empty;
        public string PO
        {
            get { return po; }
            set
            {
                if (value == po) return;
                po = value;
                NotifyPropertyChanged(nameof(PO));
            }
        }

        private string shipToName = string.Empty;
        public string ShipToName
        {
            get { return shipToName; }
            set
            {
                if (value == shipToName) return;
                shipToName = value;
                NotifyPropertyChanged(nameof(ShipToName));
            }
        }

        private string shipToPhone = string.Empty;
        public string ShipToPhone
        {
            get { return shipToPhone; }
            set
            {
                if (value == shipToPhone) return;
                shipToPhone = value;
                NotifyPropertyChanged(nameof(ShipToPhone));
            }
        }

        private string shipToAddress1 = string.Empty;
        public string ShipToAddress1
        {
            get { return shipToAddress1; }
            set
            {
                if (value == shipToAddress1) return;
                shipToAddress1 = value;
                NotifyPropertyChanged(nameof(ShipToAddress1));
            }
        }

        private string shipToAddress2 = string.Empty;
        public string ShipToAddress2
        {
            get { return shipToAddress2; }
            set
            {
                if (value == shipToAddress2) return;
                shipToAddress2 = value;
                NotifyPropertyChanged(nameof(ShipToAddress2));
            }
        }

        private string shipToCity = string.Empty;
        public string ShipToCity
        {
            get { return shipToCity; }
            set
            {
                if (value == shipToCity) return;
                shipToCity = value;
                NotifyPropertyChanged(nameof(ShipToCity));
            }
        }

        private string shipToState = string.Empty;
        public string ShipToState
        {
            get { return shipToState; }
            set
            {
                if (value == shipToState) return;
                shipToState = value;
                NotifyPropertyChanged(nameof(ShipToState));
            }
        }

        private string shipToPostalCode = string.Empty;
        public string ShipToPostalCode
        {
            get { return shipToPostalCode; }
            set
            {
                if (value == shipToPostalCode) return;
                shipToPostalCode = value;
                NotifyPropertyChanged(nameof(ShipToPostalCode));
            }
        }

        private string shipToCountry = string.Empty;
        public string ShipToCountry
        {
            get { return shipToCountry; }
            set
            {
                if (value == shipToCountry) return;
                shipToCountry = value;
                NotifyPropertyChanged(nameof(ShipToCountry));
            }
        }

        private bool isRush = false;
        public bool IsRush
        {
            get { return isRush; }
            set
            {
                if (value == isRush) return;
                isRush = value;
                NotifyPropertyChanged(nameof(IsRush));
            }
        }

        private string shipMethod = string.Empty;
        public string ShipMethod
        {
            get { return shipMethod; }
            set
            {
                if (value == shipMethod) return;
                shipMethod = value;
                NotifyPropertyChanged(nameof(ShipMethod));
            }
        }

        private string shippingAccountNumber = string.Empty;
        public string ShippingAccountNumber
        {
            get { return shippingAccountNumber; }
            set
            {
                if (value == shippingAccountNumber) return;
                shippingAccountNumber = value;
                NotifyPropertyChanged(nameof(ShippingAccountNumber));
            }
        }

        private string emailListError = string.Empty;
        public string EmailListError
        {
            get { return emailListError; }
            set
            {
                if (value == emailListError) return;
                emailListError = value;
                NotifyPropertyChanged(nameof(EmailListError));
            }
        }

        private string emailListTrackingInfo = string.Empty;
        public string EmailListTrackingInfo
        {
            get { return emailListTrackingInfo; }
            set
            {
                if (value == emailListTrackingInfo) return;
                emailListTrackingInfo = value;
                NotifyPropertyChanged(nameof(EmailListTrackingInfo));
            }
        }

        private string emailListEIDInfo = string.Empty;
        public string EmailListEIDInfo
        {
            get { return emailListEIDInfo; }
            set
            {
                if (value == emailListEIDInfo) return;
                emailListEIDInfo = value;
                NotifyPropertyChanged(nameof(EmailListEIDInfo));
            }
        }

        private string wsOrderId = string.Empty;
        public string WSOrderId
        {
            get { return wsOrderId; }
            set
            {
                if (value == wsOrderId) return;
                wsOrderId = value;
                NotifyPropertyChanged(nameof(WSOrderId));
            }
        }

        public List<OrderLineHeader> OrderLineHeaders { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            System.Diagnostics.Debug.WriteLine($"Property Changed: {info}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public void Reset()
        {
            CustomerNumber = string.Empty;
            PremiseID = string.Empty;
            Comments = string.Empty;
            PO = string.Empty;
            ShipToName = string.Empty;
            ShipToPhone = string.Empty;
            ShipToAddress1 = string.Empty;
            ShipToAddress2 = string.Empty;
            ShipToCity = string.Empty;
            ShipToState = string.Empty;
            ShipToPostalCode = string.Empty;
            ShipToCountry = string.Empty;
            IsRush = false;
            ShipMethod = string.Empty;
            ShippingAccountNumber = string.Empty;
            EmailListError = string.Empty;
            EmailListTrackingInfo = string.Empty;
            EmailListEIDInfo = string.Empty;
            WSOrderId = string.Empty;
            OrderLineHeaders = new List<OrderLineHeader>();
        }
    }

    public class OrderLineHeader : INotifyPropertyChanged
    {
        private string skuName = string.Empty;
        public string SkuName
        {
            get { return skuName; }
            set
            {
                if (value == skuName) return;
                skuName = value;
                NotifyPropertyChanged(nameof(SkuName));
            }
        }

        private int quantity = 0;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value == quantity) return;
                quantity = value;
                NotifyPropertyChanged(nameof(Quantity));
            }
        }

        public List<OrderLineMarkingDetail> OrderLineMarkingDetail { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
    
    public class OrderLineMarkingDetail : INotifyPropertyChanged
    {
        public List<Variable> Variables { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }

    public class Variable : INotifyPropertyChanged
    {
        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == name) return;
                name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        private string value = string.Empty;
        public string Value
        {
            get { return value; }
            set
            {
                if (value == this.value) return;
                this.value = value;
                NotifyPropertyChanged(nameof(Value));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
