using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Shell;
using MRP4ME.Models;



namespace MRP4ME
{
	public partial class MainWindow : CustomChromeLibrary.CustomChromeWindow
	{

        private readonly POViewModel po ;

		public MainWindow()
		{
			InitializeComponent();
			DataContext = po = new POViewModel();
            po.UserName = "Admin";
            po.Level = 0;
		}

        private void btnSavePO_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bool result = po.AddPO();
                if (result)
                {
                    txtCustomerName.Text = "";
                    dtpRequiredDate.SelectedDate = DateTime.Now;
                    txtPONumber.Text = "";

                    txtDescription.Text = "";
                    txtAttachment.Text = "";
                    txtImage.Text = "";
                    MessageBox.Show("PO added successfully");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error just occurred, please try again.", "MRP4ME", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
                
            }
            
        

        private void BtnAttachmentBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDlg = new Microsoft.Win32.OpenFileDialog();
            fileDlg.Filter = "All files (*.*)|*.*";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = fileDlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = fileDlg.FileName;
                txtAttachment.Text = filename;
            }

           
        }

        private void BtnImageBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = fileDialog.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = fileDialog.FileName;
                txtImage.Text = filename;
            }


        }

        private void btnPurchaseOrder_Click(object sender, RoutedEventArgs e)
        {

            tabCtrlMain.SelectedItem = (TabItem)tabCtrlMain.FindName("tabItemCreatePO");
        }

        


        

    }
}


	

