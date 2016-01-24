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
using MRP4ME.Views;
using MRP4ME.Utilities;

namespace MRP4ME.UIElementsLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MenuControl : UserControl
    {
       public MenuControl()
        {
            InitializeComponent();
        }
        
       private void createPO_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dp = uiDockPanel();
            dp.Children.Add(new PurchaseOrderUI());
                
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dp = uiDockPanel();
            dp.Children.Add(new HomeUI());
        }

        private DockPanel uiDockPanel()
        {
            Grid gr = (Grid)this.Parent;
            DockPanel uiDP = new DockPanel();

            foreach (DockPanel dp in UtilityStaticClass.FindVisualChildren<DockPanel>(gr))
            {
                if (dp.Name.Equals("UIPanel"))
                {
                    uiDP = dp;
                    if (dp.Children.Count > 0)
                    {
                        dp.Children.Clear();
                    }
                    break;
                }
            }
            return uiDP;
        }

        
    }
}
