using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MMS.UI.Pages.SubPages
{
    class EmployeePage:SubPagebase
    {
        protected override void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void DeleteItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void AlterItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void RefreshData()
        {
            this.StatisticsData.ItemsSource = this.Db.Employee.OrderBy(p => p.EmployeeId).Take((int)this.CurrentPage * 10).Skip(((int)this.CurrentPage - 1) * 10).ToList();
        }
    }
}
