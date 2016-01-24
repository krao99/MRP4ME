using MRP4ME.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MRP4ME.Views
{
    /// <summary>
    /// Interaction logic for PurchaseOrderUI.xaml
    /// </summary>
    public partial class PurchaseOrderUI : UserControl
    {
        public PurchaseOrderUI()
        {
            InitializeComponent();
        }

        private void btnAttachBrowse_Click(object sender, RoutedEventArgs e)
        {

        }
         private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dp = (DockPanel)this.Parent;
            dp.Children.Remove(this);
            dp.Children.Add(new HomeUI());
        }
        
    }
}
