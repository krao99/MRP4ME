using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.ComponentModel;

namespace MRP4ME.Models
{
    public class POViewModel: Framework.ObservableBase, INotifyDataErrorInfo
    {


       
        public bool valid = true;

            private string customerName;
            private DateTime requiredDate;
            private int poNumber;
            private String itemCode;
            private String unit;
            private double unitCost;
            private String description;
            private int quantity;
            private int quantityReceived;
            private int qtyBackOrdered;
            private String attachment;
            private String image;
            private String userName;
            private int level;



            /// <summary>
            /// Gets/sets the Customer Name for the PurchaseOrder.
            /// </summary>
            public string CustomerName
            {
                get { return customerName; }
                set
                {
                    if (customerName == value) return;
                    customerName = value;
                }
            }
            /// <summary>
            /// Gets/sets the PurchaseOrder's required date.
            /// </summary>
            public DateTime RequiredDate
            {
                get { return (requiredDate - DateTime.MinValue).TotalDays == 0 ? DateTime.Now : requiredDate; }
                set
                {
                    if (requiredDate == value) return;
                    requiredDate = value;
                }
            }

            /// <summary>
            /// Gets/sets the PurchaseOrder's PO#.
            /// </summary>
            public int PONumber
            {
                get { return poNumber; }
                set
                {
                    if (poNumber == value) return;
                    poNumber = value;
                }
            }
            /// <summary>
            /// Gets/sets the Item Code.  
            /// </summary>
            public string ItemCode
            {
                get { return itemCode; }
                set
                {
                    if (itemCode == value) return;
                    itemCode = value;
                }
            }

            /// <summary>
            /// Gets/sets the PurchaseOrder's location
            /// </summary>
            public string Unit
            {
                get { return unit; }
                set
                {
                    if (unit == value) return;
                    unit = value;
                }
            }
            /// <summary>
            /// Gets/sets the cost of unit
            /// </summary>
            public double UnitCost
            {
                get { return unitCost; }
                set
                {
                    if (unitCost == value) return;
                    unitCost = value;
                }
            }
            /// <summary>
            /// Gets/sets the PurchaseOrder's Description
            /// </summary>
            public string Description
            {
                get { return description; }
                set
                {
                    if (description == value) return;
                    description = value;
                }
            }
            /// <summary>
            /// Gets/sets the PurchaseOrder's quantity
            /// </summary>
            public int Quantity
            {
                get { return quantity; }
                set
                {
                    if (quantity == value) return;
                    quantity = value;
                }
            }
            /// <summary>
            /// Gets/sets the PurchaseOrder's QuantityReceived
            /// </summary>
            public int QuantityReceived
            {
                get { return quantityReceived; }
                set
                {
                    if (quantityReceived == value) return;
                    quantityReceived = value;
                }
            }
            /// <summary>
            /// Gets/sets the PurchaseOrder's Quantity Backorderered
            /// </summary>
            public int QtyBackOrdered
            {
                get { return qtyBackOrdered; }
                set
                {
                    if (qtyBackOrdered == value) return;
                    qtyBackOrdered = value;
                }
            }

            /// <summary>
            /// Gets/sets the Attachment file path
            /// </summary>
            public String Attachment
            {
                get { return attachment; }
                set
                {
                    if (attachment == value) return;
                    attachment = value;
                }
            }

            /// <summary>
            /// Gets/sets the Image file path
            /// </summary>
            public String Image
            {
                get { return image; }
                set
                {
                    if (image == value) return;
                    image = value;
                }
            }

            /// <summary>
            /// Gets/sets the user name 
            /// </summary>
            public String UserName
            {
                get { return userName; }
                set
                {
                    if (userName == value) return;
                    userName = value;
                }
            }

            /// <summary>
            /// Gets/sets the level 
            /// </summary>
            public int Level
            {
                get { return level; }
                set
                {
                    if (level == value) return;
                    level = value;
                }
            }
        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            List<string> errorsForName;
            _errors.TryGetValue("CustomerName", out errorsForName);
            return errorsForName;
        }

        public bool HasErrors
        {
            get { return _errors.Values.FirstOrDefault(l => l.Count > 0) != null; }
        }

        private Dictionary<string, List<string>> _errors =
            new Dictionary<string, List<string>>();

        private object _lock = new object();
        private void Validate()
        {
            //Validate Name
            List<string> errorsForName;
            if (!_errors.TryGetValue("CustomerName", out errorsForName))
                errorsForName = new List<string>();
            else errorsForName.Clear();

            if (String.IsNullOrEmpty(CustomerName))
                errorsForName.Add("The customer name can't be null or empty.");

            _errors["CustomerName"] = errorsForName;
            if (errorsForName.Count > 0) RaiseErrorsChanged("CustomerName");
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public void RaiseErrorsChanged(string propertyName)
        {
            EventHandler<DataErrorsChangedEventArgs> handler = ErrorsChanged;
            if (handler == null) return;
            var arg = new DataErrorsChangedEventArgs(propertyName);
            handler.Invoke(this, arg);
        }



        public bool isPOValid()
        {
            valid = true;
            
            if (this.PONumber <= 0)
            {
                valid = false;
                throw new ApplicationException("PO is required.");
            }



            if (String.IsNullOrEmpty(this.CustomerName))
            {
                valid = false;
                throw new ApplicationException("CustomerName is required.");
            }

            if (String.IsNullOrEmpty(this.Description))
            {
                valid = false;
                throw new ApplicationException("Description is required.");
            }

            return valid;
        }

        public bool AddPO()
        {
            String insertQry = "insert into purchase_order(customer_name, required_date, PO_Number, Item_Code," +
                            " unit, Unit_Cost, description, quantity, Quantity_Received, back_ordered, attachment, upload_image, user, level)" +
                "values (@customerName, @requiredDate, @poNumber, @itemCode," +
                            " @unit, @unitCost, @description, @quantity, @quantityReceived, @qtyBackOrdered, @attachment, @image, @userName, @level)";

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand();

            if (conn.State != System.Data.ConnectionState.Open)
            {
                    conn.Open();
             }

           cmd.CommandText = insertQry;
           cmd.Connection = conn;

           cmd.Prepare();
                
           cmd.Parameters.AddWithValue("@customerName", this.CustomerName);
           cmd.Parameters.AddWithValue("@requiredDate", this.RequiredDate);
           cmd.Parameters.AddWithValue("@poNumber", this.PONumber);
           cmd.Parameters.AddWithValue("@itemCode", this.ItemCode);
           cmd.Parameters.AddWithValue("@unit", this.Unit);
           cmd.Parameters.AddWithValue("@unitCost", this.UnitCost);
           cmd.Parameters.AddWithValue("@description", this.Description);
           cmd.Parameters.AddWithValue("@quantity", this.Quantity);
           cmd.Parameters.AddWithValue("@quantityReceived", this.QuantityReceived);
           cmd.Parameters.AddWithValue("@qtyBackOrdered", this.QtyBackOrdered);
           cmd.Parameters.AddWithValue("@attachment", this.Attachment);
           cmd.Parameters.AddWithValue("@image", this.Image);
           cmd.Parameters.AddWithValue("@userName", this.UserName);//user
           cmd.Parameters.AddWithValue("@level", this.Level);
                
                /*
                cmd.Parameters.AddWithValue("@po", "TE1234");
                cmd.Parameters.AddWithValue("@name", "Test Name");
                cmd.Parameters.AddWithValue("@description", "Test Description");
                cmd.Parameters.AddWithValue("@attachment", "Test Attachment");
                cmd.Parameters.AddWithValue("@image", "Test Image");
                cmd.Parameters.AddWithValue("@user", "Kotesh");//user
                cmd.Parameters.AddWithValue("@level", 0);
                */
           cmd.ExecuteNonQuery();
                //cmd.Dispose();
           conn.Close();
           this.CustomerName = "";    
           this.PONumber = 0;
           this.ItemCode = "";
           this.Unit = "";
           this.UnitCost = 0;
           this.Description = "";
           this.Quantity = 0;
           this.QuantityReceived = 0;
           this.QtyBackOrdered = 0;
           this.Attachment = "";
           this.Image = "";
                
            

            return true;
        }

    }
}
