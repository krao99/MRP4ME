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
using System.Windows.Shapes;
using MRP4ME.Views;

namespace MRP4ME
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            
            InitializeComponent();
           // this.mainGrid.Children.Add(new HomeUI());
            DockPanel dp = this.UIPanel;
            dp.LastChildFill = true;
           this.UIPanel.Children.Add(new HomeUI());
           // MenuControl menu = new MenuControl();
          //  menu.poScreen += new EventHandler<EventArgs>(menu.poScreen);
            
            
           

        }

        

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
