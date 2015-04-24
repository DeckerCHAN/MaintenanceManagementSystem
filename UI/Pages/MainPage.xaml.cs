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
using MMS.UI.Pages.SubPages;

namespace MMS.UI.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public Dictionary<String, Page> SideBarListData = new Dictionary<string, Page>();
        public MainPage()
        {
            InitializeComponent();
            this.SideBarListData.Add(Properties.Resources.Client, new ClientPage());
            this.SideBarListData.Add(Properties.Resources.Employee,new EmployeePage());
            this.SideBarListData.Add(Properties.Resources.Company, new CompanyPage());
            this.SideBarListData.Add(Properties.Resources.MaintenanceRecord, new MaintenanceRecordPage());
            this.SideBarListData.Add(Properties.Resources.Device,new DevicePage());
            this.SideBarListData.Add(Properties.Resources.Component,new ComponentPage());
            this.SideBarList.ItemsSource = this.SideBarListData.Keys.ToArray();
        }

        private void ChangeToPage_OnChecked(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = this.SideBarListData[(String)((RadioButton)sender).Content];
        }
    }
}
